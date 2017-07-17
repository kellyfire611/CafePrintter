using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CafePrinterV2.Properties;
using Cyotek.Windows.Forms;
using CafePrintter2.Global;
using CafePrinter2.Helper;
using System.Drawing.Printing;
using CafePrinterV2.Report;
using DevExpress.XtraReports.UI;

namespace CafePrinterV2
{
    // Cyotek ImageBox
    // Copyright (c) 2010-2017 Cyotek Ltd.
    // http://cyotek.com
    // http://cyotek.com/blog/tag/imagebox

    // Licensed under the MIT License. See license.txt for the full text.

    // If you use this control in your applications, attribution, donations or contributions are welcome.

    internal partial class GeneralDemoForm : BaseForm
    {
        #region Fields

        private RectangleF clipRect_Ori = new RectangleF(0, 0, 0, 0);
        private Image _previewImage;
        private PointF _gocToaDo = new PointF(0, 0);

        #endregion

        #region Constructors

        public GeneralDemoForm()
        {
            this.InitializeComponent();

            // Load data
            GlobalSetting.Data = JsonHelper.GetData();

            if (GlobalSetting.Data != null)
            {
                btnPrint.Text = String.Format("{0}({1})", "In", GlobalSetting.Data.printer_counter);
                //lblCounter.Text = String.Format("{0} ({1})", "Đã in", GlobalSetting.Data.printer_counter);
                //currentPath = GlobalSetting.Data.folder_path;
            }
        }

        #endregion

        #region Methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.FillZoomLevels();
            this.OpenImage(Resources.Sample);

            imageBox.SelectionMode = ImageBoxSelectionMode.None;
            imageBox.AllowClickZoom = false;
            clipRect_Ori = imageBox.DisplayRectangle;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void actualSizeToolStripButton_Click(object sender, EventArgs e)
        {
            imageBox.ActualSize();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetImage(imageBox.GetSelectedImage() ?? imageBox.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawBox(Graphics graphics, Color color, RectangleF rectangle, double scale)
        {
            float penWidth;

            penWidth = 2 * (float)scale;

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(64, color)))
            {
                graphics.FillRectangle(brush, rectangle);
            }

            using (Pen pen = new Pen(color, penWidth)
            {
                DashStyle = DashStyle.Dot,
                DashCap = DashCap.Round
            })
            {
                graphics.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillZoomLevels()
        {
            zoomLevelsToolStripComboBox.Items.Clear();

            foreach (int zoom in imageBox.ZoomLevels)
            {
                zoomLevelsToolStripComboBox.Items.Add(string.Format("{0}%", zoom));
            }
        }

        private void fromURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenUrlDialog dialog = new OpenUrlDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.OpenImageFromUrl(dialog.Url);
                }
            }
        }

        private void imageBox_MouseLeave(object sender, EventArgs e)
        {
            cursorToolStripStatusLabel.Text = string.Empty;
        }

