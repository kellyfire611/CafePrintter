//<auto-generated />

#region "Author"
/****************************************************************************************
 * Solution     : CUSC His Framework
 * Project code : APP1105
 * Author       : Dương Nguyễn Phú Cường
 * Company      : Cusc Software
 * Version      : 1.0.0.1
 * Created date : 29/03/2013
 ***************************************************************************************/
#endregion

using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.Drawing;
using DevExpress.XtraEditors;

namespace KFLibrary.Text
{
    public class TextConverter
    {
        /* -------------------------------- Enums ------------------------------------ */
        #region "Enums"
        public enum ConvertType
        {
            UnicodeToTCVN3,
            UnicodeToVNI
        }
        #endregion
        /* --------------------------------------------------------------------------- */

        /* ------------------------------- Variables --------------------------------- */
        #region "Variables"
        private static string[] _tableTCVN3 = 
        {
            "A","a","¸","¸","µ","µ","¶","¶","·","·","¹","¹",    // 0: a
            "¢","©","Ê","Ê","Ç","Ç","È","È","É","É","Ë","Ë",    // 1: a^
            "¡","¨","¾","¾","»","»","¼","¼","½","½","Æ","Æ",    // 2: a(
            "B","b","C","c","D","d",
            "§","®",
            "E","e","Ð","Ð","Ì","Ì","Î","Î","Ï","Ï","Ñ","Ñ",    // 3: e
            "£","ª","Õ","Õ","Ò","Ò","Ó","Ó","Ô","Ô","Ö","Ö",    // 4: e^
            "F","f","G","g","H","h",
            "I","i","Ý","Ý","×","×","Ø","Ø","Ü","Ü","Þ","Þ",    // 5: i
            "J","j","K","k","L","l","M","m","N","n",
            "O","o","ã","ã","ß","ß","á","á","â","â","ä","ä",    // 6: o
            "¤","«","è","è","å","å","æ","æ","ç","ç","é","é",    // 7: o^
            "¥","¬","í","í","ê","ê","ë","ë","ì","ì","î","î",    // 8: o+
            "P","p","Q","q","R","r","S","s","T","t",
            "U","u","ó","ó","ï","ï","ñ","ñ","ò","ò","ô","ô",    // 9: u
            "¦","­","ø","ø","õ","õ","ö","ö","÷","÷","ù","ù",     //10: u+ 
            "V","v","W","w","X","x",
            "Y","y","ý","ý","ú","ú","û","û","ü","ü","þ","þ",	//11: y
            "Z","z",

            // Symbols that have different code points in Unicode and Western charsets
            "€", "₡", "ƒ", "„", "…", "†", "‡", "ˆ",
            "‰", "Š", "‹", "Œ", "Ž", "‘", "'", "“",
            "”", "•", "–", "—", "˜", "™", "š", "›",
            "œ", "ž", "Ÿ"
        };
        //MNTU(25/09/2014) - Biến sử dụng để chuyển từ Unicode sang VNI-Times
        private static int[] _tableACII = 
         {
            7845, 7847, 7849, 7851, 7853, 226, 225, 224, 7843, 227, 7841, 7855, 7857, 7859, 
            7861, 7863, 259, 250, 249, 7911, 361, 7909, 7913, 7915, 7917, 7919, 7921, 432, 
            7871, 7873, 7875, 7877, 7879, 234, 233, 232, 7867, 7869, 7865, 7889, 7891, 7893, 
            7895, 7897, 244, 243, 242, 7887, 245, 7885, 7899, 7901, 7903, 7905, 7907, 417, 
            237, 236, 7881, 297, 7883, 253, 7923, 7927, 7929, 7925, 273, 7844, 7846, 7848, 
            7850, 7852, 194, 193, 192, 7842, 195, 7840, 7854, 7856, 7858, 7860, 7862, 258, 
            218, 217, 7910, 360, 7908, 7912, 7914, 7916, 7918, 7920, 431, 7870, 7872, 7874, 
            7876, 7878, 202, 201, 200, 7866, 7868, 7864, 7888, 7890, 7892, 7894, 7896, 212, 
            211, 210, 7886, 213, 7884, 7898, 7900, 7902, 7904, 7906, 416, 205, 204, 7880, 296,
            7882, 221, 7922, 7926, 7928, 7924, 272
         };

