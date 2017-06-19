//====================================================
//| Downloaded From                                  |
//| Visual C# Kicks - http://www.vcskicks.com/       |
//| License - http://www.vcskicks.com/license.html   |
//====================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace ImageClip
{
    public partial class Form1 : Form
    {
        private Image loadedImage;
        private Rectangle clipRect = new Rectangle(0, 0, 80, 80);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(dialog.FileName);

                    //Clean up previous images
                    if (loadedImage != null)
                        loadedImage.Dispose();

                    loadedImage = img;
                    picOriginal.Image = loadedImage;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Image File");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (picClip.Image != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!dialog.FileName.EndsWith(".bmp"))
                        dialog.FileName += ".bmp";

                    picClip.Image.Save(dialog.FileName);
                }
            }
        }

        private void btnClip_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
                picClip.Image = ClipImage(loadedImage, clipRect);
        }

        /// <summary>
        /// Returns a clipped area of an image.
        /// </summary>
        private Image ClipImage(Image originalImg, Rectangle clipRectangle)
        {
            Bitmap clippedBmp = new Bitmap(clipRectangle.Width, clipRectangle.Height);

            using (Graphics g = Graphics.FromImage(clippedBmp))
            {
                g.DrawImage(originalImg,
                            new Rectangle(0, 0, clipRectangle.Width, clipRectangle.Height),
                            clipRectangle,
                            GraphicsUnit.Pixel);
            }

            return (Image)clippedBmp;
        }

        private void picOriginal_MouseMove(object sender, MouseEventArgs e)
        {
            //Handles the click-dragging logic for the clipping rectangle visual
            if (e.Button == MouseButtons.Left ||
               (SystemInformation.MouseButtonsSwapped &&
                e.Button == MouseButtons.Right))
            {
                Point topLeft = new Point(clipRect.Left, clipRect.Top);
                Point topRight = new Point(clipRect.Right, clipRect.Top);
                Point bottomLeft = new Point(clipRect.Left, clipRect.Bottom);
                Point bottomRight = new Point(clipRect.Right, clipRect.Bottom);

                Point mouse = new Point(e.X, e.Y);

                int threshold = 15;

                //Act on the closest point to the cursor
                if (GetDistance(mouse, topLeft) <= threshold)
                {
                    topLeft = mouse;
                    bottomLeft.X = topLeft.X;
                    topRight.Y = topLeft.Y;
                }
                else if (GetDistance(mouse, topRight) <= threshold)
                {
                    topRight = mouse;
                    bottomRight.X = topRight.X;
                    topLeft.Y = topRight.Y;
                }
                else if (GetDistance(mouse, bottomLeft) <= threshold)
                {
                    bottomLeft = mouse;
                    topLeft.X = bottomLeft.X;
                    bottomRight.Y = bottomLeft.Y;
                }
                else if (GetDistance(mouse, bottomRight) <= threshold)
                {
                    bottomRight = mouse;
                    topRight.X = bottomRight.X;
                    bottomLeft.Y = bottomRight.Y;
                }
                else if (clipRect.Contains(mouse))
                {
                    topLeft.X = mouse.X - (clipRect.Width / 2);
                    topLeft.Y = mouse.Y - (clipRect.Height / 2);

                    topRight.X = mouse.X + (clipRect.Width / 2);
                    topRight.Y = topLeft.Y;

                    bottomLeft.X = topLeft.X;
                    bottomLeft.Y = mouse.Y + (clipRect.Height / 2);

                    bottomRight.X = topRight.X;
                    bottomRight.Y = bottomLeft.Y;
                }

                //Update the clip rectangle
                int width = topRight.X - topLeft.X;
                int height = bottomLeft.Y - topLeft.Y;
                clipRect = new Rectangle(topLeft.X, topLeft.Y, width, height);

                //Force redraw
                this.Refresh();
            }
        }

        private void picOriginal_Paint(object sender, PaintEventArgs e)
        {
            //Clip Rectangle
            e.Graphics.DrawRectangle(Pens.Lime, clipRect);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vcskicks.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
                picClip.Image = ClipToCircle(loadedImage, new PointF(1, 1), 0.5f);
        }

        public Image ClipToCircle(Image original, PointF center, float radius)
        {
            Bitmap copy = new Bitmap(original);
            using (Graphics g = Graphics.FromImage(copy))
            {
                RectangleF r = new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2);
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(r);
                g.Clip = new Region(path);
                g.DrawImage(original, 0, 0);
                return (Image)copy;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image srcImage = Bitmap.FromFile(@"D:\GiaoDienThamKhaoDevExpress.png");
            Image dstImage = CropToCircle(srcImage, Color.CadetBlue);
            dstImage.Save(@"D:\GiaoDienThamKhaoDevExpress_clipped.png", ImageFormat.Jpeg);
        }

        public static Image CropToCircle(Image srcImage, Color backGround)
        {
            /*
             *  Bitmap clippedBmp = new Bitmap(clipRectangle.Width, clipRectangle.Height);

            using (Graphics g = Graphics.FromImage(clippedBmp))
            {
                g.DrawImage(originalImg,
                            new Rectangle(0, 0, clipRectangle.Width, clipRectangle.Height),
                            clipRectangle,
                            GraphicsUnit.Pixel);
            }

            return (Image)clippedBmp;
            */

            /*
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            Graphics g = Graphics.FromImage(dstImage);
            //using (Brush br = new SolidBrush(backGround))
            //{
            //    g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
            //}
            GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(0, 0, dstImage.Width, dstImage.Height);
            float radius = 200;
            PointF center = new PointF(dstImage.Width / 2, dstImage.Height / 2);
            RectangleF r = new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2);
            path.AddEllipse(r);
            g.SetClip(path);
            g.DrawImage(srcImage, 0, 0);

            return dstImage;
            */

            // 1. Tạo 1 đường vẽ hình tròn
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);

            GraphicsPath path = new GraphicsPath();
            float radius = 200;
            PointF center = new PointF(dstImage.Width / 2, dstImage.Height / 2);
            RectangleF r = new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2);
            path.AddEllipse(r);

            // 2. Copy ảnh đích vào
            using (Graphics g = Graphics.FromImage(dstImage))
            {
                g.DrawImage(srcImage,
                            new Rectangle(0, 0, dstImage.Width, dstImage.Height),
                            new Rectangle(0, 0, dstImage.Width, dstImage.Height),
                            GraphicsUnit.Pixel);
            }

            return (Image)dstImage;
        }
    }
}