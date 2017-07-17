using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafePrintter2.Model.SimpleClass
{
    public class RootObject
    {
        public string folder_path { get; set; }
        public string printer_name { get; set; }
        public int printer_counter { get; set; }
        public int margin_radius { get; set; }
        public int margin_leTrai { get; set; }
        public int margin_vachKe { get; set; }
        public int margin_leTrenVachKe { get; set; }
        public int margin_leTren { get; set; }

    }

    public class Printer
    {
        public string PrinterName { get; set; }
    }
}