        private static string[] _tableVni = 
        {
            "aá", "aà", "aå", "aã", "aä", "aâ", "aù", "aø", "aû", "aõ", "aï", "aé", "aè", 
            "aú", "aü", "aë", "aê", "uù", "uø", "uû", "uõ", "uï", "öù", "öø", "öû", "öõ", 
            "öï", "ö", "eá", "eà", "eå", "eã", "eä", "eâ", "eù", "eø", "eû", "eõ", "eï", 
            "oá", "oà", "oå", "oã", "oä", "oâ", "où", "oø", "oû", "oõ", "oï", "ôù", "ôø", 
            "ôû", "ôõ", "ôï", "ô", "í", "ì", "æ", "ó", "ò", "yù", "yø", "yû", "yõ", "î", 
            "ñ", "AÁ", "AÀ", "AÅ", "AÃ", "AÄ", "AÂ", "AÙ", "AØ", "AÛ", "AÕ", 
            "AÏ", "AÉ", "AÈ", "AÚ", "AÜ", "AË", "AÊ", "UÙ", "UØ", "UÛ", "UÕ", 
            "UÏ", "ÖÙ", "ÖØ", "ÖÛ", "ÖÕ", "ÖÏ", "Ö", "EÁ", "EÀ", "EÅ",
            "EÃ", "EÄ", "EÂ", "EÙ", "EØ", "EÛ", "EÕ", "EÏ", "OÁ", "OÀ", "OÅ", 
            "OÃ", "OÄ", "OÂ", "OÙ", "OØ", "OÛ", "OÕ", "OÏ", "ÔÙ", "ÔØ", "ÔÛ", 
            "ÔÕ", "ÔÏ", "Ô", "Í", "Ì", "Æ", "Ó", "Ò", "YÙ", "YØ", "YÛ", "YÕ", 
            "Î", "Ñ"
        };

        private static string[] _loiVni = 
        {
            "aauø", "aaø", "aaoõ", "auø", "aoõ", "aeù", "aeø", "auuø", "aeâ", "uuø", "uoõ", 
            "öoõ", "eoõ", "AAUØ", "AAØ", "AAOÕ", "AUØ", "AOÕ", "AEÙ", "AEØ", "AUUØ", 
            "AEÂ", "UUØ", "UOÕ", "ÖOÕ", "EOÕ"
        };

        private static string[] _suaLoiVni = 
        {
            "aá", "aà", "aã", "aù", "aõ", "aé", "aè", "aú", "aê", "uù", "uõ", "öõ", "eõ", "AÁ", 
            "AÀ", "AÃ", "AÙ", "AÕ", "AÉ", "AÈ", "AÚ", "AÊ", "UÙ", "UÕ", "ÖÕ", "EÕ"
        };

        public static string[] _tableUnicode =
        {
            "\u0041", "\u0061", "\u00c1", "\u00e1", "\u00c0", "\u00e0", "\u1ea2", "\u1ea3", "\u00c3", "\u00e3", "\u1ea0", "\u1ea1", //a
            "\u00c2", "\u00e2", "\u1ea4", "\u1ea5", "\u1ea6", "\u1ea7", "\u1ea8", "\u1ea9", "\u1eaa", "\u1eab", "\u1eac", "\u1ead", //a^
            "\u0102", "\u0103", "\u1eae", "\u1eaf", "\u1eb0", "\u1eb1", "\u1eb2", "\u1eb3", "\u1eb4", "\u1eb5", "\u1eb6", "\u1eb7", //a(
            "\u0042", "\u0062", "\u0043", "\u0063", "\u0044", "\u0064",                                                             //B b C c D d
            "\u0110", "\u0111",                                                                                                     // DD, dd
            "\u0045", "\u0065", "\u00c9", "\u00e9", "\u00c8", "\u00e8", "\u1eba", "\u1ebb", "\u1ebc", "\u1ebd", "\u1eb8", "\u1eb9", //e
            "\u00ca", "\u00ea", "\u1ebe", "\u1ebf", "\u1ec0", "\u1ec1", "\u1ec2", "\u1ec3", "\u1ec4", "\u1ec5", "\u1ec6", "\u1ec7", //e^
            "\u0046", "\u0066", "\u0047", "\u0067", "\u0048", "\u0068",                                                             // F f G g H h
            "\u0049", "\u0069", "\u00cd", "\u00ed", "\u00cc", "\u00ec", "\u1ec8", "\u1ec9", "\u0128", "\u0129", "\u1eca", "\u1ecb", //i
            "\u004a", "\u006a", "\u004b", "\u006b", "\u004c", "\u006c", "\u004d", "\u006d", "\u004e", "\u006e",                     // J j K k L l M m N n
            "\u004f", "\u006f", "\u00d3", "\u00f3", "\u00d2", "\u00f2", "\u1ece", "\u1ecf", "\u00d5", "\u00f5", "\u1ecc", "\u1ecd", //o
            "\u00d4", "\u00f4", "\u1ed0", "\u1ed1", "\u1ed2", "\u1ed3", "\u1ed4", "\u1ed5", "\u1ed6", "\u1ed7", "\u1ed8", "\u1ed9", //o^
            "\u01a0", "\u01a1", "\u1eda", "\u1edb", "\u1edc", "\u1edd", "\u1ede", "\u1edf", "\u1ee0", "\u1ee1", "\u1ee2", "\u1ee3", //o+
            "\u0050", "\u0070", "\u0051", "\u0071", "\u0052", "\u0072", "\u0053", "\u0073", "\u0054", "\u0074",                     //P p Q q R r S s T t
            "\u0055", "\u0075", "\u00da", "\u00fa", "\u00d9", "\u00f9", "\u1ee6", "\u1ee7", "\u0168", "\u0169", "\u1ee4", "\u1ee5", //u
            "\u01af", "\u01b0", "\u1ee8", "\u1ee9", "\u1eea", "\u1eeb", "\u1eec", "\u1eed", "\u1eee", "\u1eef", "\u1ef0", "\u1ef1", //u+
            "\u0056", "\u0076", "\u0057", "\u0077", "\u0058", "\u0078",                                                             // V v W w X x
            "\u0059", "\u0079", "\u00dd", "\u00fd", "\u1ef2", "\u1ef3", "\u1ef6", "\u1ef7", "\u1ef8", "\u1ef9", "\u1ef4", "\u1ef5", //y
            "\u005a", "\u007a",                                                                                                     // Z z
            
            // Symbols that have different code points in Unicode and Western charsets
            "\u20AC", "\u20A1", "\u0192", "\u201E", "\u2026", "\u2020", "\u2021", "\u02C6",
            "\u2030", "\u0160", "\u2039", "\u0152", "\u017D", "\u2018", "\u2019", "\u201C",
            "\u201D", "\u2022", "\u2013", "\u2014", "\u02DC", "\u2122", "\u0161", "\u203A", 
            "\u0153", "\u017E", "\u0178"
        };
        #endregion
        /* --------------------------------------------------------------------------- */

