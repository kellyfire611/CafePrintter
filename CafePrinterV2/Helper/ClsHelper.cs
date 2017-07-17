using CafePrintter2.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafePrintter2.Helper
{
    public class ClsHelper
    {
        public static Form ShowOrActiveForm(Form mdiParent, Type t)
        {
            mdiParent.SuspendLayout();
            try
            {
                // Tìm trong danh sách
                Form form = (from p in GlobalSetting.ChildFormList
                             where p.GetType() == t
                             select p).FirstOrDefault();

                if (form == null)
                {
                    form = (Form)Activator.CreateInstance(t);
                    GlobalSetting.ChildFormList.Add(form);
                    form.MdiParent = mdiParent;
                    //form.WindowState = FormWindowState.Maximized;
                    form.Dock = DockStyle.Fill;
                    form.Show();
                    //form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    if (form.IsDisposed)
                    {
                        form = (Form)Activator.CreateInstance(t);
                        GlobalSetting.ChildFormList.Add(form);
                        form.MdiParent = mdiParent;
                        //form.WindowState = FormWindowState.Maximized;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                        //form.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        //form.WindowState = FormWindowState.Maximized;
                        form.Activate();
                        form.Dock = DockStyle.Fill;
                        //form.WindowState = FormWindowState.Maximized;
                    }
                }
                return form;
            }
            finally
            {
                mdiParent.ResumeLayout();
            }
        }

        public static void CloseForm(Type t)
        {
            // Tìm trong danh sách
            Form form = (from p in GlobalSetting.ChildFormList
                         where p.GetType() == t
                         select p).FirstOrDefault();

            if (form != null)
            {
                GlobalSetting.ChildFormList.Remove(form);
            }
        }

        //public static void CreateDynamicControl(LayoutControl lc, LayoutControlGroup lcg)
        //{
        //    int count = 0;
        //    int RowWidth = 0;
        //    LayoutControlItem lastItem = null;
        //    lc.BeginUpdate();
        //    foreach (ViewDynamicReportPresenter.Param exParam in lstParams)
        //    {
        //        // Tạo control động
        //        var control = this.CreateItem(exParam.EX_SP_DYN_PARAM_TYPE, exParam.EX_SP_DYN_PARAM_MAXLENGTH,
        //            exParam.EX_SP_SYN_PARAM_CONFIG);
        //        control.Name = exParam.EX_SP_DYN_PARAM_NAME + count.ToString();
        //        control.EnterMoveNextControl = true;
        //        if (control is LookUpEditBase)
        //        {
        //            ((LookUpEditBase)control).BestFitResizePopup();
        //        }

        //        // Tạo layoutControlItem động
        //        LayoutControlItem item = new LayoutControlItem();
        //        if (lastItem == null || lastItem != null && (layoutControl.Width - 100) < RowWidth)
        //        {
        //            this.lc.AddItem(item);
        //            item.Move(lciGridviewParam, InsertType.Top);
        //            RowWidth = item.MinSize.Width;
        //        }
        //        else
        //        {
        //            lcg.AddItem(item, lastItem, InsertType.Right);
        //        }
        //        item.Text = exParam.EX_SP_DYN_PARAM_DESC;
        //        item.Control = control;
        //        RowWidth += item.MinSize.Width;
        //        lastItem = item;
        //        item.Name = "lci" + exParam.EX_SP_DYN_PARAM_NAME + count.ToString();

        //        // Add item
        //        _lstItem.Add(control, exParam);

        //        // Đăng ký sự kiện để lưu lại các giá trị của tham số
        //        control.EditValueChanged += (sender, e) =>
        //        {
        //            var ctl = sender as BaseEdit;
        //            _lstItem[ctl].Value = ctl.EditValue;
        //        };

        //        // Hiệu chỉnh giao diện theo thuộc tính của tham số
        //        if (exParam.EX_SP_DYN_PARAM_REQUIRED)
        //        {
        //            item.AppearanceItemCaption.Font = new Font(item.AppearanceItemCaption.Font, FontStyle.Bold);
        //            item.AppearanceItemCaption.ForeColor = Color.Red;
        //        }
        //        control.Enabled = !exParam.EX_SP_SYN_PARAM_READONLY;

        //        // Gán giá trị mặc định của tham số
        //        control.EditValue = this.ParseDefaultValue(exParam.EX_SP_DYN_PARAM_TYPE,
        //            exParam.EX_SP_SYN_PARAM_DEFAULT_VALUE,
        //            exParam.EX_SP_SYN_PARAM_CONFIG);
        //    }
        //    lc.BestFit();
        //    lc.EndUpdate();
        //}

        //public BaseEdit CreateItem(string EX_SP_DYN_PARAM_TYPE, int EX_SP_DYN_PARAM_MAXLENGTH,
        //   string EX_SP_SYN_PARAM_CONFIG = "")
        //{
        //    BaseEdit item = null;
        //    if (EX_SP_DYN_PARAM_TYPE == typeof(int).FullName
        //            || EX_SP_DYN_PARAM_TYPE == typeof(long).FullName
        //            || EX_SP_DYN_PARAM_TYPE == typeof(decimal).FullName)
        //    {
        //        var tmp = new SpinEdit();
        //        if (EX_SP_DYN_PARAM_MAXLENGTH > 0)
        //        {
        //            tmp.Properties.MaxLength = EX_SP_DYN_PARAM_MAXLENGTH;
        //        }
        //        item = tmp;
        //    }
        //    else if (EX_SP_DYN_PARAM_TYPE == typeof(string).FullName)
        //    {
        //        var tmp = new TextEdit();
        //        if (EX_SP_DYN_PARAM_MAXLENGTH > 0)
        //        {
        //            tmp.Properties.MaxLength = EX_SP_DYN_PARAM_MAXLENGTH;
        //        }
        //        item = tmp;
        //    }
        //    else if (EX_SP_DYN_PARAM_TYPE == typeof(DateTime).FullName)
        //    {
        //        var tmp = new DateEdit();
        //        if (EX_SP_DYN_PARAM_MAXLENGTH > 0)
        //        {
        //            tmp.Properties.MaxLength = EX_SP_DYN_PARAM_MAXLENGTH;
        //        }
        //        tmp.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
        //        tmp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
        //        tmp.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
        //        tmp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
        //        tmp.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
        //        tmp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
        //        item = tmp;
        //    }
        //    else if (EX_SP_DYN_PARAM_TYPE == typeof(bool).FullName)
        //    {
        //        var tmp = new CheckEdit();
        //        item = tmp;
        //    }
        //    else if (EX_SP_DYN_PARAM_TYPE == "List")
        //    {
        //        try
        //        {
        //            var tmp = this.CreateSearchLookupEdit(EX_SP_SYN_PARAM_CONFIG);
        //            item = tmp;
        //        }
        //        catch
        //        {
        //            Utilities.MsgBoxInfo("Vui lòng kiểm tra lại cấu hình các tham số kiểu Danh sách.");
        //            item = null;
        //        }
        //    }

        //    return item;
        //}
    }
}
