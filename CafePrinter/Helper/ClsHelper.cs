using CafePrintter.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafePrintter.Helper
{
    public class ClsHelper
    {
        public static Form ShowOrActiveForm(Form mdiParent, Type t)
        {
            // Tìm trong danh sách
            Form form = (from p in GlobalSetting.ChildFormList
                         where p.GetType() == t
                         select p).FirstOrDefault();

            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.MdiParent = mdiParent;
                form.WindowState = FormWindowState.Maximized;
                GlobalSetting.ChildFormList.Add(form);
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = mdiParent;
                    form.WindowState = FormWindowState.Maximized;
                    GlobalSetting.ChildFormList.Add(form);
                    form.Show();
                }
                else
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Activate();
                }
            }
            return form;
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
    }
}
