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

using System;
using DevExpress.XtraLayout;

namespace KFLibrary.Win.WinForm.DevEx.Extensions
{
    public static class XtraLayoutExtensions
    {
        /* -------------------------------- Enums ------------------------------------ */
        #region "Enums"

        #endregion
        /* --------------------------------------------------------------------------- */

        /* --------------------------------- Events ---------------------------------- */
        #region "Events"

        #endregion
        /* --------------------------------------------------------------------------- */

        /* ------------------------------- Variables --------------------------------- */
        #region "Variables"

        #endregion
        /* --------------------------------------------------------------------------- */

        /* ------------------------------ Properties --------------------------------- */
        #region "Properties"

        #endregion
        /* --------------------------------------------------------------------------- */

        /* -------------------------------- Methods ---------------------------------- */
        #region "Methods"
        public static void BeginUpdateWrapper(this LayoutControl layout, Action action)
        {
            layout.BeginUpdate();
            try
            {
                action.Invoke();
            }
            finally
            {
                layout.EndUpdate();
            }
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
        #endregion
        /* --------------------------------------------------------------------------- */
    }
}
