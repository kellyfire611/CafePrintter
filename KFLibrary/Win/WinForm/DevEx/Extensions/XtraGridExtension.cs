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
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using KFLibrary.Win.WinForm.DevEx.Custom;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KFLibrary.Win.WinForm.DevEx.Extensions
{
    public static class XtraGridExtensions
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
        public static void CreateCheckColumnUnbound(this GridView view, CustomColumnDataEventArgs e,
            string fieldNameCheck, string fieldNameID, Dictionary<Int64, object> selectedRows)
        {
            Int64 id = (Int64)view.GetListSourceRowCellValue(e.ListSourceRowIndex, fieldNameID);
            if (e.Column.FieldName == fieldNameCheck)
            {
                if (e.IsGetData)
                {
                    e.Value = selectedRows.ContainsKey(id);
                }
                else
                {
                    bool check = Convert.ToBoolean(e.Value);
                    if (check == true)
                    {
                        // Cần kiểm tra xem có tồn tại k?
                        if (selectedRows.ContainsKey(id) == false)
                        {
                            selectedRows.Add(id, e.Row);
                        }
                    }
                    else
                    {
                        selectedRows.Remove(id);
                    }
                }
            }
        }

        public static void ExpandMasterRowAll(this GridView view)
        {
            for (int i = 0; i < view.DataRowCount; i++)
            {
                if (view.IsValidRowHandle(i))
                {
                    view.ExpandMasterRow(i, 0);
                }
            }
        }

        public static void CollapseMasterRowAll(this GridView view)
        {
            //View.BeginUpdate();
            //try
            //{
            //    int dataRowCount = View.DataRowCount;
            //    for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
            //        View.SetMasterRowExpanded(rHandle, true);
            //}
            //finally
            //{
            //    View.EndUpdate();
            //}

            for (int i = 0; i < view.DataRowCount; i++)
            {
                if (view.IsValidRowHandle(i))
                {
                    view.CollapseMasterRow(i);
                }
            }
        }

        //        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {

        //    GridView view = sender as GridView;
        //    if(e.Column.VisibleIndex == 0 && view.IsMasterRowEmpty(e.RowHandle))
        //        (e.Cell as GridCellInfo).CellButtonRect = Rectangle.Empty;
        //    }
        //}

        public static void RefreshDataMasterDetailsAll(this GridView view, bool isExpand = true)
        {

            view.CollapseMasterRowAll();
            if (isExpand == true)
            {
                view.ExpandMasterRowAll();
            }
        }



        public static GridView GetDetailViewBy_RelationName(this GridView view, int rowHandle, string relationName)
        {
            return view.GetDetailView(rowHandle, view.GetRelationIndex(rowHandle, relationName)) as GridView;
        }

        public static void RaiseFocusedRowChanged(this GridView view, int rowHandle = 0)
        {
            // Nếu chỉ có 1 dòng thì refresh lại dòng đó
            if (rowHandle == 0)
            {
                view.FocusedRowHandle = GridControl.InvalidRowHandle;
                return;
            }

            view.FocusedRowHandle = rowHandle;
        }

        public static void BeginDataUpdateWrapper(this GridView view, Action action)
        {
            view.BeginDataUpdate();
            try
            {
                action.Invoke();
            }
            finally
            {
                view.EndDataUpdate();
            }
        }

        public static void BeginUpdateWrapper(this GridView view, Action action)
        {
            view.BeginUpdate();
            try
            {
                action.Invoke();
            }
            finally
            {
                view.EndUpdate();
            }
        }

        public static int GetGroupRowCount(this GridView view)
        {
            int rHandle = -1;
            int groupRowCount = 0;
            while (view.IsValidRowHandle(rHandle))
            {
                groupRowCount++;
                rHandle--;
            }
            return groupRowCount;
        }

        //private void gridView1_CustomDrawEmptyForeground(object sender, CustomDrawEventArgs e)
        public static void DrawBackground(this GridView view)
        {
            view.CustomDrawEmptyForeground += (sender, e) =>
            {
                string s = String.Empty;
                ColumnView grid = sender as ColumnView;
                // Get the number of records in the underlying data source.
                DataView dataSource = grid.DataSource as DataView;
                if (dataSource == null)
                {
                    s = "Dương nguyễn phú cường Test";
                }
                else
                {
                    if (dataSource.Count == 0) //the data source is empty
                        s = "Press Insert to add a new record";
                    else //no records meet the filter criteria
                        s = "No records match the current filter criteria";
                }
                Font font = new Font("Tahoma", 10, FontStyle.Bold);
                Rectangle r = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, e.Bounds.Width - 5,
                  e.Bounds.Height - 5);
                e.Graphics.DrawString(s, font, Brushes.Black, r);
            };
        }

        /// <summary>
        /// Sets the style column header.
        /// </summary>
        /// <param name="p_Col">The p_ col.</param>
        public static void SetStyleColumnHeader(BandedGridColumn p_Col, bool p_AllowMove = true,
            AppearanceObject p_AppearanceCell = null)
        {
            p_Col.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold);
            p_Col.AppearanceHeader.Options.UseFont = true;
            p_Col.AppearanceHeader.Options.UseTextOptions = true;
            p_Col.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            p_Col.OptionsColumn.AllowMove = p_AllowMove;

            //p_Col.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            if (p_AppearanceCell != null)
                p_Col.AppearanceCell.Assign(p_AppearanceCell);

        }

        /// <summary>
        /// Sets the style band header.
        /// </summary>
        /// <param name="p_GridBand">The p_ grid band.</param>
        public static void SetStyleBandHeader(GridBand p_GridBand, bool p_AllowMove = true)
        {
            p_GridBand.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            p_GridBand.AppearanceHeader.Options.UseFont = true;
            p_GridBand.AppearanceHeader.Options.UseTextOptions = true;
            p_GridBand.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            p_GridBand.AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;
            p_GridBand.OptionsBand.AllowMove = p_AllowMove;
        }

        /// <summary>
        /// Adds the grid band to AdvGridView.
        /// </summary>
        /// <param name="p_View">The p_ view.</param>
        /// <param name="p_BandCaption">The p_ band caption.</param>
        /// <param name="p_BandName">Name of the p_ band.</param>
        /// <param name="p_BandRowCount">The p_ band row count.</param>
        /// <param name="p_UseStyleBand">if set to <c>true</c> [p_ use style band].</param>
        /// <param name="p_Col">The p_ col.</param>
        /// <param name="p_UseStyleColumn">if set to <c>true</c> [p_ use style column].</param>
        /// <param name="p_ColSummary">The p_ col summary.</param>
        /// <param name="p_ParentBand">The p_ parent band.</param>
        public static void AddGridBandToAdvGridView(
            AdvBandedGridView p_View,
            string p_BandCaption,
            string p_BandName,
            byte p_BandRowCount = 1,
            bool p_UseStyleBand = false,
            BandedGridColumn p_Col = null,
            bool p_UseStyleColumn = false,
            GridColumnSummaryItem p_ColSummary = null,
            GridBand p_ParentBand = null,
            bool p_AllowMoveCol = true,
            bool p_AllowMoveBand = true)
        {
            GridBand gb = new GridBand()
            {
                Caption = p_BandCaption,
                Name = p_BandName,
                RowCount = p_BandRowCount
            };

            if (p_Col != null)
            {
                p_Col.Visible = true;
                p_Col.OptionsColumn.AllowMove = false; // Không cho di chuyển cột

                if (p_ColSummary != null)
                    p_Col.Summary.Add(p_ColSummary);
                gb.Columns.Add(p_Col);
            }

            if (p_ParentBand != null)
                p_ParentBand.Children.Add(gb);
            else
                p_View.Bands.Add(gb);

            if (p_UseStyleBand)
                SetStyleBandHeader(gb, p_AllowMoveBand);
            if (p_UseStyleColumn && p_Col != null)
                SetStyleColumnHeader(p_Col, p_AllowMoveCol);
        }

        /// <summary>
        /// Đánh số thứ tự cột
        /// </summary>
        /// <param name="p_View">The p_ view.</param>
        /// <param name="p_EventArgs">The <see cref="DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs"/> instance containing the event data.</param>
        public static void DanhSoThuTuColumn(BandedGridView p_View, DragObjectDropEventArgs p_EventArgs = null)
        {
            // Đánh số thứ tự cho tất cả các cột đang hiển thị
            if (p_EventArgs == null)
            {
                // Đánh số thứ tự các cột
                for (int i = 0; i < p_View.VisibleColumns.Count; i++)
                {
                    p_View.VisibleColumns[i].Caption = (i + 1).ToString();
                }
            }
            else // Đánh số thứ tự khi kéo thả GridBand
            {
                // Kiểm tra khi drag drop GridBand
                if (p_EventArgs.DragObject is GridBand)
                {
                    // Kiểm tra kéo có hợp lệ không ?
                    if (p_EventArgs.DropInfo.Valid)
                    {
                        // Đánh số thứ tự các cột
                        for (int i = 0; i < p_View.VisibleColumns.Count; i++)
                        {
                            p_View.VisibleColumns[i].Caption = (i + 1).ToString();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Modifies the customization form.
        /// </summary>
        /// <param name="p_View">The p_ view.</param>
        public static void ModifyCustomizationForm(BandedGridView p_View)
        {
            XtraTabControl tab = p_View.CustomizationForm.Controls[0] as XtraTabControl;
            if (tab != null)
            {
                tab.TabPages[0].PageVisible = false;
            }
        }

        /// <summary>
        /// Tạo dữ liệu cột STT
        /// </summary>
        /// <param name="p_View">The p_ view.</param>
        /// <param name="p_EventArgs">The <see cref="DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs"/> instance containing the event data.</param>
        public static void TaoCotSTT(BandedGridView p_View, CustomColumnDataEventArgs p_EventArgs,
            int p_StartNum = 1)
        {
            if (p_EventArgs.Column.FieldName == "STT" && p_EventArgs.IsGetData)
            {
                int num = p_View.GetRowHandle(p_EventArgs.ListSourceRowIndex) + 1;
                if (num >= p_StartNum)
                    p_EventArgs.Value = num - p_StartNum + 1;
            }
        }


        public static void ApplyFormatConditionAppearance(this GridView view, Dictionary<string, AppearanceObjectEx> lstConditionTag)
        {
            view.BeginUpdateWrapper(() =>
            {
                foreach (var item in lstConditionTag)
                {
                    if (view.FormatConditions[item.Key] != null
                        && item.Value != null)
                    {
                        view.FormatConditions[item.Key].Appearance.Assign(item.Value);
                    }
                }
            });
        }

        public static void CreateCustomMenu(this GridControl gc)
        {
            XtraGirdMenuHelper.CreateCustomXtraGridMenu(gc as Control);
        }

        #region Hàm cho phép sử dụng EmbeddedNavigator trên GridLookUpEdit
        /// <summary>
        /// Hàm hiển thị EmbeddedNavigator
        /// </summary>
        /// <param name="gridLookUpEdit"></param>
        public static void UseEmbeddedNavigator(this GridLookUpEdit gridLookUpEdit)
        {
            gridLookUpEdit.Popup += new System.EventHandler(gridLookUpEdit_Popup);
        }
        /// <summary>
        /// Hàm hiển thị UseEmbeddedNavigator trên gridLookUpEdit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void gridLookUpEdit_Popup(object sender, EventArgs e)
        {
            DevExpress.Utils.Win.IPopupControl popup = sender as DevExpress.Utils.Win.IPopupControl;
            if (popup != null)
            {
                DevExpress.XtraEditors.Popup.PopupGridLookUpEditForm popupForm = popup.PopupWindow as DevExpress.XtraEditors.Popup.PopupGridLookUpEditForm;
                DevExpress.XtraGrid.GridControl grid = popupForm.Controls[2] as DevExpress.XtraGrid.GridControl;
                grid.UseEmbeddedNavigator = true;
                grid.EmbeddedNavigator.TextStringFormat = "Dòng {0} / {1}";
                grid.EmbeddedNavigator.Buttons.Append.Visible = false;
                grid.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
                grid.EmbeddedNavigator.Buttons.Edit.Visible = false;
                grid.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
                grid.EmbeddedNavigator.Buttons.Remove.Visible = false;
            }
        }
        #endregion

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