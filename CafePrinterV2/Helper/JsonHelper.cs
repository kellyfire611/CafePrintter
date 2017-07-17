using CafePrintter2.Global;
using CafePrintter2.Model.SimpleClass;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafePrinter2.Helper
{
    public class JsonHelper
    {
        public static string JsonDataFilePath;
        public static string JsonLanguageDataFilePath;
        public static List<string> JsonFiles = new List<string>();


        static JsonHelper()
        {
            JsonDataFilePath = Path.Combine(GlobalSetting.JsonConfigPath, "cafeprinter.json");
            JsonLanguageDataFilePath = Path.Combine(Application.StartupPath, "Langs\\vi-vn.json");
        }

        public static RootObject GetData()
        {
            var data = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText(JsonHelper.JsonDataFilePath));
            return data;
        }

        public static string DataToJson(RootObject data)
        {
            string resultJsonData = String.Empty;
            JObject jObject = new JObject();
            var jsonProjects = JsonConvert.SerializeObject(data, Formatting.None,
                new IsoDateTimeConverter() { DateTimeFormat = GlobalSetting.SysDateTimeFormatProvider });
            resultJsonData = jsonProjects.ToString();
            return resultJsonData;
        }

        public static void SaveAndRefresh(string jsonData)
        {
            File.WriteAllText(JsonHelper.JsonDataFilePath, jsonData);
            // Load data
            GlobalSetting.Data = JsonHelper.GetData();
        }
    }
}
