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
using CafePrintter.Model.SimpleClass;
using CafePrintter.Global;
using CafePrinter.Helper;

namespace CafePrintter.Forms
{
    public partial class FrmSetting : FrmChildBase
    {
        List<Printer> LstPrinters= new List<Printer>();
        public FrmSetting()
        {
            InitializeComponent();

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                LstPrinters.Add(new Printer() { PrinterName = printer });
            }
            luePrinter.Properties.DataSource = LstPrinters;

            // Load data
            GlobalSetting.Data = JsonHelper.GetData();

            if(GlobalSetting.Data != null)
            {
                txtFolderPath.EditValue = GlobalSetting.Data.folder_path;
                luePrinter.EditValue = GlobalSetting.Data.printer_name;
                txtPrinterCounter.EditValue = GlobalSetting.Data.printer_counter;
            }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GlobalSetting.Data != null)
            {
                GlobalSetting.Data.folder_path = Convert.ToString(txtFolderPath.EditValue);
                GlobalSetting.Data.printer_name = Convert.ToString(luePrinter.EditValue);
                GlobalSetting.Data.printer_counter = Convert.ToInt32(txtPrinterCounter.EditValue);
            }

            string jsonData = JsonHelper.DataToJson(GlobalSetting.Data);
            JsonHelper.SaveAndRefresh(jsonData);

            MessageBox.Show("Lưu cấu hình thành công. Chương trình sẽ khởi động lại ngay.");
            Application.Restart();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}