using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraNavBar;
using DevExpress.XtraGrid.Views.WinExplorer;
using CafePrintter.Base;
using DevExpress.Data.Filtering;
using CafePrintter.Global;
using CafePrinter.Helper;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Controls;

namespace CafePrintter.Forms
{
    public partial class ExplorerView : FrmChildBase, IFileSystemNavigationSupports
    {
        private RectangleF clipRect_Ori = new RectangleF(0, 0, 0, 0);
        private RectangleF clipRect = new RectangleF(0, 0, 0, 0);
        bool ZoomPercentChanged;

        string currentPath;
        public ExplorerView() {
            InitializeComponent();

            // Load data
            GlobalSetting.Data = JsonHelper.GetData();

            if (GlobalSetting.Data != null)
            {
                btnPrint.Text = String.Format("{0}({1})", "In", GlobalSetting.Data.printer_counter);
                lblCounter.Text = String.Format("{0} ({1})", "Đã in", GlobalSetting.Data.printer_counter);
                currentPath = GlobalSetting.Data.folder_path;
            }

            Dictionary<int, string> sizemodeEnums = Enum.GetValues(typeof(DevExpress.XtraEditors.Controls.PictureSizeMode))
                .Cast<DevExpress.XtraEditors.Controls.PictureSizeMode>().ToDictionary(x => (int)x, x => x.ToString());

            lueSizeMode.Properties.ValueMember = "Key";
            lueSizeMode.Properties.DisplayMember = " Value";
            lueSizeMode.Properties.DataSource = sizemodeEnums;

            //clipRect_Ori = new Rectangle(0, 0, pictureEdit1.Width, pictureEdit1.Height);
            //clipRect = new Rectangle(0, 0, pictureEdit1.Width, pictureEdit1.Height);
            clipRect_Ori = pictureEdit1.DisplayRectangle;
            clipRect = pictureEdit1.DisplayRectangle;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Initialize();
        }
        void Initialize() {
            InitializeBreadCrumb();
            InitializeNavBar();
            InitializeAppearance();
            CalcPanels();
            UpdateView();
        }
        void InitializeBreadCrumb() {
            //this.currentPath = StartupPath;
            BreadCrumb.Path = this.currentPath;
            foreach(DriveInfo driveInfo in FileSystemHelper.GetFixedDrives()) {
                BreadCrumb.Properties.History.Add(new BreadCrumbHistoryItem(driveInfo.RootDirectory.ToString()));
            }
        }
        void InitializeAppearance() {
            GalleryItem item = rgbiViewStyle.Gallery.GetCheckedItem();
            if(item != null)
                this.winExplorerView.OptionsView.Style = (WinExplorerViewStyle)item.Tag;
        }
        void OnBreadCrumbPathChanged(object sender, BreadCrumbPathChangedEventArgs e) {
            this.currentPath = e.Path;
            UpdateView();
            UpdateButtons();
        }
        void OnBreadCrumbNewNodeAdding(object sender, BreadCrumbNewNodeAddingEventArgs e) {
            e.Node.PopulateOnDemand = true;
        }
        void OnBreadCrumbQueryChildNodes(object sender, BreadCrumbQueryChildNodesEventArgs e) {
            if(e.Node.Caption == "Root") {
                InitBreadCrumbRootNode(e.Node);
                return;
            }
            if(e.Node.Caption == "Computer") {
                InitBreadCrumbComputerNode(e.Node);
                return;
            }
            string dir = e.Node.Path;
            if(!FileSystemHelper.IsDirExists(dir))
                return;
            string[] subDirs = FileSystemHelper.GetSubFolders(dir);
            for(int i = 0; i < subDirs.Length; i++) {
                e.Node.ChildNodes.Add(CreateNode(subDirs[i]));
            }
        }
        void InitBreadCrumbRootNode(BreadCrumbNode node) {
            node.ChildNodes.Add(new BreadCrumbNode("Desktop", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
            node.ChildNodes.Add(new BreadCrumbNode("Documents", Environment.GetFolderPath(Environment.SpecialFolder.Recent)));
            node.ChildNodes.Add(new BreadCrumbNode("Music", Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
            node.ChildNodes.Add(new BreadCrumbNode("Pictures", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)));
            node.ChildNodes.Add(new BreadCrumbNode("Video", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)));
            node.ChildNodes.Add(new BreadCrumbNode("Program Files", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)));
            node.ChildNodes.Add(new BreadCrumbNode("Windows", Environment.GetFolderPath(Environment.SpecialFolder.Windows)));
        }
        void InitBreadCrumbComputerNode(BreadCrumbNode node) {
            foreach(DriveInfo driveInfo in FileSystemHelper.GetFixedDrives()) {
                node.ChildNodes.Add(new BreadCrumbNode(driveInfo.Name, driveInfo.RootDirectory));
            }
        }
        void OnBreadCrumbValidatePath(object sender, BreadCrumbValidatePathEventArgs e) {
            if(!FileSystemHelper.IsDirExists(e.Path)) {
                e.ValidationResult = BreadCrumbValidatePathResult.Cancel;
                return;
            }
            e.ValidationResult = BreadCrumbValidatePathResult.CreateNodes;
        }
        void OnBreadCrumbRootGlyphClick(object sender, EventArgs e) {
            BreadCrumb.Properties.BreadCrumbMode = BreadCrumbMode.Edit;
            BreadCrumb.SelectAll();
        }
        BreadCrumbNode CreateNode(string path) {
            string folderName = FileSystemHelper.GetDirName(path);
            return new BreadCrumbNode(folderName, folderName, true);
        }
        protected string StartupPath { get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop); } }

