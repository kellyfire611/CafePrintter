using CafePrintter.Model.SimpleClass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafePrintter.Global
{
    public class GlobalSetting
    {
        public static List<Form> ChildFormList = new List<Form>();
        public static RootObject Data = null;


        public static string SysDateFormatProvider { get; set; }
        public static string SysDateFormatProviderSeperator { get; set; }
        public static string SysTimeFormatProvider { get; set; }
        public static string SysTimeFormatProviderSeperator { get; set; }

        public static string SysDateTimeFormatProvider { get; set; }
        public static string JsonConfigPath { get; set; }


        static GlobalSetting()
        {
            GlobalSetting.SysDateFormatProvider = ConfigurationManager.AppSettings["SysDateFormatProvider"];
            GlobalSetting.SysDateFormatProviderSeperator = ConfigurationManager.AppSettings["SysDateFormatProviderSeperator"];
            GlobalSetting.SysTimeFormatProvider = ConfigurationManager.AppSettings["SysTimeFormatProvider"];
            GlobalSetting.SysTimeFormatProviderSeperator = ConfigurationManager.AppSettings["SysTimeFormatProviderSeperator"];
            GlobalSetting.SysDateTimeFormatProvider = String.Format("{0} {1}", GlobalSetting.SysDateFormatProvider, GlobalSetting.SysTimeFormatProvider);
            GlobalSetting.JsonConfigPath = Application.StartupPath + ConfigurationManager.AppSettings["JsonConfigPath"];
        }
    }
}
