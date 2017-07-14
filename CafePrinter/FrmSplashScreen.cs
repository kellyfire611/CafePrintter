using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Deployment.Application;
using System.Linq;
using CafePrintter.Model;

namespace CafePrintter
{
    public partial class FrmSplashScreen : SplashScreen
    {
        //private CoreModel context = new CoreModel();

        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            //var q = context.sys_user.FirstOrDefault();

            //// Lấy version hiện tại lúc build
            //Version currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            //// Kiểm tra version khi build bằng ClickOnce
            //if (ApplicationDeployment.IsNetworkDeployed)
            //{
            //    currentVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            //}
            //lblVersion.Text += string.Format("{0}.{1}.{2}.{3}",
            //    currentVersion.Major, currentVersion.Minor,
            //    currentVersion.Build, currentVersion.Revision);
        }
    }
}