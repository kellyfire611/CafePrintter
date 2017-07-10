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

namespace CafePrintter.Forms
{
    public partial class ExplorerView : FrmChildBase, IFileSystemNavigationSupports
    {
        string currentPath;
        public ExplorerView() {
            InitializeComponent();

            // Load data
            GlobalSetting.Data = JsonHelper.GetData();

            if (GlobalSetting.Data != null)
            {
                btnPrint.Text = String.Format("{0}({1})", "In", GlobalSetting.Data.printer_counter);
            }

            Dictionary<int, string> sizemodeEnums = Enum.GetValues(typeof(DevExpress.XtraEditors.Controls.PictureSizeMode))
                .Cast<DevExpress.XtraEditors.Controls.PictureSizeMode>().ToDictionary(x => (int)x, x => x.ToString());

            lueSizeMode.Properties.ValueMember = "Key";
            lueSizeMode.Properties.DisplayMember = " Value";
            lueSizeMode.Properties.DataSource = sizemodeEnums;
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
            this.currentPath = StartupPath;
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
            pictureEdit1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureEdit1.Refresh();
        }

        private void btnXoayPhai_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureEdit1.Refresh();
        }

        private void btnXoayNgang_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureEdit1.Refresh();
        }

        private void btnXoayDoc_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureEdit1.Refresh();
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
                pictureEdit1.Image.Save(tempFile);
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
            Image srcImage = pictureEdit1.Image;
            Image dstImage = CropToCircle(srcImage, Color.CadetBlue);
            //dstImage.Save(@"080cropped.jpg", ImageFormat.Jpeg);
            pictureEdit1.Image = dstImage;
            pictureEdit1.Refresh();

            
        }

        public Image CropToCircle(Image srcImage, Color backGround)
        {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            Graphics g = Graphics.FromImage(dstImage);
            using (Brush br = new SolidBrush(backGround))
            {
                g.FillRectangle(br, 0, 0, pictureEdit1.Width, pictureEdit1.Height);
            }
            GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(0, 0, dstImage.Width, dstImage.Height);
            //path.AddEllipse(0, 0, pictureEdit1.Width, pictureEdit1.Height);
            float radius = dstImage.Width / 2;
            Point center = new Point(dstImage.Width / 2, dstImage.Height / 2);
            path.AddEllipse(new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2));
            //g.DrawPath(path);

            g.SetClip(path);
            g.DrawImage(srcImage, 0, 0);

            return dstImage;
        }

        private void lueSizeMode_EditValueChanged(object sender, EventArgs e)
        {
            pictureEdit1.Properties.SizeMode = (DevExpress.XtraEditors.Controls.PictureSizeMode)(lueSizeMode.EditValue);
        }
        #endregion
        //#region ReportGeneration
        //public override bool AllowGenerateReport { get { return false; } }
        //#endregion
    }
}
