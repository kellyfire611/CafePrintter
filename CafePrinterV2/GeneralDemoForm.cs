using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CafePrinterV2.Properties;
using Cyotek.Windows.Forms;

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
            if (_previewImage != null)
            {
                _previewImage.Dispose();
            }

            //_previewImage = 
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

            _previewImage = new Bitmap(imageBox.Image.Width, imageBox.Image.Height, imageBox.Image.PixelFormat);
            Graphics g = Graphics.FromImage(_previewImage);
            using (Brush br = new SolidBrush(Color.Plum))
            {
                //g.FillRectangle(br, 0, 0, _previewImage.Width, _previewImage.Height);
            }
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            g.SetClip(path);
            g.DrawImage(imageBox.Image, 0, 0);
            //_previewImage.MakeTransparent(Color.Plum);

            //Image img = new Bitmap(dstImage);
            //img = ClipImage(dstImage, clipRect);
            //return img;

            var a = GetDisplayedImageSize(imageBox);

            
            

            
            Graphics g2 = Graphics.FromImage(imageBox.Image);
            using (Brush br = new SolidBrush(Color.Red))
            {
                //g2.FillRectangle(br, _gocToaDo.X, _gocToaDo.Y, 20, 20);
            }

            var clippedImage = ClipImage(_previewImage, rect);

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
    }
}
