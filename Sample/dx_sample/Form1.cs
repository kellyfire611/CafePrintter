using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.ViewInfo;
using System.IO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace dxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureEdit1.MouseDown += pictureEdit1_MouseDown;
            pictureEdit1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True;
            //pictureEdit1.Properties.ShowScrollBars = true;
           // pictureEdit1.Properties.AllowScrollViaMouseDrag = false;
            pictureEdit1.ZoomPercentChanged += pictureEdit1_ZoomPercentChanged;

            pictureEdit1.EditValue = Image.FromFile(path + @"\1.jpg");

            comboBoxEdit1.Properties.Items.AddRange(new PictureSizeMode[] {PictureSizeMode.Clip,PictureSizeMode.Squeeze, PictureSizeMode.Stretch, PictureSizeMode.StretchHorizontal,PictureSizeMode.StretchVertical,PictureSizeMode.Zoom});
            comboBoxEdit1.EditValueChanged+= comboBoxEdit1_EditValueChanged;
            comboBoxEdit1.SelectedIndex = 0;
        }

        bool ZoomPercentChanged;
        void pictureEdit1_ZoomPercentChanged(object sender, EventArgs e)
        {
            ZoomPercentChanged = true;
        }

        void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit edit = sender as ComboBoxEdit;
            pictureEdit1.Properties.SizeMode = (PictureSizeMode)edit.EditValue;
            ZoomPercentChanged = false;
        }
        bool CheckBounds(int x, int y)
        {
            return x >= 0 && x < pictureEdit1.Image.Width && y >= 0 && y < pictureEdit1.Image.Height;
        }

        void pictureEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureEdit edit = sender as PictureEdit;
            if (e.Button == MouseButtons.Right && edit.Image != null)
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
                //    x = (int)((e.X + scrollX - vi.PictureScreenBounds.X) / zoomX);
                //else
                //    x = (int)((e.X - vi.PictureScreenBounds.X) / zoomX);
                //if (edit.Controls[0].Visible == true)
                //    y = (int)((e.Y + scrollY - vi.PictureScreenBounds.Y) / zoomY);
                //else
                //    y = (int)((e.Y - vi.PictureScreenBounds.Y) / zoomY);

                    x = (int)((e.X + scrollX - vi.PictureScreenBounds.X) / zoomX);
                    y = (int)((e.Y + scrollY - vi.PictureScreenBounds.Y) / zoomY);


                if (CheckBounds(x, y))
                {
                    Graphics.FromImage(edit.Image).DrawRectangle(new Pen(Color.Red), x, y, 20, 20);
                    edit.Refresh();
                }
            }
        }


        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pictureEdit1.EditValue = Image.FromFile(path + @"/1.jpg");
        }
    }
}
