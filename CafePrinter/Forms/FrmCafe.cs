using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using CafePrintter.Helper;
using CafePrintter.Base;

namespace CafePrintter.Forms
{
    public partial class FrmCafe : FrmChildBase
    {
        public FrmCafe()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureEdit1.Refresh();
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureEdit1.Refresh();
        }

        private void btnRotateHorizontal_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureEdit1.Refresh();
        }

        private void btnRotateVertical_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureEdit1.Refresh();
        }
    }
}