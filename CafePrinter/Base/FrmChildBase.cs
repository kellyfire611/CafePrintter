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

namespace CafePrintter.Base
{
    public partial class FrmChildBase : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmChildBase()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            ClsHelper.CloseForm(this.GetType());
            base.OnClosed(e);
        }
    }
}