        private void imageBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.UpdateCursorPosition(e.Location);
        }

        private void imageBox_Paint(object sender, PaintEventArgs e)
        {
            // highlight the image
            if (showImageRegionToolStripButton.Checked)
            {
                this.DrawBox(e.Graphics, Color.CornflowerBlue, imageBox.GetImageViewPort(), 1);
            }

            // show the region that will be drawn from the source image
            if (showSourceImageRegionToolStripButton.Checked)
            {
                this.DrawBox(e.Graphics, Color.Firebrick, new RectangleF(imageBox.GetImageViewPort().Location, imageBox.GetSourceImageRegion().Size), 1);
            }

            //this.DrawBox(e.Graphics, Color.Red, imageBox.GetImageViewPort(), 1);


            var radius = imageBox.Width / 2;
            var center = new Point(imageBox.Width / 2, imageBox.Height / 2);
            var path = new GraphicsPath();
            //path.AddEllipse(new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2));
            path.AddEllipse(clipRect_Ori);
            e.Graphics.DrawPath(Pens.Red, path);
        }

        private void imageBox_Resize(object sender, EventArgs e)
        {
            this.UpdateStatusBar();
        }

        private void imageBox_Scroll(object sender, ScrollEventArgs e)
        {
            if(e.Type == ScrollEventType.EndScroll && e.OldValue > 0)
            {
                var scrollValue = (e.NewValue - e.OldValue);
                switch (e.ScrollOrientation)
                {
                    case ScrollOrientation.HorizontalScroll:
                        _gocToaDo.X = _gocToaDo.X + scrollValue;
                        break;
                    case ScrollOrientation.VerticalScroll:
                        _gocToaDo.Y = _gocToaDo.Y + scrollValue;
                        break;
                    default:
                        break;
                }
            }



            this.UpdateStatusBar();
        }

        private void imageBox_Selected(object sender, EventArgs e)
        {
            this.UpdatePreviewImage();
        }

        private void imageBox_SelectionRegionChanged(object sender, EventArgs e)
        {
            selectionToolStripStatusLabel.Text = this.FormatRectangle(imageBox.SelectionRegion);
        }

        private void imageBox_ZoomChanged(object sender, EventArgs e)
        {
            this.UpdateStatusBar();
        }

        private void imageBox_ZoomLevelsChanged(object sender, EventArgs e)
        {
            this.FillZoomLevels();
        }

        private void openFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "All Supported Images (*.bmp;*.dib;*.rle;*.gif;*.jpg;*.png)|*.bmp;*.dib;*.rle;*.gif;*.jpg;*.png|Bitmaps (*.bmp;*.dib;*.rle)|*.bmp;*.dib;*.rle|Graphics Interchange Format (*.gif)|*.gif|Joint Photographic Experts (*.jpg)|*.jpg|Portable Network Graphics (*.png)|*.png|All Files (*.*)|*.*";
                dialog.DefaultExt = "png";

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        this.OpenImage(Image.FromFile(dialog.FileName));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void OpenImage(Image image)
        {
            imageBox.Image = image;
            //imageBox.ZoomToFit();

            this.UpdateStatusBar();
            this.UpdatePreviewImage();
        }

        private void OpenImageFromUrl(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] data;

                    data = client.DownloadData(url);

                    using (Stream stream = new MemoryStream(data))
                    {
                        this.OpenImage(Image.FromStream(stream));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox.SelectAll();
        }

        private void selectNoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox.SelectNone();
        }

        private void showImageRegionToolStripButton_Click(object sender, EventArgs e)
        {
            imageBox.Invalidate();
        }

        private void UpdateCursorPosition(Point location)
        {
            if (!fitCursorLocationToBoundsToolStripMenuItem.Checked || imageBox.IsPointInImage(location))
            {
                Point point;

                point = imageBox.PointToImage(location);

                cursorToolStripStatusLabel.Text = this.FormatPoint(point);
            }
            else
            {
                cursorToolStripStatusLabel.Text = string.Empty;
            }
        }

        private void UpdatePreviewImage()
        {
            if (_previewImage != null)
            {
                _previewImage.Dispose();
            }

            _previewImage = imageBox.GetSelectedImage();

            previewImageBox.Image = _previewImage;
        }

        private void UpdateStatusBar()
        {
            zoomLevelsToolStripComboBox.Text = string.Format("{0}%", imageBox.Zoom);
            autoScrollPositionToolStripStatusLabel.Text = this.FormatPoint(imageBox.AutoScrollPosition);
            imageSizeToolStripStatusLabel.Text = this.FormatRectangle(imageBox.GetImageViewPort());
            zoomToolStripStatusLabel.Text = string.Format("{0}%", imageBox.Zoom);
        }

        private void zoomInToolStripButton_Click(object sender, EventArgs e)
        {
            imageBox.ZoomIn();
        }

        private void zoomLevelsToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int zoom;

            zoom = Convert.ToInt32(zoomLevelsToolStripComboBox.Text.Substring(0, zoomLevelsToolStripComboBox.Text.Length - 1));

            imageBox.Zoom = zoom;
        }

        private void zoomOutToolStripButton_Click(object sender, EventArgs e)
        {
            imageBox.ZoomOut();
        }

        #endregion

        private void CropToolStripButton_Click(object sender, EventArgs e)
        {
            CropImage();
        }

        private void CropImage()
        {
            if (_previewImage != null)
            {
                _previewImage.Dispose();
            }

            int scrollX = imageBox.HorizontalScroll.Value;
            int scrollY = imageBox.VerticalScroll.Value;

            double zoomX = imageBox.Zoom;
            double zoomY = imageBox.Zoom;

            int x = (int)((scrollX) / (zoomX / 100));
            int y = (int)((scrollY) / (zoomY / 100));

            _gocToaDo = new PointF(x, y);

            var wfactor = (double)imageBox.Image.Width / imageBox.ClientSize.Width;
            var hfactor = (double)imageBox.Image.Height / imageBox.ClientSize.Height;

            var resizeFactor = Math.Max(wfactor, hfactor);
            var imageSize = new Size((int)(imageBox.Image.Width / resizeFactor), (int)(imageBox.Image.Height / resizeFactor));


            var rect = new RectangleF(_gocToaDo, new SizeF((float)(imageBox.ClientRectangle.Width / (zoomX / 100))
                , (float)(imageBox.ClientRectangle.Height / (zoomX / 100))));


            //_previewImage = new Bitmap(imageBox.Image.Width, imageBox.Image.Height, imageBox.Image.PixelFormat);
            //Bitmap tempImage = new Bitmap(imageBox.Image); 
            Bitmap tempImage = null;
            try
            {
                // create Image Object using rear image byte[]
                Image imag = imageBox.Image;
                // Derive BitMap object using Image instance, so that you can avoid the issue
                //"a graphics object cannot be created from an image that has an indexed pixel format"
                tempImage = new Bitmap(new Bitmap(imag));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //Bitmap tempBitmap = new Bitmap(tempImage.Width, tempImage.Height, imageBox.Image.PixelFormat);

            Graphics g = Graphics.FromImage(tempImage);
            using (Brush br = new SolidBrush(Color.Plum))
            {
               g.FillRectangle(br, 0, 0, tempImage.Width, tempImage.Height);
            }
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            //path.AddRectangle(rect);
            g.SetClip(path);
            //g.DrawPath(Pens.Red, path);
            g.DrawImage(imageBox.Image, 0, 0, imageBox.Image.Width, imageBox.Image.Height);
            tempImage.MakeTransparent(Color.Plum);

            //Image img = new Bitmap(dstImage);
            //img = ClipImage(dstImage, clipRect);
            //return img;

         

            var clippedImage = ClipImage(tempImage, rect);
            previewImageBox.Image = clippedImage;
            previewImageBox.Zoom = imageBox.Zoom;
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

        private Size GetDisplayedImageSize(ImageBox pictureBox)
        {
            Size containerSize = pictureBox.ClientSize;
            float containerAspectRatio = (float)containerSize.Height / (float)containerSize.Width;
            Size originalImageSize = pictureBox.Image.Size;
            float imageAspectRatio = (float)originalImageSize.Height / (float)originalImageSize.Width;

            Size result = new Size();
            if (containerAspectRatio > imageAspectRatio)
            {
                result.Width = containerSize.Width;
                result.Height = (int)(imageAspectRatio * (float)containerSize.Width);
            }
            else
            {
                result.Height = containerSize.Height;
                result.Width = (int)((1.0f / imageAspectRatio) * (float)containerSize.Height);
            }
            return result;
        }

        private void imageBox_Zoomed(object sender, ImageBoxZoomEventArgs e)
        {
        }

        private void RotateLeftToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            RotateLeft();
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            RotateRight();
        }

        private void btnRotateHorizontal_Click(object sender, EventArgs e)
        {
            RotateHorizontal();
        }

        private void btnRotateVertical_Click(object sender, EventArgs e)
        {
            RotateVertical();
        }

        private void RotateLeft()
        {
            imageBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            imageBox.Refresh();
        }

        private void RotateRight()
        {
            imageBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            imageBox.Refresh();
        }

        private void RotateHorizontal()
        {
            imageBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            imageBox.Refresh();
        }

        private void RotateVertical()
        {
            imageBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            imageBox.Refresh();
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            CropImage();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (GlobalSetting.Data != null)
            {
                Print(GlobalSetting.Data.printer_name);

                // Cập nhật giao diện
                if (GlobalSetting.Data != null)
                {
                    GlobalSetting.Data.printer_counter++;
                }

                string jsonData = JsonHelper.DataToJson(GlobalSetting.Data);
                JsonHelper.SaveAndRefresh(jsonData);

                btnPrint.Text = String.Format("{0}({1})", "In ảnh", GlobalSetting.Data.printer_counter);
                //lblCounter.Text = String.Format("{0} ({1})", "Đã in", GlobalSetting.Data.printer_counter);
            }
            else
            {
                MessageBox.Show("Vui lòng cấu hình máy in, định dạng in.");
            }
        }

        public void Print(string printerName)
        {
            if (GlobalSetting.Data == null)
            {
                MessageBox.Show("Không tìm thấy cấu hình, định dạng trang in.");
                return;
            }

            var duongKinh = GlobalSetting.Data.margin_radius * 10;
            var leTren = GlobalSetting.Data.margin_leTren * 10;
            var leTrenVachKe = GlobalSetting.Data.margin_leTrenVachKe * 10;
            var leTrai = GlobalSetting.Data.margin_leTrai * 10;
            var vachKe = GlobalSetting.Data.margin_vachKe * 10;
            var vachKeChieuRong = 1 * 10;
            var leTraiVachKe = 2 * 10;

            XRptPrintA4 rpt = new XRptPrintA4();
            rpt.Detail.HeightF = leTren + duongKinh + 10;
            rpt.xrPictureBox1.Image = previewImageBox.Image;
            rpt.xrPictureBox1.SizeF = new SizeF(duongKinh, duongKinh);
            rpt.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat((leTrai - (duongKinh / 2)), (leTren - (duongKinh / 2)));
            rpt.xrLine1.SizeF = new SizeF(vachKeChieuRong, vachKe);
            rpt.xrLine1.LocationF = new PointF(leTraiVachKe, leTrenVachKe + (5 * 10));

            rpt.PrinterName = printerName;
            rpt.Print();

            //try
            //{
            //    var tempFile = Path.GetTempFileName();
            //    previewImageBox.Image.Save(tempFile);
            //    if (string.IsNullOrWhiteSpace(tempFile)) return; // Prevents execution of below statements if filename is not selected.

            //    PrintDocument pd = new PrintDocument();

            //    //Disable the printing document pop-up dialog shown during printing.
            //    PrintController printController = new StandardPrintController();
            //    pd.PrintController = printController;

            //    //For testing only: Hardcoded set paper size to particular paper.
            //    //pd.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Custom 6x4", 720, 478);
            //    //pd.DefaultPageSettings.PaperSize = new PaperSize("Custom 6x4", 720, 478);

            //    pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            //    pd.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            //    pd.PrintPage += (sndr, args) =>
            //    {
            //        System.Drawing.Image i = System.Drawing.Image.FromFile(tempFile);

            //        //Adjust the size of the image to the page to print the full image without loosing any part of the image.
            //        System.Drawing.Rectangle m = args.MarginBounds;

            //        //Logic below maintains Aspect Ratio.
            //        if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) // image is wider
            //        {
            //            m.Height = (int)((double)i.Height / (double)i.Width * (double)m.Width);
            //        }
            //        else
            //        {
            //            m.Width = (int)((double)i.Width / (double)i.Height * (double)m.Height);
            //        }
            //        //Calculating optimal orientation.
            //        pd.DefaultPageSettings.Landscape = m.Width > m.Height;
            //        //Putting image in center of page.
            //        m.Y = (int)((((System.Drawing.Printing.PrintDocument)(sndr)).DefaultPageSettings.PaperSize.Height - m.Height) / 2);
            //        m.X = (int)((((System.Drawing.Printing.PrintDocument)(sndr)).DefaultPageSettings.PaperSize.Width - m.Width) / 2);
            //        args.Graphics.DrawImage(i, m);
            //    };
            //    pd.Print();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //}
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSetting frm = new FrmSetting();
            frm.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(GlobalSetting.Data == null)
            {
                MessageBox.Show("Không tìm thấy cấu hình, định dạng trang in.");
                return;
            }

            var duongKinh = GlobalSetting.Data.margin_radius * 10;
            var leTren = GlobalSetting.Data.margin_leTren * 10;
            var leTrenVachKe = GlobalSetting.Data.margin_leTrenVachKe * 10;
            var leTrai = GlobalSetting.Data.margin_leTrai * 10;
            var vachKe = GlobalSetting.Data.margin_vachKe * 10;
            var vachKeChieuRong = 1 * 10;
            var leTraiVachKe = 2 * 10;

            XRptPrintA4 rpt = new XRptPrintA4();
            rpt.Detail.HeightF = leTren + duongKinh + 10;
            rpt.xrPictureBox1.Image = previewImageBox.Image;
            rpt.xrPictureBox1.SizeF = new SizeF(duongKinh, duongKinh);
            rpt.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat((leTrai - (duongKinh / 2)), (leTren - (duongKinh / 2)));
            rpt.xrLine1.SizeF = new SizeF(vachKeChieuRong, vachKe);
            rpt.xrLine1.LocationF = new PointF(leTraiVachKe, leTrenVachKe + (5 * 10));

            rpt.PrinterName = GlobalSetting.Data.printer_name;
            rpt.ShowPreviewDialog();
        }
    }
}