        /* ------------------------------ Properties --------------------------------- */
        #region "Properties"

        #endregion
        /* --------------------------------------------------------------------------- */

        /* -------------------------------- Methods ---------------------------------- */
        #region "Methods"
        static TextConverter()
        {
        }
        private const int EM_SETTABSTOPS = 0x00CB;

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr h, int msg, int wParam, int[] lParam);

        public static void SetTabWidth(TextBox textbox, int tabWidth)
        {
            using (Graphics graphics = textbox.CreateGraphics())
            {
                var characterWidth = (int)graphics.MeasureString("M", textbox.Font).Width;
                SendMessage(textbox.Handle, EM_SETTABSTOPS, 1,
                            new int[] { tabWidth * characterWidth });
            }
        }
        private static string ConvertChar(string source, ConvertType type = ConvertType.UnicodeToTCVN3)
        {
            switch (type)
            {
                case ConvertType.UnicodeToTCVN3:
                    for (int i = 0; i < _tableTCVN3.Length; i++)
                    {
                        if (source == _tableUnicode[i])
                            return _tableTCVN3[i];
                    }
                    break;
                case ConvertType.UnicodeToVNI:
                    break;
                default:
                    break;
            }
            return source;
        }

        public static string Convert(string source, ConvertType type = ConvertType.UnicodeToTCVN3)
        {
            StringBuilder sb = new StringBuilder();
            switch (type)
            {
                case ConvertType.UnicodeToTCVN3:
                    for (int i = 0; i < source.Length; i++)
                    {
                        sb.Append(ConvertChar(source[i].ToString()));
                    }
                    break;
                case ConvertType.UnicodeToVNI:
                    //MNTU(25/09/2014) -Chuyển từ Unicode sang VNI-Times
                    for (int i = 0; i < _tableVni.Length; i++)
                    {
                        source = source.Replace(System.Convert.ToChar(_tableACII[i]).ToString(), _tableVni[i]);
                    }
                    for (int i = 0; i < _loiVni.Length; i++)
                    {
                        source = source.Replace(_loiVni[i], _suaLoiVni[i]);
                    }
                    sb.Append(source);
                    break;
                default:
                    break;
            }
            return sb.ToString();
        }
        #endregion
        /* --------------------------------------------------------------------------- */

        /* --------------------------- Event handlers--------------------------------- */
        #region "Event handlers"

        #endregion
        /* --------------------------------------------------------------------------- */

        /* ------------------------------ Sub classes -------------------------------- */
        #region "Sub classes"

        #endregion
        /* --------------------------------------------------------------------------- */

        /* --------------------------------- Test ------------------------------------ */
        #region "Tests"
        // Method test code
        private void Test()
        {
            // Todo: test code here
        }
        #endregion
        /* --------------------------------------------------------------------------- */
    }
}