        void UpdateView() {
            Cursor oldCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                if(!string.IsNullOrEmpty(this.currentPath))
                    gridControl.DataSource = FileSystemHelper.GetFileSystemEntries(this.currentPath, GetItemSizeType(ViewStyle), GetItemSize(ViewStyle));
                else
                    gridControl.DataSource = null;
                winExplorerView.RefreshData();
                EnsureSearchEdit();
                BeginInvoke(new MethodInvoker(winExplorerView.ClearSelection));
            }
            finally {
                Cursor.Current = oldCursor;
            }
        }
        void EnsureSearchEdit() {
            EditSearch.Properties.NullText = "Search " + FileSystemHelper.GetDirName(this.currentPath);
            EditSearch.EditValue = null;
            this.winExplorerView.FindFilterText = string.Empty;
        }
        void OnNavPanelLinkClicked(object sender, NavBarLinkEventArgs e) {
            BreadCrumb.Path = (string)e.Link.Item.Tag;
        }
        void OnShowNavPaneItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            BarCheckItem item = (BarCheckItem)e.Item;
            this.liNavPaneRight.Visibility = item.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            this.navBar.Visible = item.Checked;
        }
        void OnShowFavoritesItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.groupFavorites.Visible = ((BarCheckItem)e.Item).Checked;
        }
        void OnShowLibrariesItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            groupLibraries.Visible = ((BarCheckItem)e.Item).Checked;
        }
        void OnShowCheckBoxesItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.winExplorerView.OptionsView.ShowCheckBoxes = ((BarCheckItem)e.Item).Checked;
        }
        void InitializeNavBar() {
            navPanelItemDesktop.Tag = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            navPanelItemRecent.Tag = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
            navPanelItemDocuments.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            navPanelItemMusic.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            navPanelItemPictures.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            navPanelItemVideos.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            navPanelItemDownloads.Tag = FileSystemHelper.GetDownloadsDir();
            if(navPanelItemDownloads.Tag == null) navPanelItemDownloads.Visible = false;
        }
        void OnViewStyleGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            GalleryItem item = e.Item;
            if(!item.Checked) return;
            WinExplorerViewStyle viewStyle = (WinExplorerViewStyle)Enum.Parse(typeof(WinExplorerViewStyle), item.Tag.ToString());
            this.winExplorerView.OptionsView.Style = viewStyle;
            FileSystemImageCache.Cache.ClearCache();
            UpdateView();
        }
        void OnRgbiViewStyleInitDropDown(object sender, InplaceGalleryEventArgs e) {
            e.PopupGallery.SynchWithInRibbonGallery = true;
        }
        void OnEditSearchTextChanged(object sender, EventArgs e) {
            this.winExplorerView.FindFilterText = EditSearch.Text;
        }
        void OnSelectAllItemClick(object sender, ItemClickEventArgs e) {
            this.winExplorerView.SelectAll();
        }
        void OnSelectNoneItemClick(object sender, ItemClickEventArgs e) {
            this.winExplorerView.ClearSelection();
        }
        void OnInvertSelectionItemClick(object sender, ItemClickEventArgs e) {
            for(int i = 0; i < this.winExplorerView.RowCount; i++) this.winExplorerView.InvertRowSelection(i);
        }
        void OnShowFileNameExtensionsCheckItemClick(object sender, ItemClickEventArgs e) {
            FileSystemEntryCollection col = gridControl.DataSource as FileSystemEntryCollection;
            if(col == null) return;
            col.ShowExtensions = ((BarCheckItem)e.Item).Checked;
            gridControl.RefreshDataSource();
        }
        void OnShowHiddenItemsCheckItemClick(object sender, ItemClickEventArgs e) {
            btnHideSelectedItems.Enabled = !((BarCheckItem)e.Item).Checked;
        }
        void OnHelpButtonItemClick(object sender, ItemClickEventArgs e) {
            FileSystemHelper.Run("http://help.devexpress.com");
        }
        void OnOptionsItemClick(object sender, ItemClickEventArgs e) {
            IEnumerable<FileSystemEntry> entries = GetSelectedEntries();
            if(entries.Count() == 0) {
                FileSystemHelper.ShellExecuteFileInfo(this.currentPath, ShellExecuteInfoFileType.Properties);
                return;
            }
            foreach(FileSystemEntry entry in entries) entry.ShowProperties();
        }
        void OnWinExplorerViewSelectionChanged(object sender, SelectionChangedEventArgs e) {
            UpdateButtons();

            
        }
        void OnCopyPathItemClick(object sender, ItemClickEventArgs e) {
            StringBuilder builder = new StringBuilder();
            foreach(FileSystemEntry entry in GetSelectedEntries()) {
                builder.AppendLine(entry.Path);
            }
            if(!string.IsNullOrEmpty(builder.ToString())) Clipboard.SetText(builder.ToString());
        }
        void OnOpenItemClick(object sender, ItemClickEventArgs e) {
            foreach(FileSystemEntry entry in GetSelectedEntries(true)) {
                entry.DoAction(this);
            }
        }
        void OnWinExplorerViewKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode != Keys.Enter) return;
            FileSystemEntry entry = GetSelectedEntries().LastOrDefault();
            if(entry != null) entry.DoAction(this);
        }
        void OnWinExplorerViewItemClick(object sender, WinExplorerViewItemClickEventArgs e) {
            if(e.MouseInfo.Button == MouseButtons.Right) itemPopupMenu.ShowPopup(Cursor.Position);

            pictureEdit1.LoadAsync(((FileSystemEntry)e.ItemInfo.Row.RowKey).Path);


        }
        void OnWinExplorerViewItemDoubleClick(object sender, WinExplorerViewItemDoubleClickEventArgs e) {
            if(e.MouseInfo.Button != MouseButtons.Left) return;
            winExplorerView.ClearSelection();
            ((FileSystemEntry)e.ItemInfo.Row.RowKey).DoAction(this);
        }
        void UpdateButtons() {
            int selEntriesCount = GetSelectedEntries().Count();
            this.btnOpen.Enabled = this.btnCopyItem.Enabled = selEntriesCount > 0;
            this.btnUpTo.Enabled = BreadCrumb.CanGoUp;
            this.btnBack.Enabled = BreadCrumb.CanGoBack;
            this.btnForward.Enabled = BreadCrumb.CanGoForward;
        }
        void OnBackButtonClick(object sender, EventArgs e) {
            BreadCrumb.GoBack();
        }
        void OnNextButtonClick(object sender, EventArgs e) {
            BreadCrumb.GoForward();
        }
        void OnUpButtonClick(object sender, EventArgs e) {
            BreadCrumb.GoUp();
        }
        void OnNavigationMenuButtonClick(object sender, EventArgs e) {
            navigationMenu.ItemLinks.Clear();
            navigationMenu.ItemLinks.AddRange(GetNavigationHistroryItems().ToArray());
            navigationMenu.ShowPopup(PointToScreen(new Point(0, navigationPanel.Bottom)));
        }
        IEnumerable<BarItem> GetNavigationHistroryItems() {
            BreadCrumbHistory history = BreadCrumb.GetNavigationHistory();
            for(int i = history.Count - 1; i >= 0; i--) {
                BreadCrumbHistoryItem item = history[i];
                BarCheckItem menuItem = new BarCheckItem();
                menuItem.Tag = i;
                menuItem.Caption = FileSystemHelper.GetDirName(item.Path);
                menuItem.ItemClick += OnNavigationMenuItemClick;
                menuItem.Checked = BreadCrumb.GetNavigationHistoryCurrentItemIndex() == i;
                yield return menuItem;
            }
        }
        void OnNavigationMenuItemClick(object sender, ItemClickEventArgs e) {
            BreadCrumb.SetNavigationHistoryCurrentItemIndex((int)e.Item.Tag);
            UpdateButtons();
        }
        List<FileSystemEntry> GetSelectedEntries() { return GetSelectedEntries(false); }
        List<FileSystemEntry> GetSelectedEntries(bool sort) {
            List<FileSystemEntry> list = new List<FileSystemEntry>();
            int[] rows = winExplorerView.GetSelectedRows();
            for(int i = 0; i < rows.Length; i++) {
                list.Add((FileSystemEntry)winExplorerView.GetRow(rows[i]));
            }
            if(sort) list.Sort(new FileSytemEntryComparer());
            return list;
        }
        Size GetItemSize(WinExplorerViewStyle viewStyle) {
            switch(viewStyle) {
                case WinExplorerViewStyle.ExtraLarge: return new Size(256, 256);
                case WinExplorerViewStyle.Large: return new Size(96, 96);
                case WinExplorerViewStyle.Content: return new Size(32, 32);
                case WinExplorerViewStyle.Small: return new Size(16, 16);
                case WinExplorerViewStyle.Tiles:
                case WinExplorerViewStyle.Default:
                case WinExplorerViewStyle.List:
                case WinExplorerViewStyle.Medium:
                default: return new Size(96, 96);
            }
        }
        IconSizeType GetItemSizeType(WinExplorerViewStyle viewStyle) {
            switch(viewStyle) {
                case WinExplorerViewStyle.Large:
                case WinExplorerViewStyle.ExtraLarge: return IconSizeType.ExtraLarge;
                case WinExplorerViewStyle.List:
                case WinExplorerViewStyle.Small: return IconSizeType.Small;
                case WinExplorerViewStyle.Tiles:
                case WinExplorerViewStyle.Medium:
                case WinExplorerViewStyle.Content: return IconSizeType.Large;
                default: return IconSizeType.ExtraLarge;
            }
        }
        void CalcPanels() {
            this.navigationPanel.Location = Point.Empty;
            this.contentPanel.Location = new Point(0, this.navigationPanel.Bottom - 1);
            this.contentPanel.Height = Height - this.navigationPanel.Height + 1;
        }
        public BreadCrumbEdit BreadCrumb { get { return editBreadCrumb; } }
        public WinExplorerViewStyle ViewStyle { get { return this.winExplorerView.OptionsView.Style; } }

        #region IFileSystemNavigationSupports
        string IFileSystemNavigationSupports.CurrentPath {
            get { return currentPath; }
        }
        void IFileSystemNavigationSupports.UpdatePath(string path) {
            BreadCrumb.Path = path;
        }

        private void btnXoayTrai_Click(object sender, EventArgs e)
        {
            pictureEdit2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureEdit2.Refresh();
        }

        private void btnXoayPhai_Click(object sender, EventArgs e)
        {
            pictureEdit2.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureEdit2.Refresh();
        }

        private void btnXoayNgang_Click(object sender, EventArgs e)
        {
            pictureEdit2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureEdit2.Refresh();
        }

        private void btnXoayDoc_Click(object sender, EventArgs e)
        {
            pictureEdit2.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureEdit2.Refresh();
        }

        private void gridControl_DataSourceChanged(object sender, EventArgs e)
        {
            columnName.FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(BinaryOperator.Or("LIKE %png%", "LIKE %jpg%"));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(GlobalSetting.Data != null)
            {
                Print(GlobalSetting.Data.printer_name);

                // Cập nhật giao diện
                if (GlobalSetting.Data != null)
                {
                    GlobalSetting.Data.printer_counter++;
                }

                string jsonData = JsonHelper.DataToJson(GlobalSetting.Data);
                JsonHelper.SaveAndRefresh(jsonData);

                btnPrint.Text = String.Format("{0}({1})", "In", GlobalSetting.Data.printer_counter);
                lblCounter.Text = String.Format("{0} ({1})", "Đã in", GlobalSetting.Data.printer_counter);
            }
            else
            {
                MessageBox.Show("Vui lòng cấu hình máy in.");
            }
        }

        public void Print(string printerName)
        {
            try
            {
                var tempFile = Path.GetTempFileName();
                pictureEdit2.Image.Save(tempFile);
                if (string.IsNullOrWhiteSpace(tempFile)) return; // Prevents execution of below statements if filename is not selected.

                PrintDocument pd = new PrintDocument();

                //Disable the printing document pop-up dialog shown during printing.
                PrintController printController = new StandardPrintController();
                pd.PrintController = printController;

                //For testing only: Hardcoded set paper size to particular paper.
                //pd.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Custom 6x4", 720, 478);
                //pd.DefaultPageSettings.PaperSize = new PaperSize("Custom 6x4", 720, 478);

                pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                pd.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

                pd.PrintPage += (sndr, args) =>
                {
                    System.Drawing.Image i = System.Drawing.Image.FromFile(tempFile);

                    //Adjust the size of the image to the page to print the full image without loosing any part of the image.
                    System.Drawing.Rectangle m = args.MarginBounds;

                    //Logic below maintains Aspect Ratio.
                    if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) // image is wider
                    {
                        m.Height = (int)((double)i.Height / (double)i.Width * (double)m.Width);
                    }
                    else
                    {
                        m.Width = (int)((double)i.Width / (double)i.Height * (double)m.Height);
                    }
                    //Calculating optimal orientation.
                    pd.DefaultPageSettings.Landscape = m.Width > m.Height;
                    //Putting image in center of page.
                    m.Y = (int)((((System.Drawing.Printing.PrintDocument)(sndr)).DefaultPageSettings.PaperSize.Height - m.Height) / 2);
                    m.X = (int)((((System.Drawing.Printing.PrintDocument)(sndr)).DefaultPageSettings.PaperSize.Width - m.Width) / 2);
                    args.Graphics.DrawImage(i, m);
                };
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private void btnCropImage_Click(object sender, EventArgs e)
        {
            pictureEdit2.EditValue = null;
            
            //Image srcImage = pictureEdit1.Image;
            //Image dstImage = CropToCircle(srcImage, Color.CadetBlue);
            //dstImage.Save(@"080cropped.jpg", ImageFormat.Jpeg);
            //pictureEdit1.Image = dstImage;
            //pictureEdit1.Refresh();



            pictureEdit2.Image = ClipToCircle(pictureEdit1.Image, new PointF(1, 1), 0.5F);
            pictureEdit2.Refresh();

            //pictureEdit2.Image = ClipImage(pictureEdit1.Image, clipRect);
            //pictureEdit2.Refresh();
        }

        

        public Image CropToCircle(Image srcImage, Color backGround)
        {
            //Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            //Graphics g = Graphics.FromImage(dstImage);
            //using (Brush br = new SolidBrush(backGround))
            //{
            //    g.FillRectangle(br, 0, 0, pictureEdit1.Width, pictureEdit1.Height);
            //}
            //GraphicsPath path = new GraphicsPath();
            ////path.AddEllipse(0, 0, dstImage.Width, dstImage.Height);
            ////path.AddEllipse(0, 0, pictureEdit1.Width, pictureEdit1.Height);
            //float radius = dstImage.Width / 2;
            //Point center = new Point(dstImage.Width / 2, dstImage.Height / 2);
            //path.AddEllipse(new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2));
            //g.DrawPath(Pens.Red, path);

            ////g.SetClip(path);
            //g.DrawImage(srcImage, 0, 0);


            Image dstImage = new Bitmap(pictureEdit1.Width, pictureEdit1.Height, srcImage.PixelFormat);
            Graphics g = Graphics.FromImage(dstImage);
            g.SetClip(path);

            return dstImage;
        }

        private void lueSizeMode_EditValueChanged(object sender, EventArgs e)
        {
            pictureEdit1.Properties.SizeMode = (DevExpress.XtraEditors.Controls.PictureSizeMode)(lueSizeMode.EditValue);
        }

        float radius = 0;
        PointF center = new PointF(0, 0);
        GraphicsPath path = null;
        private void pictureEdit1_Paint(object sender, PaintEventArgs e)
        {
            //if (pictureEdit1.Image != null)
            {
                //if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                //{
                //    e.Graphics.FillRectangle(selectionBrush, Rect);
                //}

                //using (Brush br = new SolidBrush(Color.Black))
                //{
                //    e.Graphics.FillRectangle(br, 0, 0, pictureEdit1.Width, pictureEdit1.Height);
                //}

                radius = pictureEdit1.Width / 2;
                center = new Point(pictureEdit1.Width / 2, pictureEdit1.Height / 2);
                path = new GraphicsPath();
                //path.AddEllipse(new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2));
                path.AddEllipse(clipRect_Ori);
                e.Graphics.DrawPath(Pens.Red, path);
            }

            //Clip Rectangle
            //e.Graphics.DrawRectangle(Pens.Lime, clipRect_Ori.X, clipRect_Ori.Y, clipRect_Ori.Width, clipRect_Ori.Height);
        }
        #endregion
        //#region ReportGeneration
        //public override bool AllowGenerateReport { get { return false; } }
        //#endregion


        


        public Image ClipToCircle(Image original, PointF center, float radius)
        {
            //Bitmap copy = new Bitmap(original);
            //using (Graphics g = Graphics.FromImage(copy))
            //{
            //    //RectangleF r = new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2);
            //    GraphicsPath path = new GraphicsPath();
            //    path.AddEllipse(clipRect);
            //    //g.Clip = new Region(path);

            //    //g.DrawImage(original, 0, 0);
            //    g.DrawPath(Pens.Red, path);
            //    g.SetClip(path);
            //    //g.DrawImage(original, 0, 0);





            //    return (Image)copy;
            //}



            Bitmap dstImage = new Bitmap(original.Width, original.Height, original.PixelFormat);
            Graphics g = Graphics.FromImage(dstImage);
               using (Brush br = new SolidBrush(Color.Plum)) {
                   g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
               }
               GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(0, 0, dstImage.Width, dstImage.Height);
            path.AddEllipse(clipRect);
               g.SetClip(path);
               g.DrawImage(original, 0, 0);
            dstImage.MakeTransparent(Color.Plum);

            //pictureEdit2.Image = ClipImage(pictureEdit1.Image, clipRect);
            //pictureEdit2.Refresh();

            Image img = new Bitmap(dstImage);
            img = ClipImage(dstImage, clipRect);
            return img;
                
        }

        /// <summary>
        /// Returns a clipped area of an image.
        /// </summary>
        private Image ClipImage(Image originalImg, RectangleF clipRectangle)
        {
            Bitmap clippedBmp = new Bitmap((int)clipRectangle.Width, (int)clipRectangle.Height);

            using (Graphics g = Graphics.FromImage(clippedBmp))
            {
                g.DrawImage(originalImg,
                            new Rectangle(0, 0, (int)clipRectangle.Width, (int)clipRectangle.Height),
                            clipRectangle,
                            GraphicsUnit.Pixel);
            }

            return (Image)clippedBmp;
        }

        private void pictureEdit1_MouseMove(object sender, MouseEventArgs e)
        {
            ////Handles the click-dragging logic for the clipping rectangle visual
            //if (e.Button == MouseButtons.Left ||
            //   (SystemInformation.MouseButtonsSwapped &&
            //    e.Button == MouseButtons.Right))
            //{
            //    Point topLeft = new Point(clipRect.Left, clipRect.Top);
            //    Point topRight = new Point(clipRect.Right, clipRect.Top);
            //    Point bottomLeft = new Point(clipRect.Left, clipRect.Bottom);
            //    Point bottomRight = new Point(clipRect.Right, clipRect.Bottom);

            //    Point mouse = new Point(e.X, e.Y);

            //    int threshold = 15;

            //    //Act on the closest point to the cursor
            //    if (GetDistance(mouse, topLeft) <= threshold)
            //    {
            //        topLeft = mouse;
            //        bottomLeft.X = topLeft.X;
            //        topRight.Y = topLeft.Y;
            //    }
            //    else if (GetDistance(mouse, topRight) <= threshold)
            //    {
            //        topRight = mouse;
            //        bottomRight.X = topRight.X;
            //        topLeft.Y = topRight.Y;
            //    }
            //    else if (GetDistance(mouse, bottomLeft) <= threshold)
            //    {
            //        bottomLeft = mouse;
            //        topLeft.X = bottomLeft.X;
            //        bottomRight.Y = bottomLeft.Y;
            //    }
            //    else if (GetDistance(mouse, bottomRight) <= threshold)
            //    {
            //        bottomRight = mouse;
            //        topRight.X = bottomRight.X;
            //        bottomLeft.Y = bottomRight.Y;
            //    }
            //    else if (clipRect.Contains(mouse))
            //    {
            //        topLeft.X = mouse.X - (clipRect.Width / 2);
            //        topLeft.Y = mouse.Y - (clipRect.Height / 2);

            //        topRight.X = mouse.X + (clipRect.Width / 2);
            //        topRight.Y = topLeft.Y;

            //        bottomLeft.X = topLeft.X;
            //        bottomLeft.Y = mouse.Y + (clipRect.Height / 2);

            //        bottomRight.X = topRight.X;
            //        bottomRight.Y = bottomLeft.Y;
            //    }

            //    //Update the clip rectangle
            //    int width = topRight.X - topLeft.X;
            //    int height = bottomLeft.Y - topLeft.Y;
            //    clipRect = new Rectangle(topLeft.X, topLeft.Y, width, height);

            //    //Force redraw
            //    this.Refresh();

            //}


            //PictureEdit edit = sender as PictureEdit;
            //if ((e.Button == MouseButtons.Left ||
            //   (SystemInformation.MouseButtonsSwapped &&
            //    e.Button == MouseButtons.Right)) && edit.Image != null)
            //{
            //    PictureEditViewInfo vi = edit.GetViewInfo() as PictureEditViewInfo;
            //    double zoomX = 1.0, zoomY = 1.0;

            //    if (ZoomPercentChanged && edit.Properties.SizeMode != PictureSizeMode.Squeeze)
            //        zoomX = zoomY = Convert.ToDouble(edit.Properties.ZoomPercent) / 100;
            //    else
            //        switch (edit.Properties.SizeMode)
            //        {
            //            case PictureSizeMode.Zoom:
            //            case PictureSizeMode.Squeeze:
            //                zoomX = zoomY = Convert.ToDouble(vi.PictureScreenBounds.Width / pictureEdit1.Image.Size.Width);
            //                break;
            //            case PictureSizeMode.Stretch:
            //                zoomX = Convert.ToDouble(vi.PictureScreenBounds.Width / pictureEdit1.Image.Size.Width);
            //                zoomY = Convert.ToDouble(vi.PictureScreenBounds.Height / pictureEdit1.Image.Size.Height);
            //                break;
            //            case PictureSizeMode.StretchHorizontal:
            //                zoomX = Convert.ToDouble(vi.PictureScreenBounds.Width / pictureEdit1.Image.Size.Width);
            //                break;
            //            case PictureSizeMode.StretchVertical:
            //                zoomY = zoomY = Convert.ToDouble(vi.PictureScreenBounds.Height / pictureEdit1.Image.Size.Height);
            //                break;
            //        }

            //    int scrollX = (edit.Controls[1] as DevExpress.XtraEditors.HScrollBar).Value;
            //    int scrollY = (edit.Controls[0] as DevExpress.XtraEditors.VScrollBar).Value;

            //    //int scrollX = edit.HScrollBar.Value;
            //    //int scrollY = edit.VScrollBar.Value;

            //    int x, y;
            //    if (edit.Controls[1].Visible == true)
            //        x = (int)((e.X + scrollX - vi.PictureScreenBounds.X) / zoomX);
            //    else
            //        x = (int)((e.X - vi.PictureScreenBounds.X) / zoomX);
            //    if (edit.Controls[0].Visible == true)
            //        y = (int)((e.Y + scrollY - vi.PictureScreenBounds.Y) / zoomY);
            //    else
            //        y = (int)((e.Y - vi.PictureScreenBounds.Y) / zoomY);

            //    //x = (int)((e.X + scrollX - vi.PictureScreenBounds.X) / zoomX);
            //    //y = (int)((e.Y + scrollY - vi.PictureScreenBounds.Y) / zoomY);


            //    if (CheckBounds(x, y))
            //    {
            //        //Graphics.FromImage(edit.Image).DrawRectangle(new Pen(Color.Red), x, y, 20, 20);

            //        clipRect = new RectangleF(x, y, vi.PictureScreenBounds.Width, vi.PictureScreenBounds.Height);
            //        edit.Refresh();
            //    }
            //}
        }

        bool CheckBounds(int x, int y)
        {
            return x >= 0 && x < pictureEdit1.Image.Width && y >= 0 && y < pictureEdit1.Image.Height;
        }

        /// <summary>
        /// Calculate the distance between two points.
        /// </summary>
        private double GetDistance(Point pnt1, Point pnt2)
        {
            int a = pnt2.X - pnt1.X;
            int b = pnt2.Y - pnt1.Y;

            return Math.Sqrt(a * a + b * b);
        }

        private void pictureEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureEdit edit = sender as PictureEdit;
            if ((e.Button == MouseButtons.Left ||
               (SystemInformation.MouseButtonsSwapped &&
                e.Button == MouseButtons.Right)) && edit.Image != null)
            {
                PictureEditViewInfo vi = edit.GetViewInfo() as PictureEditViewInfo;
                double zoomX = 1.0, zoomY = 1.0;

                if (ZoomPercentChanged && edit.Properties.SizeMode != PictureSizeMode.Squeeze)
                    zoomX = zoomY = Convert.ToDouble(edit.Properties.ZoomPercent) / 100;
                else
                    switch (edit.Properties.SizeMode)
                    {
                        case PictureSizeMode.Zoom:
                        case PictureSizeMode.Squeeze:
                            zoomX = zoomY = Convert.ToDouble(vi.PictureScreenBounds.Width / pictureEdit1.Image.Size.Width);
                            break;
                        case PictureSizeMode.Stretch:
                            zoomX = Convert.ToDouble(vi.PictureScreenBounds.Width / pictureEdit1.Image.Size.Width);
                            zoomY = Convert.ToDouble(vi.PictureScreenBounds.Height / pictureEdit1.Image.Size.Height);
                            break;
                        case PictureSizeMode.StretchHorizontal:
                            zoomX = Convert.ToDouble(vi.PictureScreenBounds.Width / pictureEdit1.Image.Size.Width);
                            break;
                        case PictureSizeMode.StretchVertical:
                            zoomY = zoomY = Convert.ToDouble(vi.PictureScreenBounds.Height / pictureEdit1.Image.Size.Height);
                            break;
                    }

                //int scrollX = (edit.Controls[1] as DevExpress.XtraEditors.HScrollBar).Value;
                //int scrollY = (edit.Controls[0] as DevExpress.XtraEditors.VScrollBar).Value;

                int scrollX = edit.HScrollBar.Value;
                int scrollY = edit.VScrollBar.Value;

                int x, y;
                //if (edit.Controls[1].Visible == true)
                //    //x = (int)((e.X + scrollX - vi.PictureScreenBounds.X) / zoomX);
                //    x = (int)((scrollX - vi.PictureScreenBounds.X) / zoomX);
                //else
                //    //x = (int)((e.X - vi.PictureScreenBounds.X) / zoomX);
                //    x = (int)((vi.PictureScreenBounds.X) / zoomX);
                //if (edit.Controls[0].Visible == true)
                //    //y = (int)((e.Y + scrollY - vi.PictureScreenBounds.Y) / zoomY);
                //    y = (int)((scrollY - vi.PictureScreenBounds.Y) / zoomY);
                //else
                //    //y = (int)((e.Y - vi.PictureScreenBounds.Y) / zoomY);
                //    y = (int)((vi.PictureScreenBounds.Y) / zoomY);

                x = (int)((scrollX - vi.PictureScreenBounds.X) / zoomX);
                y = (int)((scrollY - vi.PictureScreenBounds.Y) / zoomY);


                if (CheckBounds(x, y))
                {
                    //Graphics.FromImage(edit.Image).DrawRectangle(new Pen(Color.Red), x, y, 20, 20);

                    clipRect = new RectangleF(x, y, vi.PictureScreenBounds.Width, vi.PictureScreenBounds.Height);
                    edit.Refresh();
                }
            }
        }

        private void pictureEdit1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureEdit edit = sender as PictureEdit;
            if ((e.Button == MouseButtons.Left && edit.Image != null))
            {
                PictureEditViewInfo vi = edit.GetViewInfo() as PictureEditViewInfo;
                double zoomX = 1.0, zoomY = 1.0;

                if (ZoomPercentChanged && edit.Properties.SizeMode != PictureSizeMode.Squeeze)
                    zoomX = zoomY = Convert.ToDouble(edit.Properties.ZoomPercent) / 100;
                else
                    switch (edit.Properties.SizeMode)
                    {
                        case PictureSizeMode.Zoom:
                        case PictureSizeMode.Squeeze:
                            zoomX = zoomY = Convert.ToDouble(vi.PictureScreenBounds.Width / pictureEdit1.Image.Size.Width);
                            break;
                        case PictureSizeMode.Stretch:
                            zoomX = Convert.ToDouble(vi.PictureScreenBounds.Width / pictureEdit1.Image.Size.Width);
                            zoomY = Convert.ToDouble(vi.PictureScreenBounds.Height / pictureEdit1.Image.Size.Height);
                            break;
                        case PictureSizeMode.StretchHorizontal:
                            zoomX = Convert.ToDouble(vi.PictureScreenBounds.Width / pictureEdit1.Image.Size.Width);
                            break;
                        case PictureSizeMode.StretchVertical:
                            zoomY = zoomY = Convert.ToDouble(vi.PictureScreenBounds.Height / pictureEdit1.Image.Size.Height);
                            break;
                    }

                //int scrollX = (edit.Controls[1] as DevExpress.XtraEditors.HScrollBar).Value;
                //int scrollY = (edit.Controls[0] as DevExpress.XtraEditors.VScrollBar).Value;

                int scrollX = edit.HScrollBar.Value;
                int scrollY = edit.VScrollBar.Value;

                int x, y;
                //if (edit.Controls[1].Visible == true)
                //    //x = (int)((e.X + scrollX - vi.PictureScreenBounds.X) / zoomX);
                //    x = (int)((scrollX - vi.PictureScreenBounds.X) / zoomX);
                //else
                //    //x = (int)((e.X - vi.PictureScreenBounds.X) / zoomX);
                //    x = (int)((vi.PictureScreenBounds.X) / zoomX);
                //if (edit.Controls[0].Visible == true)
                //    //y = (int)((e.Y + scrollY - vi.PictureScreenBounds.Y) / zoomY);
                //    y = (int)((scrollY - vi.PictureScreenBounds.Y) / zoomY);
                //else
                //    //y = (int)((e.Y - vi.PictureScreenBounds.Y) / zoomY);
                //    y = (int)((vi.PictureScreenBounds.Y) / zoomY);

                //x = (int)((e.X + scrollX - vi.PictureScreenBounds.X) / zoomX);
                //y = (int)((e.Y + scrollY - vi.PictureScreenBounds.Y) / zoomY);

                x = (int)((scrollX - vi.PictureScreenBounds.X) / zoomX);
                y = (int)((scrollY - vi.PictureScreenBounds.Y) / zoomY);


                if (CheckBounds(x, y))
                {
                    //Graphics.FromImage(edit.Image).DrawRectangle(new Pen(Color.Red), x, y, 20, 20);

                    clipRect = new RectangleF(x, y, vi.PictureScreenBounds.Width, vi.PictureScreenBounds.Height);
                    edit.Refresh();
                }
            }
        }
    }
}
