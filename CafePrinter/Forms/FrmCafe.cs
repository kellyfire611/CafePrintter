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
using System.Threading;
using System.Threading.Tasks;

namespace CafePrintter.Forms
{
    public partial class FrmCafe : FrmChildBase
    {
        public FrmCafe()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;
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

        private readonly SynchronizationContext synchronizationContext;
        private DateTime previousTime = DateTime.Now;

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;
            var count = 0;


            await Task.Run(() =>
            {
                for (var i = 0; i <= (5000000 * 50); i++)
                {
                    UpdateUI(i);
                    count = i;
                }
            });

            layoutControlItem1.Text = @"Counter " + count;
            simpleButton1.Enabled = true;
        }

        public void UpdateUI(int value)
        {
            var timeNow = DateTime.Now;
            Thread.Sleep(500);
            if ((DateTime.Now - previousTime).Milliseconds <= 50) return;

            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                layoutControlItem1.Text = @"Counter " + (int)o;
            }), value);

            previousTime = timeNow;
        }
    }
}