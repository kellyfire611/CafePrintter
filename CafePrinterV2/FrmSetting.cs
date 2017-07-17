using CafePrinter2.Helper;
using CafePrintter2.Global;
using CafePrintter2.Model.SimpleClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafePrinterV2
{
    public partial class FrmSetting : Form
    {
        List<Printer> LstPrinters = new List<Printer>();

        public FrmSetting()
        {
            InitializeComponent();

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                LstPrinters.Add(new Printer() { PrinterName = printer });
            }
            cbbPrinter.DisplayMember = "PrinterName";
            cbbPrinter.ValueMember = "PrinterName";
            cbbPrinter.DataSource = LstPrinters;

            // Load datas
            GlobalSetting.Data = JsonHelper.GetData();

            if (GlobalSetting.Data != null)
            {
                txtFolderPath.Text = GlobalSetting.Data.folder_path;
                cbbPrinter.Text = GlobalSetting.Data.printer_name;
                nudDuongKinh.Value = GlobalSetting.Data.margin_radius;
                nudLeTrai.Value = GlobalSetting.Data.margin_leTrai;
                nudLeTren.Value = GlobalSetting.Data.margin_leTren;
                nudLeTrenVachKe.Value = GlobalSetting.Data.margin_leTrenVachKe;
                nudVachKe.Value = GlobalSetting.Data.margin_vachKe;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GlobalSetting.Data != null)
            {
                GlobalSetting.Data.folder_path = Convert.ToString(txtFolderPath.Text);
                GlobalSetting.Data.printer_name = Convert.ToString(cbbPrinter.Text);
                GlobalSetting.Data.margin_radius = (int)nudDuongKinh.Value;
                GlobalSetting.Data.margin_leTrai = (int)nudLeTrai.Value;
                GlobalSetting.Data.margin_leTren = (int)nudLeTren.Value;
                GlobalSetting.Data.margin_leTrenVachKe = (int)nudLeTrenVachKe.Value;
                GlobalSetting.Data.margin_vachKe = (int)nudVachKe.Value;
            }

            string jsonData = JsonHelper.DataToJson(GlobalSetting.Data);
            JsonHelper.SaveAndRefresh(jsonData);

            MessageBox.Show("Lưu cấu hình thành công.");
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
