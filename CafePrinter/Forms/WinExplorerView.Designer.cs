using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraNavBar;
namespace CafePrintter.Forms
{
    partial class ExplorerView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges2 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode1 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode2 = new DevExpress.XtraEditors.BreadCrumbNode();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imgs = new DevExpress.Utils.ImageCollection(this.components);
            this.ButtonItemHelp = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNavigationPane = new DevExpress.XtraBars.BarSubItem();
            this.ButtonCheckItemNavigationPane = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonCheckItemShowFavorites = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonCheckItemShowLibraries = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonItemItemCheckBoxes = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonItemFileNameExtensions = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonItemHiddenItems = new DevExpress.XtraBars.BarCheckItem();
            this.btnHideSelectedItems = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemCopy = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemPaste = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemCut = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopyItem = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemMoveTo = new DevExpress.XtraBars.BarSubItem();
            this.ButtonItemDocuments = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemMusic = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemVideos = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemPictures = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemChooseLocation = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemCopyTo = new DevExpress.XtraBars.BarSubItem();
            this.ButtonItemRename = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewFolder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewItem = new DevExpress.XtraBars.BarSubItem();
            this.ButtonItemNewShortcut = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewBitmapImage = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewContact = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewJournalDocument = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewRichTextDocument = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewTextDocument = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemCompressedFolder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelectNone = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemInvertSelection = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemPropertiesFolder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemRemoveProperties = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuDeleteButton = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonItemRecycle = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemPermanentlyDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemShowRecycleConfirmation = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonItemProperties = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuPropertiesButton = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnOpen = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemOptions = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuOptionsButton = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonItemChangeFilderOptions = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiViewStyle = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ContextItemOpen = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemCut = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemCopy = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemPaste = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemRename = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemProperties = new DevExpress.XtraBars.BarButtonItem();
            this.PageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupClipboard = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupOrganize = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupOpen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupSelect = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupViewPanes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupViewLayouts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupViewShowHide = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupViewEmpty = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.navBar = new DevExpress.XtraNavBar.NavBarControl();
            this.groupFavorites = new DevExpress.XtraNavBar.NavBarGroup();
            this.navPanelItemDesktop = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemDownloads = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemRecent = new DevExpress.XtraNavBar.NavBarItem();
            this.groupLibraries = new DevExpress.XtraNavBar.NavBarGroup();
            this.navPanelItemDocuments = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemMusic = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemPictures = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemVideos = new DevExpress.XtraNavBar.NavBarItem();
            this.navigationPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnNavigationHistory = new DevExpress.XtraEditors.LabelControl();
            this.btnUpTo = new DevExpress.XtraEditors.LabelControl();
            this.imgArrows = new DevExpress.Utils.ImageCollection(this.components);
            this.btnForward = new DevExpress.XtraEditors.LabelControl();
            this.btnBack = new DevExpress.XtraEditors.LabelControl();
            this.EditSearch = new DevExpress.XtraEditors.ButtonEdit();
            this.editBreadCrumb = new DevExpress.XtraEditors.BreadCrumbEdit();
            this.contentPanel = new DevExpress.XtraEditors.PanelControl();
            this.LayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lueSizeMode = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCropImage = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoayNgang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoayTrai = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoayDoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoayPhai = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.winExplorerView = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.columnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.liNavPaneRight = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlMainGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItemExplorerView = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCounter = new DevExpress.XtraLayout.SimpleLabelItem();
            this.itemPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.navigationMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuDeleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuPropertiesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuOptionsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanel)).BeginInit();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBreadCrumb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl)).BeginInit();
            this.LayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSizeMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liNavPaneRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlMainGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItemExplorerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // RibbonControl
            // 
            this.RibbonControl.ApplicationButtonText = "File";
            this.RibbonControl.ExpandCollapseItem.Id = 0;
            this.RibbonControl.Images = this.imgs;
            this.RibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl.ExpandCollapseItem,
            this.ButtonItemHelp,
            this.ButtonItemNavigationPane,
            this.ButtonItemItemCheckBoxes,
            this.ButtonItemFileNameExtensions,
            this.ButtonItemHiddenItems,
            this.btnHideSelectedItems,
            this.ButtonCheckItemNavigationPane,
            this.ButtonItemCopy,
            this.ButtonItemPaste,
            this.ButtonItemCut,
            this.btnCopyItem,
            this.ButtonItemMoveTo,
            this.ButtonItemCopyTo,
            this.ButtonItemRename,
            this.ButtonItemNewFolder,
            this.ButtonItemNewItem,
            this.ButtonItemEdit,
            this.ButtonItemSelectAll,
            this.btnSelectNone,
            this.ButtonItemInvertSelection,
            this.ButtonItemPropertiesFolder,
            this.ButtonItemRemoveProperties,
            this.ButtonItemDelete,
            this.ButtonItemRecycle,
            this.ButtonItemPermanentlyDelete,
            this.ButtonItemShowRecycleConfirmation,
            this.ButtonItemProperties,
            this.ButtonItemDocuments,
            this.ButtonItemMusic,
            this.ButtonItemVideos,
            this.ButtonItemPictures,
            this.ButtonItemChooseLocation,
            this.ButtonCheckItemShowFavorites,
            this.ButtonCheckItemShowLibraries,
            this.ButtonItemNewShortcut,
            this.ButtonItemNewBitmapImage,
            this.ButtonItemNewContact,
            this.ButtonItemNewJournalDocument,
            this.ButtonItemNewRichTextDocument,
            this.ButtonItemNewTextDocument,
            this.ButtonItemCompressedFolder,
            this.btnOpen,
            this.ButtonItemOptions,
            this.ButtonItemChangeFilderOptions,
            this.rgbiViewStyle,
            this.ContextItemOpen,
            this.ContextItemCut,
            this.ContextItemCopy,
            this.ContextItemPaste,
            this.ContextItemDelete,
            this.ContextItemRename,
            this.ContextItemProperties});
            this.RibbonControl.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl.MaxItemId = 175;
            this.RibbonControl.Name = "RibbonControl";
            this.RibbonControl.PageHeaderItemLinks.Add(this.ButtonItemHelp);
            this.RibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PageHome,
            this.PageView});
            this.RibbonControl.QuickToolbarItemLinks.Add(this.ButtonItemPropertiesFolder);
            this.RibbonControl.QuickToolbarItemLinks.Add(this.ButtonItemNewFolder);
            this.RibbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemRadioGroup1,
            this.repositoryItemTextEdit2});
            this.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.RibbonControl.Size = new System.Drawing.Size(1206, 143);
            this.RibbonControl.Visible = false;
            // 
            // imgs
            // 
            this.imgs.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgs.ImageStream")));
            this.imgs.Images.SetKeyName(0, "open_16x16.png");
            this.imgs.Images.SetKeyName(1, "hoverDown.png");
            this.imgs.Images.SetKeyName(2, "normalDown.png");
            this.imgs.Images.SetKeyName(3, "pressedDown.png");
            // 
            // ButtonItemHelp
            // 
            this.ButtonItemHelp.Caption = "Help";
            this.ButtonItemHelp.Id = 15;
            this.ButtonItemHelp.Name = "ButtonItemHelp";
            this.ButtonItemHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnHelpButtonItemClick);
            // 
            // ButtonItemNavigationPane
            // 
            this.ButtonItemNavigationPane.Caption = "Navigation pane";
            this.ButtonItemNavigationPane.Id = 16;
            this.ButtonItemNavigationPane.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonCheckItemNavigationPane),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonCheckItemShowFavorites, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonCheckItemShowLibraries)});
            this.ButtonItemNavigationPane.Name = "ButtonItemNavigationPane";
            this.ButtonItemNavigationPane.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonCheckItemNavigationPane
            // 
            this.ButtonCheckItemNavigationPane.BindableChecked = true;
            this.ButtonCheckItemNavigationPane.Caption = "Navigation pane";
            this.ButtonCheckItemNavigationPane.Checked = true;
            this.ButtonCheckItemNavigationPane.Id = 37;
            this.ButtonCheckItemNavigationPane.Name = "ButtonCheckItemNavigationPane";
            this.ButtonCheckItemNavigationPane.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowNavPaneItemClick);
            // 
            // ButtonCheckItemShowFavorites
            // 
            this.ButtonCheckItemShowFavorites.BindableChecked = true;
            this.ButtonCheckItemShowFavorites.Caption = "Show favorites";
            this.ButtonCheckItemShowFavorites.Checked = true;
            this.ButtonCheckItemShowFavorites.Id = 118;
            this.ButtonCheckItemShowFavorites.Name = "ButtonCheckItemShowFavorites";
            this.ButtonCheckItemShowFavorites.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowFavoritesItemClick);
            // 
            // ButtonCheckItemShowLibraries
            // 
            this.ButtonCheckItemShowLibraries.BindableChecked = true;
            this.ButtonCheckItemShowLibraries.Caption = "Show libraries";
            this.ButtonCheckItemShowLibraries.Checked = true;
            this.ButtonCheckItemShowLibraries.Id = 119;
            this.ButtonCheckItemShowLibraries.Name = "ButtonCheckItemShowLibraries";
            this.ButtonCheckItemShowLibraries.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowLibrariesItemClick);
            // 
            // ButtonItemItemCheckBoxes
            // 
            this.ButtonItemItemCheckBoxes.Caption = "Item check boxes";
            this.ButtonItemItemCheckBoxes.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.ButtonItemItemCheckBoxes.Id = 26;
            this.ButtonItemItemCheckBoxes.Name = "ButtonItemItemCheckBoxes";
            this.ButtonItemItemCheckBoxes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowCheckBoxesItemClick);
            // 
            // ButtonItemFileNameExtensions
            // 
            this.ButtonItemFileNameExtensions.Caption = "File name extensions";
            this.ButtonItemFileNameExtensions.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.ButtonItemFileNameExtensions.Id = 27;
            this.ButtonItemFileNameExtensions.Name = "ButtonItemFileNameExtensions";
            this.ButtonItemFileNameExtensions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowFileNameExtensionsCheckItemClick);
            // 
            // ButtonItemHiddenItems
            // 
            this.ButtonItemHiddenItems.Caption = "Hidden items";
            this.ButtonItemHiddenItems.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.ButtonItemHiddenItems.Id = 28;
            this.ButtonItemHiddenItems.Name = "ButtonItemHiddenItems";
            this.ButtonItemHiddenItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowHiddenItemsCheckItemClick);
            // 
            // btnHideSelectedItems
            // 
            this.btnHideSelectedItems.Caption = "Hide selected items";
            this.btnHideSelectedItems.Id = 29;
            this.btnHideSelectedItems.Name = "btnHideSelectedItems";
            this.btnHideSelectedItems.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonItemCopy
            // 
            this.ButtonItemCopy.Caption = "Copy";
            this.ButtonItemCopy.Id = 38;
            this.ButtonItemCopy.Name = "ButtonItemCopy";
            this.ButtonItemCopy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem1.Text = "The command is not implemented";
            superToolTip1.Items.Add(toolTipItem1);
            this.ButtonItemCopy.SuperTip = superToolTip1;
            // 
            // ButtonItemPaste
            // 
            this.ButtonItemPaste.Caption = "Paste";
            this.ButtonItemPaste.Id = 39;
            this.ButtonItemPaste.Name = "ButtonItemPaste";
            this.ButtonItemPaste.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonItemCut
            // 
            this.ButtonItemCut.Caption = "Cut";
            this.ButtonItemCut.Id = 40;
            this.ButtonItemCut.Name = "ButtonItemCut";
            // 
            // btnCopyItem
            // 
            this.btnCopyItem.Caption = "Copy path";
            this.btnCopyItem.Enabled = false;
            this.btnCopyItem.Id = 41;
            this.btnCopyItem.Name = "btnCopyItem";
            this.btnCopyItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCopyPathItemClick);
            // 
            // ButtonItemMoveTo
            // 
            this.ButtonItemMoveTo.Caption = "Move to";
            this.ButtonItemMoveTo.Enabled = false;
            this.ButtonItemMoveTo.Id = 43;
            this.ButtonItemMoveTo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemDocuments),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemMusic),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemVideos),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemPictures),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemChooseLocation, true)});
            this.ButtonItemMoveTo.Name = "ButtonItemMoveTo";
            this.ButtonItemMoveTo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonItemDocuments
            // 
            this.ButtonItemDocuments.Caption = "Documents";
            this.ButtonItemDocuments.Id = 106;
            this.ButtonItemDocuments.Name = "ButtonItemDocuments";
            // 
            // ButtonItemMusic
            // 
            this.ButtonItemMusic.Caption = "Music";
            this.ButtonItemMusic.Id = 107;
            this.ButtonItemMusic.Name = "ButtonItemMusic";
            // 
            // ButtonItemVideos
            // 
            this.ButtonItemVideos.Caption = "Videos";
            this.ButtonItemVideos.Id = 108;
            this.ButtonItemVideos.Name = "ButtonItemVideos";
            // 
            // ButtonItemPictures
            // 
            this.ButtonItemPictures.Caption = "Pictures";
            this.ButtonItemPictures.Id = 109;
            this.ButtonItemPictures.Name = "ButtonItemPictures";
            // 
            // ButtonItemChooseLocation
            // 
            this.ButtonItemChooseLocation.Caption = "Choose location...";
            this.ButtonItemChooseLocation.Id = 110;
            this.ButtonItemChooseLocation.Name = "ButtonItemChooseLocation";
            // 
            // ButtonItemCopyTo
            // 
            this.ButtonItemCopyTo.Caption = "Copy to";
            this.ButtonItemCopyTo.Enabled = false;
            this.ButtonItemCopyTo.Id = 44;
            this.ButtonItemCopyTo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemDocuments),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemMusic),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemVideos),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemPictures),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemChooseLocation, true)});
            this.ButtonItemCopyTo.Name = "ButtonItemCopyTo";
            this.ButtonItemCopyTo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonItemRename
            // 
            this.ButtonItemRename.Caption = "Rename";
            this.ButtonItemRename.Id = 46;
            this.ButtonItemRename.Name = "ButtonItemRename";
            this.ButtonItemRename.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonItemNewFolder
            // 
            this.ButtonItemNewFolder.Caption = "New folder";
            this.ButtonItemNewFolder.Id = 47;
            this.ButtonItemNewFolder.Name = "ButtonItemNewFolder";
            this.ButtonItemNewFolder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // ButtonItemNewItem
            // 
            this.ButtonItemNewItem.Caption = "New item";
            this.ButtonItemNewItem.Id = 48;
            this.ButtonItemNewItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewFolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewShortcut),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewBitmapImage),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewContact),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewJournalDocument),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewRichTextDocument),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewTextDocument),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemCompressedFolder)});
            this.ButtonItemNewItem.Name = "ButtonItemNewItem";
            // 
            // ButtonItemNewShortcut
            // 
            this.ButtonItemNewShortcut.Caption = "Shortcut";
            this.ButtonItemNewShortcut.Id = 120;
            this.ButtonItemNewShortcut.Name = "ButtonItemNewShortcut";
            // 
            // ButtonItemNewBitmapImage
            // 
            this.ButtonItemNewBitmapImage.Caption = "Bitmap image";
            this.ButtonItemNewBitmapImage.Id = 121;
            this.ButtonItemNewBitmapImage.Name = "ButtonItemNewBitmapImage";
            // 
            // ButtonItemNewContact
            // 
            this.ButtonItemNewContact.Caption = "Contact";
            this.ButtonItemNewContact.Id = 122;
            this.ButtonItemNewContact.Name = "ButtonItemNewContact";
            // 
            // ButtonItemNewJournalDocument
            // 
            this.ButtonItemNewJournalDocument.Caption = "Journal document";
            this.ButtonItemNewJournalDocument.Id = 123;
            this.ButtonItemNewJournalDocument.Name = "ButtonItemNewJournalDocument";
            // 
            // ButtonItemNewRichTextDocument
            // 
            this.ButtonItemNewRichTextDocument.Caption = "Rich text document";
            this.ButtonItemNewRichTextDocument.Id = 124;
            this.ButtonItemNewRichTextDocument.Name = "ButtonItemNewRichTextDocument";
            // 
            // ButtonItemNewTextDocument
            // 
            this.ButtonItemNewTextDocument.Caption = "Text document";
            this.ButtonItemNewTextDocument.Id = 125;
            this.ButtonItemNewTextDocument.Name = "ButtonItemNewTextDocument";
            // 
            // ButtonItemCompressedFolder
            // 
            this.ButtonItemCompressedFolder.Caption = "Compressed (zipped) folder";
            this.ButtonItemCompressedFolder.Id = 126;
            this.ButtonItemCompressedFolder.Name = "ButtonItemCompressedFolder";
            // 
            // ButtonItemEdit
            // 
            this.ButtonItemEdit.Caption = "Edit";
            this.ButtonItemEdit.Id = 52;
            this.ButtonItemEdit.Name = "ButtonItemEdit";
            // 
            // ButtonItemSelectAll
            // 
            this.ButtonItemSelectAll.Caption = "Select all";
            this.ButtonItemSelectAll.Id = 54;
            this.ButtonItemSelectAll.Name = "ButtonItemSelectAll";
            this.ButtonItemSelectAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSelectAllItemClick);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Caption = "Select none";
            this.btnSelectNone.Id = 55;
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSelectNoneItemClick);
            // 
            // ButtonItemInvertSelection
            // 
            this.ButtonItemInvertSelection.Caption = "Invert selection";
            this.ButtonItemInvertSelection.Id = 56;
            this.ButtonItemInvertSelection.Name = "ButtonItemInvertSelection";
            this.ButtonItemInvertSelection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnInvertSelectionItemClick);
            // 
            // ButtonItemPropertiesFolder
            // 
            this.ButtonItemPropertiesFolder.Caption = "Properties";
            this.ButtonItemPropertiesFolder.Id = 97;
            this.ButtonItemPropertiesFolder.Name = "ButtonItemPropertiesFolder";
            this.ButtonItemPropertiesFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // ButtonItemRemoveProperties
            // 
            this.ButtonItemRemoveProperties.Caption = "Remove properties";
            this.ButtonItemRemoveProperties.Enabled = false;
            this.ButtonItemRemoveProperties.Id = 98;
            this.ButtonItemRemoveProperties.Name = "ButtonItemRemoveProperties";
            // 
            // ButtonItemDelete
            // 
            this.ButtonItemDelete.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ButtonItemDelete.Caption = "Delete";
            this.ButtonItemDelete.DropDownControl = this.PopupMenuDeleteButton;
            this.ButtonItemDelete.Id = 99;
            this.ButtonItemDelete.Name = "ButtonItemDelete";
            this.ButtonItemDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // PopupMenuDeleteButton
            // 
            this.PopupMenuDeleteButton.ItemLinks.Add(this.ButtonItemRecycle);
            this.PopupMenuDeleteButton.ItemLinks.Add(this.ButtonItemPermanentlyDelete);
            this.PopupMenuDeleteButton.ItemLinks.Add(this.ButtonItemShowRecycleConfirmation, true);
            this.PopupMenuDeleteButton.Name = "PopupMenuDeleteButton";
            this.PopupMenuDeleteButton.Ribbon = this.RibbonControl;
            // 
            // ButtonItemRecycle
            // 
            this.ButtonItemRecycle.Caption = "Recycle";
            this.ButtonItemRecycle.Id = 100;
            this.ButtonItemRecycle.Name = "ButtonItemRecycle";
            // 
            // ButtonItemPermanentlyDelete
            // 
            this.ButtonItemPermanentlyDelete.Caption = "Peramnently delete";
            this.ButtonItemPermanentlyDelete.Id = 101;
            this.ButtonItemPermanentlyDelete.Name = "ButtonItemPermanentlyDelete";
            // 
            // ButtonItemShowRecycleConfirmation
            // 
            this.ButtonItemShowRecycleConfirmation.Caption = "Show recycle confirmation";
            this.ButtonItemShowRecycleConfirmation.Id = 103;
            this.ButtonItemShowRecycleConfirmation.Name = "ButtonItemShowRecycleConfirmation";
            // 
            // ButtonItemProperties
            // 
            this.ButtonItemProperties.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ButtonItemProperties.Caption = "Properties";
            this.ButtonItemProperties.DropDownControl = this.PopupMenuPropertiesButton;
            this.ButtonItemProperties.Id = 104;
            this.ButtonItemProperties.Name = "ButtonItemProperties";
            this.ButtonItemProperties.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ButtonItemProperties.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // PopupMenuPropertiesButton
            // 
            this.PopupMenuPropertiesButton.ItemLinks.Add(this.ButtonItemPropertiesFolder);
            this.PopupMenuPropertiesButton.ItemLinks.Add(this.ButtonItemRemoveProperties, true);
            this.PopupMenuPropertiesButton.Name = "PopupMenuPropertiesButton";
            this.PopupMenuPropertiesButton.Ribbon = this.RibbonControl;
            // 
            // btnOpen
            // 
            this.btnOpen.Caption = "Open";
            this.btnOpen.Enabled = false;
            this.btnOpen.Id = 134;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOpenItemClick);
            // 
            // ButtonItemOptions
            // 
            this.ButtonItemOptions.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ButtonItemOptions.Caption = "Options";
            this.ButtonItemOptions.DropDownControl = this.PopupMenuOptionsButton;
            this.ButtonItemOptions.Id = 135;
            this.ButtonItemOptions.Name = "ButtonItemOptions";
            this.ButtonItemOptions.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ButtonItemOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // PopupMenuOptionsButton
            // 
            this.PopupMenuOptionsButton.ItemLinks.Add(this.ButtonItemChangeFilderOptions);
            this.PopupMenuOptionsButton.Name = "PopupMenuOptionsButton";
            this.PopupMenuOptionsButton.Ribbon = this.RibbonControl;
            // 
            // ButtonItemChangeFilderOptions
            // 
            this.ButtonItemChangeFilderOptions.Caption = "Change folder and search options";
            this.ButtonItemChangeFilderOptions.Id = 136;
            this.ButtonItemChangeFilderOptions.Name = "ButtonItemChangeFilderOptions";
            this.ButtonItemChangeFilderOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // rgbiViewStyle
            // 
            this.rgbiViewStyle.Caption = "View";
            // 
            // 
            // 
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rgbiViewStyle.Gallery.ColumnCount = 3;
            this.rgbiViewStyle.Gallery.DrawImageBackground = false;
            galleryItemGroup1.Caption = "ViewStyleGroup";
            galleryItem1.Caption = "Extra large view";
            galleryItem1.Tag = 1;
            galleryItem2.Caption = "Large icons";
            galleryItem2.Checked = true;
            galleryItem2.Tag = 2;
            galleryItem3.Caption = "Medium icons";
            galleryItem3.Tag = 3;
            galleryItem4.Caption = "Small icons";
            galleryItem4.Tag = 4;
            galleryItem5.Caption = "List";
            galleryItem5.Tag = 6;
            galleryItem6.Caption = "Tiles";
            galleryItem6.Tag = 5;
            galleryItem7.Caption = "Content";
            galleryItem7.Tag = 7;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7});
            this.rgbiViewStyle.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.rgbiViewStyle.Gallery.ImageSize = new System.Drawing.Size(18, 18);
            this.rgbiViewStyle.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.rgbiViewStyle.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            skinPaddingEdges1.Bottom = -3;
            skinPaddingEdges1.Top = -3;
            this.rgbiViewStyle.Gallery.ItemImagePadding = skinPaddingEdges1;
            skinPaddingEdges2.Bottom = -1;
            skinPaddingEdges2.Top = -1;
            this.rgbiViewStyle.Gallery.ItemTextPadding = skinPaddingEdges2;
            this.rgbiViewStyle.Gallery.ShowItemText = true;
            this.rgbiViewStyle.Id = 141;
            this.rgbiViewStyle.Name = "rgbiViewStyle";
            this.rgbiViewStyle.GalleryItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.OnViewStyleGalleryItemCheckedChanged);
            this.rgbiViewStyle.GalleryInitDropDownGallery += new DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(this.OnRgbiViewStyleInitDropDown);
            // 
            // ContextItemOpen
            // 
            this.ContextItemOpen.Caption = "Open";
            this.ContextItemOpen.Id = 151;
            this.ContextItemOpen.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ContextItemOpen.ItemAppearance.Disabled.Options.UseFont = true;
            this.ContextItemOpen.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ContextItemOpen.ItemAppearance.Hovered.Options.UseFont = true;
            this.ContextItemOpen.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ContextItemOpen.ItemAppearance.Normal.Options.UseFont = true;
            this.ContextItemOpen.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ContextItemOpen.ItemAppearance.Pressed.Options.UseFont = true;
            this.ContextItemOpen.Name = "ContextItemOpen";
            this.ContextItemOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOpenItemClick);
            // 
            // ContextItemCut
            // 
            this.ContextItemCut.Caption = "Cut";
            this.ContextItemCut.Id = 158;
            this.ContextItemCut.Name = "ContextItemCut";
            // 
            // ContextItemCopy
            // 
            this.ContextItemCopy.Caption = "Copy";
            this.ContextItemCopy.Id = 159;
            this.ContextItemCopy.Name = "ContextItemCopy";
            // 
            // ContextItemPaste
            // 
            this.ContextItemPaste.Caption = "Paste";
            this.ContextItemPaste.Id = 160;
            this.ContextItemPaste.Name = "ContextItemPaste";
            // 
            // ContextItemDelete
            // 
            this.ContextItemDelete.Caption = "Delete";
            this.ContextItemDelete.Id = 162;
            this.ContextItemDelete.Name = "ContextItemDelete";
            // 
            // ContextItemRename
            // 
            this.ContextItemRename.Caption = "Rename";
            this.ContextItemRename.Id = 163;
            this.ContextItemRename.Name = "ContextItemRename";
            // 
            // ContextItemProperties
            // 
            this.ContextItemProperties.Caption = "Properties";
            this.ContextItemProperties.Id = 164;
            this.ContextItemProperties.Name = "ContextItemProperties";
            this.ContextItemProperties.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // PageHome
            // 
            this.PageHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupClipboard,
            this.PageGroupOrganize,
            this.PageGroupNew,
            this.PageGroupOpen,
            this.PageGroupSelect});
            this.PageHome.Name = "PageHome";
            this.PageHome.Text = "Home";
            // 
            // PageGroupClipboard
            // 
            this.PageGroupClipboard.ItemLinks.Add(this.ButtonItemCopy);
            this.PageGroupClipboard.ItemLinks.Add(this.ButtonItemPaste);
            this.PageGroupClipboard.ItemLinks.Add(this.ButtonItemCut);
            this.PageGroupClipboard.ItemLinks.Add(this.btnCopyItem);
            this.PageGroupClipboard.Name = "PageGroupClipboard";
            this.PageGroupClipboard.ShowCaptionButton = false;
            this.PageGroupClipboard.Text = "Clipboard";
            // 
            // PageGroupOrganize
            // 
            this.PageGroupOrganize.ItemLinks.Add(this.ButtonItemMoveTo);
            this.PageGroupOrganize.ItemLinks.Add(this.ButtonItemCopyTo);
            this.PageGroupOrganize.ItemLinks.Add(this.ButtonItemDelete, true);
            this.PageGroupOrganize.ItemLinks.Add(this.ButtonItemRename);
            this.PageGroupOrganize.Name = "PageGroupOrganize";
            this.PageGroupOrganize.ShowCaptionButton = false;
            this.PageGroupOrganize.Text = "Organize";
            // 
            // PageGroupNew
            // 
            this.PageGroupNew.ItemLinks.Add(this.ButtonItemNewFolder);
            this.PageGroupNew.ItemLinks.Add(this.ButtonItemNewItem);
            this.PageGroupNew.Name = "PageGroupNew";
            this.PageGroupNew.ShowCaptionButton = false;
            this.PageGroupNew.Text = "New";
            // 
            // PageGroupOpen
            // 
            this.PageGroupOpen.ItemLinks.Add(this.ButtonItemProperties);
            this.PageGroupOpen.ItemLinks.Add(this.btnOpen);
            this.PageGroupOpen.ItemLinks.Add(this.ButtonItemEdit);
            this.PageGroupOpen.Name = "PageGroupOpen";
            this.PageGroupOpen.ShowCaptionButton = false;
            this.PageGroupOpen.Text = "Open";
            // 
            // PageGroupSelect
            // 
            this.PageGroupSelect.ItemLinks.Add(this.ButtonItemSelectAll);
            this.PageGroupSelect.ItemLinks.Add(this.btnSelectNone);
            this.PageGroupSelect.ItemLinks.Add(this.ButtonItemInvertSelection);
            this.PageGroupSelect.Name = "PageGroupSelect";
            this.PageGroupSelect.ShowCaptionButton = false;
            this.PageGroupSelect.Text = "Select";
            // 
            // PageView
            // 
            this.PageView.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupViewPanes,
            this.PageGroupViewLayouts,
            this.PageGroupViewShowHide,
            this.PageGroupViewEmpty});
            this.PageView.Name = "PageView";
            this.PageView.Text = "View";
            // 
            // PageGroupViewPanes
            // 
            this.PageGroupViewPanes.ItemLinks.Add(this.ButtonItemNavigationPane);
            this.PageGroupViewPanes.Name = "PageGroupViewPanes";
            this.PageGroupViewPanes.ShowCaptionButton = false;
            this.PageGroupViewPanes.Text = "Panes";
            // 
            // PageGroupViewLayouts
            // 
            this.PageGroupViewLayouts.ItemLinks.Add(this.rgbiViewStyle);
            this.PageGroupViewLayouts.Name = "PageGroupViewLayouts";
            this.PageGroupViewLayouts.ShowCaptionButton = false;
            this.PageGroupViewLayouts.Text = "Layouts";
            // 
            // PageGroupViewShowHide
            // 
            this.PageGroupViewShowHide.ItemLinks.Add(this.ButtonItemItemCheckBoxes);
            this.PageGroupViewShowHide.ItemLinks.Add(this.ButtonItemFileNameExtensions);
            this.PageGroupViewShowHide.ItemLinks.Add(this.ButtonItemHiddenItems);
            this.PageGroupViewShowHide.ItemLinks.Add(this.btnHideSelectedItems);
            this.PageGroupViewShowHide.Name = "PageGroupViewShowHide";
            this.PageGroupViewShowHide.ShowCaptionButton = false;
            this.PageGroupViewShowHide.Text = "Show/Hide";
            // 
            // PageGroupViewEmpty
            // 
            this.PageGroupViewEmpty.ItemLinks.Add(this.ButtonItemOptions);
            this.PageGroupViewEmpty.Name = "PageGroupViewEmpty";
            this.PageGroupViewEmpty.ShowCaptionButton = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // navBar
            // 
            this.navBar.ActiveGroup = this.groupFavorites;
            this.navBar.Appearance.GroupHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBar.Appearance.GroupHeader.Options.UseFont = true;
            this.navBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.navBar.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBar.ExplorerBarGroupOuterIndent = 10;
            this.navBar.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.groupFavorites,
            this.groupLibraries});
            this.navBar.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navPanelItemDesktop,
            this.navPanelItemDownloads,
            this.navPanelItemRecent,
            this.navPanelItemDocuments,
            this.navPanelItemMusic,
            this.navPanelItemPictures,
            this.navPanelItemVideos});
            this.navBar.LinkInterval = 0;
            this.navBar.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.navBar.Location = new System.Drawing.Point(673, 287);
            this.navBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.navBar.Name = "navBar";
            this.navBar.OptionsNavPane.ExpandedWidth = 537;
            this.navBar.Size = new System.Drawing.Size(537, 253);
            this.navBar.TabIndex = 1;
            this.navBar.Text = "navigationPanel";
            this.navBar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.OnNavPanelLinkClicked);
            // 
            // groupFavorites
            // 
            this.groupFavorites.Caption = "Favorites";
            this.groupFavorites.Expanded = true;
            this.groupFavorites.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemDesktop),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemDownloads),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemRecent)});
            this.groupFavorites.Name = "groupFavorites";
            // 
            // navPanelItemDesktop
            // 
            this.navPanelItemDesktop.Caption = "Desktop";
            this.navPanelItemDesktop.Name = "navPanelItemDesktop";
            // 
            // navPanelItemDownloads
            // 
            this.navPanelItemDownloads.Caption = "Downloads";
            this.navPanelItemDownloads.Name = "navPanelItemDownloads";
            // 
            // navPanelItemRecent
            // 
            this.navPanelItemRecent.Caption = "Recent places";
            this.navPanelItemRecent.Name = "navPanelItemRecent";
            // 
            // groupLibraries
            // 
            this.groupLibraries.Caption = "Libraries";
            this.groupLibraries.Expanded = true;
            this.groupLibraries.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemDocuments),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemMusic),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemPictures),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemVideos)});
            this.groupLibraries.Name = "groupLibraries";
            // 
            // navPanelItemDocuments
            // 
            this.navPanelItemDocuments.Caption = "Documents";
            this.navPanelItemDocuments.Name = "navPanelItemDocuments";
            // 
            // navPanelItemMusic
            // 
            this.navPanelItemMusic.Caption = "Music";
            this.navPanelItemMusic.Name = "navPanelItemMusic";
            // 
            // navPanelItemPictures
            // 
            this.navPanelItemPictures.Caption = "Pictures";
            this.navPanelItemPictures.Name = "navPanelItemPictures";
            // 
            // navPanelItemVideos
            // 
            this.navPanelItemVideos.Caption = "Videos";
            this.navPanelItemVideos.Name = "navPanelItemVideos";
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.btnNavigationHistory);
            this.navigationPanel.Controls.Add(this.btnUpTo);
            this.navigationPanel.Controls.Add(this.btnForward);
            this.navigationPanel.Controls.Add(this.btnBack);
            this.navigationPanel.Controls.Add(this.EditSearch);
            this.navigationPanel.Controls.Add(this.editBreadCrumb);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 143);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1206, 37);
            this.navigationPanel.TabIndex = 3;
            // 
            // btnNavigationHistory
            // 
            this.btnNavigationHistory.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnNavigationHistory.Appearance.ImageIndex = 2;
            this.btnNavigationHistory.Appearance.ImageList = this.imgs;
            this.btnNavigationHistory.Appearance.Options.UseImageIndex = true;
            this.btnNavigationHistory.Appearance.Options.UseImageList = true;
            this.btnNavigationHistory.AppearanceHovered.ImageIndex = 1;
            this.btnNavigationHistory.AppearanceHovered.Options.UseImageIndex = true;
            this.btnNavigationHistory.AppearancePressed.ImageIndex = 3;
            this.btnNavigationHistory.AppearancePressed.Options.UseImageIndex = true;
            this.btnNavigationHistory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnNavigationHistory.Location = new System.Drawing.Point(60, 8);
            this.btnNavigationHistory.Name = "btnNavigationHistory";
            this.btnNavigationHistory.Size = new System.Drawing.Size(16, 18);
            this.btnNavigationHistory.TabIndex = 8;
            this.btnNavigationHistory.Click += new System.EventHandler(this.OnNavigationMenuButtonClick);
            // 
            // btnUpTo
            // 
            this.btnUpTo.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnUpTo.Appearance.ImageIndex = 5;
            this.btnUpTo.Appearance.ImageList = this.imgArrows;
            this.btnUpTo.Appearance.Options.UseImageIndex = true;
            this.btnUpTo.Appearance.Options.UseImageList = true;
            this.btnUpTo.AppearanceHovered.ImageIndex = 2;
            this.btnUpTo.AppearanceHovered.Options.UseImageIndex = true;
            this.btnUpTo.AppearancePressed.ImageIndex = 8;
            this.btnUpTo.AppearancePressed.Options.UseImageIndex = true;
            this.btnUpTo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnUpTo.Location = new System.Drawing.Point(76, 5);
            this.btnUpTo.Name = "btnUpTo";
            this.btnUpTo.Size = new System.Drawing.Size(24, 24);
            this.btnUpTo.TabIndex = 7;
            this.btnUpTo.Click += new System.EventHandler(this.OnUpButtonClick);
            // 
            // imgArrows
            // 
            this.imgArrows.ImageSize = new System.Drawing.Size(24, 24);
            this.imgArrows.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgArrows.ImageStream")));
            this.imgArrows.Images.SetKeyName(0, "hoverBack.png");
            this.imgArrows.Images.SetKeyName(1, "hoverNext.png");
            this.imgArrows.Images.SetKeyName(2, "hoverUp.png");
            this.imgArrows.Images.SetKeyName(3, "normalBack.png");
            this.imgArrows.Images.SetKeyName(4, "normalNext.png");
            this.imgArrows.Images.SetKeyName(5, "normalUp.png");
            this.imgArrows.Images.SetKeyName(6, "pressedBack.png");
            this.imgArrows.Images.SetKeyName(7, "pressedNext.png");
            this.imgArrows.Images.SetKeyName(8, "pressedUp.png");
            // 
            // btnForward
            // 
            this.btnForward.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnForward.Appearance.ImageIndex = 4;
            this.btnForward.Appearance.ImageList = this.imgArrows;
            this.btnForward.Appearance.Options.UseImageIndex = true;
            this.btnForward.Appearance.Options.UseImageList = true;
            this.btnForward.AppearanceHovered.ImageIndex = 1;
            this.btnForward.AppearanceHovered.Options.UseImageIndex = true;
            this.btnForward.AppearancePressed.ImageIndex = 7;
            this.btnForward.AppearancePressed.Options.UseImageIndex = true;
            this.btnForward.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnForward.Location = new System.Drawing.Point(36, 8);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(18, 18);
            this.btnForward.TabIndex = 6;
            this.btnForward.Click += new System.EventHandler(this.OnNextButtonClick);
            // 
            // btnBack
            // 
            this.btnBack.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnBack.Appearance.ImageIndex = 3;
            this.btnBack.Appearance.ImageList = this.imgArrows;
            this.btnBack.Appearance.Options.UseImageIndex = true;
            this.btnBack.Appearance.Options.UseImageList = true;
            this.btnBack.AppearanceHovered.ImageIndex = 0;
            this.btnBack.AppearanceHovered.Options.UseImageIndex = true;
            this.btnBack.AppearancePressed.ImageIndex = 6;
            this.btnBack.AppearancePressed.Options.UseImageIndex = true;
            this.btnBack.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnBack.Location = new System.Drawing.Point(7, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(18, 18);
            this.btnBack.TabIndex = 5;
            this.btnBack.Click += new System.EventHandler(this.OnBackButtonClick);
            // 
            // EditSearch
            // 
            this.EditSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditSearch.Location = new System.Drawing.Point(931, 5);
            this.EditSearch.MenuManager = this.RibbonControl;
            this.EditSearch.Name = "EditSearch";
            this.EditSearch.Properties.AutoHeight = false;
            this.EditSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("EditSearch.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.EditSearch.Size = new System.Drawing.Size(263, 24);
            this.EditSearch.TabIndex = 4;
            this.EditSearch.TextChanged += new System.EventHandler(this.OnEditSearchTextChanged);
            // 
            // editBreadCrumb
            // 
            this.editBreadCrumb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editBreadCrumb.Location = new System.Drawing.Point(106, 5);
            this.editBreadCrumb.MenuManager = this.RibbonControl;
            this.editBreadCrumb.Name = "editBreadCrumb";
            this.editBreadCrumb.Properties.AutoHeight = false;
            this.editBreadCrumb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, "", 18, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", 15, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.editBreadCrumb.Properties.DropDownRows = 12;
            this.editBreadCrumb.Properties.ImageIndex = 0;
            this.editBreadCrumb.Properties.Images = this.imgs;
            breadCrumbNode1.Caption = "Root";
            breadCrumbNode1.Persistent = true;
            breadCrumbNode1.PopulateOnDemand = true;
            breadCrumbNode1.ShowCaption = false;
            breadCrumbNode1.Value = "Root";
            breadCrumbNode2.Caption = "Computer";
            breadCrumbNode2.Persistent = true;
            breadCrumbNode2.PopulateOnDemand = true;
            breadCrumbNode2.Value = "Computer";
            this.editBreadCrumb.Properties.Nodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode1,
            breadCrumbNode2});
            this.editBreadCrumb.Properties.RootImageIndex = 0;
            this.editBreadCrumb.Properties.SortNodesByCaption = true;
            this.editBreadCrumb.Properties.RootGlyphClick += new System.EventHandler(this.OnBreadCrumbRootGlyphClick);
            this.editBreadCrumb.Properties.QueryChildNodes += new DevExpress.XtraEditors.BreadCrumbQueryChildNodesEventHandler(this.OnBreadCrumbQueryChildNodes);
            this.editBreadCrumb.Properties.ValidatePath += new DevExpress.XtraEditors.BreadCrumbValidatePathEventHandler(this.OnBreadCrumbValidatePath);
            this.editBreadCrumb.Properties.NewNodeAdding += new DevExpress.XtraEditors.BreadCrumbNewNodeAddingEventHandler(this.OnBreadCrumbNewNodeAdding);
            this.editBreadCrumb.Size = new System.Drawing.Size(818, 24);
            this.editBreadCrumb.TabIndex = 3;
            this.editBreadCrumb.PathChanged += new DevExpress.XtraEditors.BreadCrumbPathChangedEventHandler(this.OnBreadCrumbPathChanged);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.LayoutControl);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 180);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1206, 540);
            this.contentPanel.TabIndex = 5;
            // 
            // LayoutControl
            // 
            this.LayoutControl.Controls.Add(this.panelControl2);
            this.LayoutControl.Controls.Add(this.panelControl1);
            this.LayoutControl.Controls.Add(this.lueSizeMode);
            this.LayoutControl.Controls.Add(this.btnCropImage);
            this.LayoutControl.Controls.Add(this.btnPrint);
            this.LayoutControl.Controls.Add(this.btnXoayNgang);
            this.LayoutControl.Controls.Add(this.btnXoayTrai);
            this.LayoutControl.Controls.Add(this.btnXoayDoc);
            this.LayoutControl.Controls.Add(this.btnXoayPhai);
            this.LayoutControl.Controls.Add(this.gridControl);
            this.LayoutControl.Controls.Add(this.navBar);
            this.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.liNavPaneRight,
            this.layoutControlItem8});
            this.LayoutControl.Location = new System.Drawing.Point(2, 2);
            this.LayoutControl.Name = "LayoutControl";
            this.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(718, 205, 513, 549);
            this.LayoutControl.Root = this.LayoutControlMainGroup;
            this.LayoutControl.Size = new System.Drawing.Size(1202, 536);
            this.LayoutControl.TabIndex = 3;
            this.LayoutControl.Text = "LayoutControl";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureEdit2);
            this.panelControl2.Location = new System.Drawing.Point(465, 223);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(322, 311);
            this.panelControl2.TabIndex = 11;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.Location = new System.Drawing.Point(8, 5);
            this.pictureEdit2.MaximumSize = new System.Drawing.Size(300, 300);
            this.pictureEdit2.MinimumSize = new System.Drawing.Size(300, 300);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowScrollViaMouseDrag = true;
            this.pictureEdit2.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 20D;
            this.pictureEdit2.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
            this.pictureEdit2.Size = new System.Drawing.Size(300, 300);
            this.pictureEdit2.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Location = new System.Drawing.Point(2, 223);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(318, 311);
            this.panelControl1.TabIndex = 10;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Location = new System.Drawing.Point(5, 6);
            this.pictureEdit1.MaximumSize = new System.Drawing.Size(300, 300);
            this.pictureEdit1.MenuManager = this.RibbonControl;
            this.pictureEdit1.MinimumSize = new System.Drawing.Size(300, 300);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowScrollViaMouseDrag = true;
            this.pictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 20D;
            this.pictureEdit1.Size = new System.Drawing.Size(300, 300);
            this.pictureEdit1.TabIndex = 4;
            this.pictureEdit1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureEdit1_Paint);
            this.pictureEdit1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureEdit1_MouseDown);
            this.pictureEdit1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureEdit1_MouseMove);
            this.pictureEdit1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureEdit1_MouseUp);
            // 
            // lueSizeMode
            // 
            this.lueSizeMode.Location = new System.Drawing.Point(925, 414);
            this.lueSizeMode.MenuManager = this.RibbonControl;
            this.lueSizeMode.Name = "lueSizeMode";
            this.lueSizeMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSizeMode.Properties.NullText = "";
            this.lueSizeMode.Size = new System.Drawing.Size(263, 20);
            this.lueSizeMode.StyleController = this.LayoutControl;
            this.lueSizeMode.TabIndex = 9;
            this.lueSizeMode.EditValueChanged += new System.EventHandler(this.lueSizeMode_EditValueChanged);
            // 
            // btnCropImage
            // 
            this.btnCropImage.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnCropImage.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnCropImage.Appearance.Options.UseFont = true;
            this.btnCropImage.Appearance.Options.UseForeColor = true;
            this.btnCropImage.Location = new System.Drawing.Point(336, 373);
            this.btnCropImage.Name = "btnCropImage";
            this.btnCropImage.Size = new System.Drawing.Size(113, 31);
            this.btnCropImage.StyleController = this.LayoutControl;
            this.btnCropImage.TabIndex = 8;
            this.btnCropImage.Text = "Crop Image";
            this.btnCropImage.Click += new System.EventHandler(this.btnCropImage_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Location = new System.Drawing.Point(791, 223);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(409, 31);
            this.btnPrint.StyleController = this.LayoutControl;
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnXoayNgang
            // 
            this.btnXoayNgang.Location = new System.Drawing.Point(336, 253);
            this.btnXoayNgang.Name = "btnXoayNgang";
            this.btnXoayNgang.Size = new System.Drawing.Size(113, 22);
            this.btnXoayNgang.StyleController = this.LayoutControl;
            this.btnXoayNgang.TabIndex = 8;
            this.btnXoayNgang.Text = "Xoay ngang";
            this.btnXoayNgang.Click += new System.EventHandler(this.btnXoayNgang_Click);
            // 
            // btnXoayTrai
            // 
            this.btnXoayTrai.Location = new System.Drawing.Point(336, 279);
            this.btnXoayTrai.Name = "btnXoayTrai";
            this.btnXoayTrai.Size = new System.Drawing.Size(52, 22);
            this.btnXoayTrai.StyleController = this.LayoutControl;
            this.btnXoayTrai.TabIndex = 7;
            this.btnXoayTrai.Text = "Xoay trái";
            this.btnXoayTrai.Click += new System.EventHandler(this.btnXoayTrai_Click);
            // 
            // btnXoayDoc
            // 
            this.btnXoayDoc.Location = new System.Drawing.Point(336, 305);
            this.btnXoayDoc.Name = "btnXoayDoc";
            this.btnXoayDoc.Size = new System.Drawing.Size(113, 22);
            this.btnXoayDoc.StyleController = this.LayoutControl;
            this.btnXoayDoc.TabIndex = 6;
            this.btnXoayDoc.Text = "Xoay dọc";
            this.btnXoayDoc.Click += new System.EventHandler(this.btnXoayDoc_Click);
            // 
            // btnXoayPhai
            // 
            this.btnXoayPhai.Location = new System.Drawing.Point(392, 279);
            this.btnXoayPhai.Name = "btnXoayPhai";
            this.btnXoayPhai.Size = new System.Drawing.Size(57, 22);
            this.btnXoayPhai.StyleController = this.LayoutControl;
            this.btnXoayPhai.TabIndex = 5;
            this.btnXoayPhai.Text = "Xoay phải";
            this.btnXoayPhai.Click += new System.EventHandler(this.btnXoayPhai_Click);
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.winExplorerView;
            this.gridControl.MenuManager = this.RibbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1198, 217);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView});
            this.gridControl.DataSourceChanged += new System.EventHandler(this.gridControl_DataSourceChanged);
            // 
            // winExplorerView
            // 
            this.winExplorerView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.winExplorerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnName,
            this.columnPath,
            this.columnCheck,
            this.columnGroup,
            this.columnImage});
            this.winExplorerView.ColumnSet.CheckBoxColumn = this.columnCheck;
            this.winExplorerView.ColumnSet.DescriptionColumn = this.columnPath;
            this.winExplorerView.ColumnSet.ExtraLargeImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.GroupColumn = this.columnGroup;
            this.winExplorerView.ColumnSet.LargeImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.MediumImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.SmallImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.TextColumn = this.columnName;
            this.winExplorerView.GridControl = this.gridControl;
            this.winExplorerView.GroupCount = 1;
            this.winExplorerView.Name = "winExplorerView";
            this.winExplorerView.OptionsBehavior.Editable = false;
            this.winExplorerView.OptionsSelection.AllowMarqueeSelection = true;
            this.winExplorerView.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Click;
            this.winExplorerView.OptionsSelection.MultiSelect = true;
            this.winExplorerView.OptionsView.ImageLayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.winExplorerView.OptionsView.ShowViewCaption = true;
            this.winExplorerView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.columnGroup, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.winExplorerView.ItemClick += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemClickEventHandler(this.OnWinExplorerViewItemClick);
            this.winExplorerView.ItemDoubleClick += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventHandler(this.OnWinExplorerViewItemDoubleClick);
            this.winExplorerView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.OnWinExplorerViewSelectionChanged);
            this.winExplorerView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnWinExplorerViewKeyDown);
            // 
            // columnName
            // 
            this.columnName.Caption = "columnName";
            this.columnName.FieldName = "Name";
            this.columnName.Name = "columnName";
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 0;
            // 
            // columnPath
            // 
            this.columnPath.Caption = "columnPath";
            this.columnPath.FieldName = "Path";
            this.columnPath.Name = "columnPath";
            this.columnPath.Visible = true;
            this.columnPath.VisibleIndex = 0;
            // 
            // columnCheck
            // 
            this.columnCheck.Caption = "columnCheck";
            this.columnCheck.FieldName = "IsCheck";
            this.columnCheck.Name = "columnCheck";
            this.columnCheck.Visible = true;
            this.columnCheck.VisibleIndex = 0;
            // 
            // columnGroup
            // 
            this.columnGroup.Caption = "columnGroup";
            this.columnGroup.FieldName = "Group";
            this.columnGroup.Name = "columnGroup";
            this.columnGroup.Visible = true;
            this.columnGroup.VisibleIndex = 0;
            // 
            // columnImage
            // 
            this.columnImage.Caption = "columnImage";
            this.columnImage.FieldName = "Image";
            this.columnImage.Name = "columnImage";
            this.columnImage.Visible = true;
            this.columnImage.VisibleIndex = 0;
            // 
            // liNavPaneRight
            // 
            this.liNavPaneRight.Control = this.navBar;
            this.liNavPaneRight.CustomizationFormText = "LayoutControlItemNavigationPaneRight";
            this.liNavPaneRight.Location = new System.Drawing.Point(671, 285);
            this.liNavPaneRight.Name = "LayoutControlItemNavigationPaneRight";
            this.liNavPaneRight.Size = new System.Drawing.Size(541, 257);
            this.liNavPaneRight.TextSize = new System.Drawing.Size(0, 0);
            this.liNavPaneRight.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lueSizeMode;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(363, 24);
            this.layoutControlItem8.Text = "Loại hiển thị";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(93, 13);
            // 
            // LayoutControlMainGroup
            // 
            this.LayoutControlMainGroup.CustomizationFormText = "Root";
            this.LayoutControlMainGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.LayoutControlMainGroup.GroupBordersVisible = false;
            this.LayoutControlMainGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItemExplorerView,
            this.layoutControlGroup1,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem1,
            this.layoutControlGroup2,
            this.lblCounter});
            this.LayoutControlMainGroup.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlMainGroup.Name = "Root";
            this.LayoutControlMainGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 10, 10, 10);
            this.LayoutControlMainGroup.Size = new System.Drawing.Size(1202, 536);
            this.LayoutControlMainGroup.TextVisible = false;
            // 
            // LayoutControlItemExplorerView
            // 
            this.LayoutControlItemExplorerView.Control = this.gridControl;
            this.LayoutControlItemExplorerView.CustomizationFormText = "LayoutControlItemExplorerView";
            this.LayoutControlItemExplorerView.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItemExplorerView.MinSize = new System.Drawing.Size(104, 24);
            this.LayoutControlItemExplorerView.Name = "LayoutControlItemExplorerView";
            this.LayoutControlItemExplorerView.Size = new System.Drawing.Size(1202, 221);
            this.LayoutControlItemExplorerView.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.LayoutControlItemExplorerView.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItemExplorerView.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(322, 221);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(141, 120);
            this.layoutControlGroup1.Text = "Điều chỉnh";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnXoayDoc;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(117, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(117, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(117, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnXoayTrai;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(56, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(56, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(56, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnXoayNgang;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(117, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(117, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(117, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnXoayPhai;
            this.layoutControlItem2.Location = new System.Drawing.Point(56, 26);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(61, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(61, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(61, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(789, 293);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(413, 243);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnPrint;
            this.layoutControlItem6.Location = new System.Drawing.Point(789, 221);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(413, 35);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.panelControl1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 221);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(322, 315);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(322, 315);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(322, 315);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(463, 221);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(326, 315);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(326, 315);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(326, 315);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(322, 341);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(141, 195);
            this.layoutControlGroup2.Text = "Thao tác";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnCropImage;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(117, 153);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // lblCounter
            // 
            this.lblCounter.AllowHotTrack = false;
            this.lblCounter.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblCounter.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.lblCounter.AppearanceItemCaption.Options.UseFont = true;
            this.lblCounter.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblCounter.Location = new System.Drawing.Point(789, 256);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(413, 37);
            this.lblCounter.Text = "...";
            this.lblCounter.TextSize = new System.Drawing.Size(24, 33);
            // 
            // itemPopupMenu
            // 
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemOpen);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemCut, true);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemCopy);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemPaste);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemDelete);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemRename);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemProperties, true);
            this.itemPopupMenu.Name = "itemPopupMenu";
            this.itemPopupMenu.Ribbon = this.RibbonControl;
            // 
            // navigationMenu
            // 
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.Ribbon = this.RibbonControl;
            // 
            // ExplorerView
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1206, 720);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.RibbonControl);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ExplorerView";
            this.Ribbon = this.RibbonControl;
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuDeleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuPropertiesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuOptionsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanel)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgArrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBreadCrumb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl)).EndInit();
            this.LayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSizeMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liNavPaneRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlMainGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItemExplorerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageHome;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageView;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupViewPanes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupViewLayouts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupViewShowHide;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupViewEmpty;
        private DevExpress.XtraBars.BarButtonItem ButtonItemHelp;
        private DevExpress.XtraBars.BarSubItem ButtonItemNavigationPane;
        private DevExpress.XtraBars.BarCheckItem ButtonItemItemCheckBoxes;
        private DevExpress.XtraBars.BarCheckItem ButtonItemFileNameExtensions;
        private DevExpress.XtraBars.BarCheckItem ButtonItemHiddenItems;
        private DevExpress.XtraBars.BarButtonItem btnHideSelectedItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraNavBar.NavBarControl navBar;
        private DevExpress.XtraNavBar.NavBarGroup groupFavorites;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemDesktop;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemDownloads;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemRecent;
        private DevExpress.XtraBars.BarCheckItem ButtonCheckItemNavigationPane;
        private DevExpress.XtraBars.BarButtonItem ButtonItemCopy;
        private DevExpress.XtraBars.BarButtonItem ButtonItemPaste;
        private DevExpress.XtraBars.BarButtonItem ButtonItemCut;
        private DevExpress.XtraBars.BarButtonItem btnCopyItem;
        private DevExpress.XtraBars.BarSubItem ButtonItemMoveTo;
        private DevExpress.XtraBars.BarSubItem ButtonItemCopyTo;
        private DevExpress.XtraBars.BarButtonItem ButtonItemRename;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewFolder;
        private DevExpress.XtraBars.BarSubItem ButtonItemNewItem;
        private DevExpress.XtraBars.BarButtonItem ButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem ButtonItemSelectAll;
        private DevExpress.XtraBars.BarButtonItem btnSelectNone;
        private DevExpress.XtraBars.BarButtonItem ButtonItemInvertSelection;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupClipboard;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupOrganize;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupNew;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupOpen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupSelect;
        private DevExpress.XtraEditors.PanelControl navigationPanel;
        private DevExpress.XtraEditors.PanelControl contentPanel;
        private DevExpress.XtraNavBar.NavBarGroup groupLibraries;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemDocuments;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemMusic;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemPictures;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemVideos;
        private DevExpress.XtraBars.BarButtonItem ButtonItemPropertiesFolder;
        private DevExpress.XtraBars.BarButtonItem ButtonItemRemoveProperties;
        private DevExpress.XtraBars.BarButtonItem ButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem ButtonItemPermanentlyDelete;
        private DevExpress.XtraBars.PopupMenu PopupMenuDeleteButton;
        private DevExpress.XtraBars.BarButtonItem ButtonItemRecycle;
        private DevExpress.XtraBars.BarCheckItem ButtonItemShowRecycleConfirmation;
        private DevExpress.XtraBars.BarButtonItem ButtonItemProperties;
        private DevExpress.XtraBars.PopupMenu PopupMenuPropertiesButton;
        private DevExpress.XtraBars.BarButtonItem ButtonItemDocuments;
        private DevExpress.XtraBars.BarButtonItem ButtonItemMusic;
        private DevExpress.XtraBars.BarButtonItem ButtonItemVideos;
        private DevExpress.XtraBars.BarButtonItem ButtonItemPictures;
        private DevExpress.XtraBars.BarButtonItem ButtonItemChooseLocation;
        private DevExpress.XtraBars.BarCheckItem ButtonCheckItemShowFavorites;
        private DevExpress.XtraBars.BarCheckItem ButtonCheckItemShowLibraries;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewShortcut;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewBitmapImage;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewContact;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewJournalDocument;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewRichTextDocument;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewTextDocument;
        private DevExpress.XtraBars.BarButtonItem ButtonItemCompressedFolder;
        private ButtonEdit EditSearch;
        private BreadCrumbEdit editBreadCrumb;
        private DevExpress.XtraBars.BarButtonItem btnOpen;
        private DevExpress.XtraBars.BarButtonItem ButtonItemOptions;
        private DevExpress.XtraBars.BarButtonItem ButtonItemChangeFilderOptions;
        private DevExpress.XtraBars.PopupMenu PopupMenuOptionsButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiViewStyle;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private LabelControl btnBack;
        private LabelControl btnForward;
        private LabelControl btnUpTo;
        private DevExpress.XtraLayout.LayoutControl LayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup LayoutControlMainGroup;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlItemExplorerView;
        private DevExpress.XtraLayout.LayoutControlItem liNavPaneRight;
        private DevExpress.XtraBars.BarButtonItem ContextItemOpen;
        private DevExpress.XtraBars.BarButtonItem ContextItemCut;
        private DevExpress.XtraBars.BarButtonItem ContextItemCopy;
        private DevExpress.XtraBars.BarButtonItem ContextItemPaste;
        private DevExpress.XtraBars.BarButtonItem ContextItemDelete;
        private DevExpress.XtraBars.BarButtonItem ContextItemRename;
        private DevExpress.XtraBars.BarButtonItem ContextItemProperties;
        private ImageCollection imgArrows;
        private ImageCollection imgs;
        private GridColumn columnName;
        private GridColumn columnPath;
        private GridColumn columnCheck;
        private GridColumn columnGroup;
        private GridColumn columnImage;
        private PopupMenu itemPopupMenu;
        private LabelControl btnNavigationHistory;
        private PopupMenu navigationMenu;
        private PictureEdit pictureEdit1;
        private SimpleButton btnXoayNgang;
        private SimpleButton btnXoayTrai;
        private SimpleButton btnXoayDoc;
        private SimpleButton btnXoayPhai;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private SimpleButton btnCropImage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private LookUpEdit lueSizeMode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private PictureEdit pictureEdit2;
        private PanelControl panelControl2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.SimpleLabelItem lblCounter;
    }
}

