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
using CafePrintter.Model;

namespace CafePrintter.Forms
{
    public partial class FrmSetting : FrmChildBase
    {
        CoreModel context = new CoreModel();
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            var query = from p in context.user
                        select p;
        }
    }
}