using CuscLibrary.CuscBizDataService;
using CuscLibrary.Net;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuscLibrary.License
{
    class LicenseManager
    {
        public static bool HasRegistered = false;
        public static CuscBizDataService.License LicenseInfo;

        private static Entities context;

        static LicenseManager()
        {
            context = new Entities(new Uri("http://172.16.160.131:8899/CuscBizService/CuscBizDataService.svc/"));
        }

        public static void CheckLicense()
        {
            if(LicenseManager.HasRegistered)
            {
                return;
            }

            bool isValid = false;
            string localIP = NetworkUtilities.GetLocalIPv4();

            // Dùng để kiểm tra khi đã build bằng ClickOnce cho khách hàng
            // LicenseType : customer
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                var queryLicense = (from p in LicenseManager.context.License
                                    where p.LicenseUsername == "dnpcuong"
                                    select p).FirstOrDefault();
                if (queryLicense == null)
                {
                    isValid = false;
                }
                else
                {
                    LicenseManager.LicenseInfo = queryLicense;
                    string key = String.Empty;
                    key = String.Format("{0}_{1}_{2}", LicenseManager.LicenseInfo.LicenseUsername,
                         LicenseManager.LicenseInfo.LicenseKeyFrom, LicenseManager.LicenseInfo.LicenseKeyTo);

                    if (key == LicenseManager.LicenseInfo.LicenseKey)
                    {
                        isValid = true;
                        LicenseManager.HasRegistered = true;
                    }
                }
            }
            // Dùng để kiểm tra khi chạy debug phát triển phần mềm
            // LicenseType : developer
            else
            {
                var queryLicense = (from p in LicenseManager.context.License
                                    where p.LicenseKeyIPv4 == localIP
                                    select p).FirstOrDefault();
                if (queryLicense == null)
                {
                    isValid = false;
                }
                else
                {
                    LicenseManager.LicenseInfo = queryLicense;
                    string key = String.Empty;
                    key = String.Format("{0}_{1:yyyyMMdd}_{2:yyyyMMdd}", LicenseManager.LicenseInfo.LicenseUsername,
                         LicenseManager.LicenseInfo.LicenseKeyFrom, LicenseManager.LicenseInfo.LicenseKeyTo);

                    if (key == LicenseManager.LicenseInfo.LicenseKey)
                    {
                        isValid = true;
                        LicenseManager.HasRegistered = true;
                    }
                }
            }
                

            if (isValid)
            {
                LicenseManager.HasRegistered = true;
            }
            else
            {
                MessageBox.Show("Dont' license, please register :( ../..");
                //Environment.Exit(1);
            }
        }
    }
}
