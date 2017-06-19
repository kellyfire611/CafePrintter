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

using Microsoft.Win32;

namespace KFLibrary.Registries
{
    public class WinStartup
    {
        /// <summary>
        /// Kiểm tra xem đã có key, application path trong registry Startup chưa?
        /// </summary>
        /// <param name="key">Key cần kiểm tra.</param>
        /// <param name="path">Đường dẫn tới chương trình.</param>
        /// <returns></returns>
        public static bool IsAdded(string key, string appPath)
        {
            using (var runKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
            {
                bool added = appPath.Equals(runKey.GetValue(key));
                return added;
            }
        }

        /// <summary>
        /// Thêm key, application path vào registry Startup
        /// </summary>
        /// <param name="key">Key cần thêm.</param>
        /// <param name="path">Đường dẫn tới chương trình.</param>
        public static void Add(string key, string appPath)
        {
            using (var runKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                runKey.SetValue(key, appPath);
        }

        /// <summary>
        /// Xóa key torng registry Startup
        /// </summary>
        /// <param name="key">Key cần xóa.</param>
        public static void Remove(string key)
        {
            using (var runKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                runKey.DeleteValue(key, false);
        }
    }
}