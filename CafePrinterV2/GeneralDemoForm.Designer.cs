using System.Windows.Forms;

namespace CafePrinterV2
{
  partial class GeneralDemoForm
  {
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
      if (disposing)
      {
        if (_previewImage != null)
          _previewImage.Dispose();

        if (components != null)
          components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralDemoForm));
            this.selectionSplitContainer = new System.Windows.Forms.SplitContainer();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnRotateVertical = new System.Windows.Forms.Button();
            this.btnRotateHorizontal = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.imageBox = new Cyotek.Windows.Forms.ImageBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.previewImageBox = new Cyotek.Windows.Forms.ImageBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.cursorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.autoScrollPositionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageSizeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openFromFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.showImageRegionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.showSourceImageRegionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.actualSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.selectNoneToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomLevelsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CropToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RotateLeftToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RotateRightToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RotateHorizontalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RotateVerticalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitCursorLocationToBoundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.selectionSplitContainer)).BeginInit();
            this.selectionSplitContainer.Panel1.SuspendLayout();
            this.selectionSplitContainer.Panel2.SuspendLayout();
            this.selectionSplitContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionSplitContainer
            // 
            this.selectionSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectionSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.selectionSplitContainer.Location = new System.Drawing.Point(0, 56);
            this.selectionSplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.selectionSplitContainer.Name = "selectionSplitContainer";
            // 
            // selectionSplitContainer.Panel1
            // 
            this.selectionSplitContainer.Panel1.Controls.Add(this.btnCrop);
            this.selectionSplitContainer.Panel1.Controls.Add(this.btnRotateVertical);
            this.selectionSplitContainer.Panel1.Controls.Add(this.btnRotateHorizontal);
            this.selectionSplitContainer.Panel1.Controls.Add(this.btnRotateRight);
            this.selectionSplitContainer.Panel1.Controls.Add(this.btnRotateLeft);
            this.selectionSplitContainer.Panel1.Controls.Add(this.propertyGrid);
            this.selectionSplitContainer.Panel1.Controls.Add(this.imageBox);
            // 
            // selectionSplitContainer.Panel2
            // 
            this.selectionSplitContainer.Panel2.Controls.Add(this.btnPreview);
            this.selectionSplitContainer.Panel2.Controls.Add(this.btnPrint);
            this.selectionSplitContainer.Panel2.Controls.Add(this.previewImageBox);
            this.selectionSplitContainer.Size = new System.Drawing.Size(1355, 831);
            this.selectionSplitContainer.SplitterDistance = 524;
            this.selectionSplitContainer.SplitterWidth = 5;
            this.selectionSplitContainer.TabIndex = 1;
            // 
            // btnCrop
            // 
            this.btnCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrop.ForeColor = System.Drawing.Color.Red;
            this.btnCrop.Location = new System.Drawing.Point(412, 560);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(109, 34);
            this.btnCrop.TabIndex = 1;
            this.btnCrop.Text = "Crop ảnh";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnRotateVertical
            // 
            this.btnRotateVertical.Location = new System.Drawing.Point(312, 560);
            this.btnRotateVertical.Name = "btnRotateVertical";
            this.btnRotateVertical.Size = new System.Drawing.Size(94, 34);
            this.btnRotateVertical.TabIndex = 1;
            this.btnRotateVertical.Text = "Xoay dọc";
            this.btnRotateVertical.UseVisualStyleBackColor = true;
            this.btnRotateVertical.Click += new System.EventHandler(this.btnRotateVertical_Click);
            // 
            // btnRotateHorizontal
            // 
            this.btnRotateHorizontal.Location = new System.Drawing.Point(212, 560);
            this.btnRotateHorizontal.Name = "btnRotateHorizontal";
            this.btnRotateHorizontal.Size = new System.Drawing.Size(94, 34);
            this.btnRotateHorizontal.TabIndex = 1;
            this.btnRotateHorizontal.Text = "Xoay ngang";
            this.btnRotateHorizontal.UseVisualStyleBackColor = true;
            this.btnRotateHorizontal.Click += new System.EventHandler(this.btnRotateHorizontal_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Location = new System.Drawing.Point(112, 560);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(94, 34);
            this.btnRotateRight.TabIndex = 1;
            this.btnRotateRight.Text = "Xoay phải";
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Location = new System.Drawing.Point(12, 560);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(94, 34);
            this.btnRotateLeft.TabIndex = 1;
            this.btnRotateLeft.Text = "Xoay trái";
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // propertyGrid
            // 
            this.propertyGrid.CommandsVisibleIfAvailable = false;
            this.propertyGrid.HelpVisible = false;
            this.propertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid.Location = new System.Drawing.Point(4, 749);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.imageBox;
            this.propertyGrid.Size = new System.Drawing.Size(359, 72);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.Visible = false;
            // 
            // imageBox
            // 
            this.imageBox.AlwaysShowHScroll = true;
            this.imageBox.AlwaysShowVScroll = true;
            this.imageBox.ImageBorderColor = System.Drawing.Color.Empty;
            this.imageBox.Location = new System.Drawing.Point(4, 4);
            this.imageBox.Margin = new System.Windows.Forms.Padding(0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(599, 553);
            this.imageBox.TabIndex = 0;
            this.imageBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imageBox.Selected += new System.EventHandler<System.EventArgs>(this.imageBox_Selected);
            this.imageBox.SelectionRegionChanged += new System.EventHandler(this.imageBox_SelectionRegionChanged);
            this.imageBox.ZoomChanged += new System.EventHandler(this.imageBox_ZoomChanged);
            this.imageBox.Zoomed += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxZoomEventArgs>(this.imageBox_Zoomed);
            this.imageBox.ZoomLevelsChanged += new System.EventHandler(this.imageBox_ZoomLevelsChanged);
            this.imageBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.imageBox_Scroll);
            this.imageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
            this.imageBox.MouseLeave += new System.EventHandler(this.imageBox_MouseLeave);
            this.imageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseMove);
            this.imageBox.Resize += new System.EventHandler(this.imageBox_Resize);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.Red;
            this.btnPreview.Location = new System.Drawing.Point(379, 560);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(109, 34);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Visible = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Red;
            this.btnPrint.Location = new System.Drawing.Point(494, 560);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 34);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "In ảnh";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // previewImageBox
            // 
            this.previewImageBox.AllowZoom = false;
            this.previewImageBox.AlwaysShowHScroll = true;
            this.previewImageBox.AlwaysShowVScroll = true;
            this.previewImageBox.GridDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.Image;
            this.previewImageBox.Location = new System.Drawing.Point(4, 4);
            this.previewImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(599, 553);
            this.previewImageBox.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursorToolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.autoScrollPositionToolStripStatusLabel,
            this.imageSizeToolStripStatusLabel,
            this.zoomToolStripStatusLabel,
            this.selectionToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 887);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(1355, 25);
            this.statusStrip.TabIndex = 1;
            // 
            // cursorToolStripStatusLabel
            // 
            this.cursorToolStripStatusLabel.Image = global::CafePrinterV2.Properties.Resources.Cursor;
            this.cursorToolStripStatusLabel.Name = "cursorToolStripStatusLabel";
            this.cursorToolStripStatusLabel.Size = new System.Drawing.Size(20, 20);
            this.cursorToolStripStatusLabel.ToolTipText = "Current Cursor Position";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1235, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // autoScrollPositionToolStripStatusLabel
            // 
            this.autoScrollPositionToolStripStatusLabel.Image = global::CafePrinterV2.Properties.Resources.Position;
            this.autoScrollPositionToolStripStatusLabel.Name = "autoScrollPositionToolStripStatusLabel";
            this.autoScrollPositionToolStripStatusLabel.Size = new System.Drawing.Size(20, 20);
            this.autoScrollPositionToolStripStatusLabel.ToolTipText = "Auto Scroll Position";
            // 
            // imageSizeToolStripStatusLabel
            // 
            this.imageSizeToolStripStatusLabel.Image = global::CafePrinterV2.Properties.Resources.Size;
            this.imageSizeToolStripStatusLabel.Name = "imageSizeToolStripStatusLabel";
            this.imageSizeToolStripStatusLabel.Size = new System.Drawing.Size(20, 20);
            this.imageSizeToolStripStatusLabel.ToolTipText = "Image Size";
            // 
            // zoomToolStripStatusLabel
            // 
            this.zoomToolStripStatusLabel.Image = global::CafePrinterV2.Properties.Resources.Zoom;
            this.zoomToolStripStatusLabel.Name = "zoomToolStripStatusLabel";
            this.zoomToolStripStatusLabel.Size = new System.Drawing.Size(20, 20);
            this.zoomToolStripStatusLabel.ToolTipText = "Zoom";
            // 
            // selectionToolStripStatusLabel
            // 
            this.selectionToolStripStatusLabel.Image = global::CafePrinterV2.Properties.Resources.SelectAll;
            this.selectionToolStripStatusLabel.Name = "selectionToolStripStatusLabel";
            this.selectionToolStripStatusLabel.Size = new System.Drawing.Size(20, 20);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFromFileToolStripButton,
            this.toolStripSeparator8,
            this.showImageRegionToolStripButton,
            this.showSourceImageRegionToolStripButton,
            this.toolStripSeparator1,
            this.actualSizeToolStripButton,
            this.zoomInToolStripButton,
            this.zoomOutToolStripButton,
            this.toolStripSeparator2,
            this.selectAllToolStripButton,
            this.selectNoneToolStripButton,
            this.zoomLevelsToolStripComboBox,
            this.toolStripSeparator4,
            this.CropToolStripButton,
            this.RotateLeftToolStripButton,
            this.RotateRightToolStripButton,
            this.RotateHorizontalToolStripButton,
            this.RotateVerticalToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1355, 28);
            this.toolStrip.TabIndex = 2;
            // 
            // openFromFileToolStripButton
            // 
            this.openFromFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFromFileToolStripButton.Image = global::CafePrinterV2.Properties.Resources.Open;
            this.openFromFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFromFileToolStripButton.Name = "openFromFileToolStripButton";
            this.openFromFileToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.openFromFileToolStripButton.Text = "&Open";
            this.openFromFileToolStripButton.Click += new System.EventHandler(this.openFromFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 28);
            // 
            // showImageRegionToolStripButton
            // 
            this.showImageRegionToolStripButton.CheckOnClick = true;
            this.showImageRegionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showImageRegionToolStripButton.Image = global::CafePrinterV2.Properties.Resources.Zone;
            this.showImageRegionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showImageRegionToolStripButton.Name = "showImageRegionToolStripButton";
            this.showImageRegionToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.showImageRegionToolStripButton.Text = "Show Image Region";
            this.showImageRegionToolStripButton.Click += new System.EventHandler(this.showImageRegionToolStripButton_Click);
            // 
            // showSourceImageRegionToolStripButton
            // 
            this.showSourceImageRegionToolStripButton.CheckOnClick = true;
            this.showSourceImageRegionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showSourceImageRegionToolStripButton.Image = global::CafePrinterV2.Properties.Resources.Zone;
            this.showSourceImageRegionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showSourceImageRegionToolStripButton.Name = "showSourceImageRegionToolStripButton";
            this.showSourceImageRegionToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.showSourceImageRegionToolStripButton.Text = "Show Source Image Region";
            this.showSourceImageRegionToolStripButton.Click += new System.EventHandler(this.showImageRegionToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // actualSizeToolStripButton
            // 
            this.actualSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actualSizeToolStripButton.Image = global::CafePrinterV2.Properties.Resources.ActualSize;
            this.actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualSizeToolStripButton.Name = "actualSizeToolStripButton";
            this.actualSizeToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.actualSizeToolStripButton.Text = "Actual Size";
            this.actualSizeToolStripButton.Click += new System.EventHandler(this.actualSizeToolStripButton_Click);
            // 
            // zoomInToolStripButton
            // 
            this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolStripButton.Image = global::CafePrinterV2.Properties.Resources.ZoomIn;
            this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStripButton.Name = "zoomInToolStripButton";
            this.zoomInToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.zoomInToolStripButton.Text = "Zoom In";
            this.zoomInToolStripButton.Click += new System.EventHandler(this.zoomInToolStripButton_Click);
            // 
            // zoomOutToolStripButton
            // 
            this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStripButton.Image = global::CafePrinterV2.Properties.Resources.ZoomOut;
            this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.zoomOutToolStripButton.Text = "Zoom Out";
            this.zoomOutToolStripButton.Click += new System.EventHandler(this.zoomOutToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // selectAllToolStripButton
            // 
            this.selectAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAllToolStripButton.Image = global::CafePrinterV2.Properties.Resources.SelectAll;
            this.selectAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAllToolStripButton.Name = "selectAllToolStripButton";
            this.selectAllToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.selectAllToolStripButton.Text = "Select All";
            this.selectAllToolStripButton.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectNoneToolStripButton
            // 
            this.selectNoneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectNoneToolStripButton.Image = global::CafePrinterV2.Properties.Resources.SelectNone;
            this.selectNoneToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectNoneToolStripButton.Name = "selectNoneToolStripButton";
            this.selectNoneToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.selectNoneToolStripButton.Text = "Select None";
            this.selectNoneToolStripButton.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // zoomLevelsToolStripComboBox
            // 
            this.zoomLevelsToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoomLevelsToolStripComboBox.Name = "zoomLevelsToolStripComboBox";
            this.zoomLevelsToolStripComboBox.Size = new System.Drawing.Size(160, 28);
            this.zoomLevelsToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomLevelsToolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // CropToolStripButton
            // 
            this.CropToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CropToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CropToolStripButton.Image")));
            this.CropToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CropToolStripButton.Name = "CropToolStripButton";
            this.CropToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.CropToolStripButton.Text = "Crop";
            this.CropToolStripButton.Visible = false;
            this.CropToolStripButton.Click += new System.EventHandler(this.CropToolStripButton_Click);
            // 
            // RotateLeftToolStripButton
            // 
            this.RotateLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RotateLeftToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RotateLeftToolStripButton.Image")));
            this.RotateLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RotateLeftToolStripButton.Name = "RotateLeftToolStripButton";
            this.RotateLeftToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.RotateLeftToolStripButton.Text = "Xoay trái";
            this.RotateLeftToolStripButton.Visible = false;
            this.RotateLeftToolStripButton.Click += new System.EventHandler(this.RotateLeftToolStripButton_Click);
            // 
            // RotateRightToolStripButton
            // 
            this.RotateRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RotateRightToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RotateRightToolStripButton.Image")));
            this.RotateRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RotateRightToolStripButton.Name = "RotateRightToolStripButton";
            this.RotateRightToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.RotateRightToolStripButton.Text = "Xoay phải";
            this.RotateRightToolStripButton.Visible = false;
            // 
            // RotateHorizontalToolStripButton
            // 
            this.RotateHorizontalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RotateHorizontalToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RotateHorizontalToolStripButton.Image")));
            this.RotateHorizontalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RotateHorizontalToolStripButton.Name = "RotateHorizontalToolStripButton";
            this.RotateHorizontalToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.RotateHorizontalToolStripButton.Text = "Xoay ngang";
            this.RotateHorizontalToolStripButton.Visible = false;
            // 
            // RotateVerticalToolStripButton
            // 
            this.RotateVerticalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RotateVerticalToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RotateVerticalToolStripButton.Image")));
            this.RotateVerticalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RotateVerticalToolStripButton.Name = "RotateVerticalToolStripButton";
            this.RotateVerticalToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.RotateVerticalToolStripButton.Text = "Xoay dọc";
            this.RotateVerticalToolStripButton.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1355, 28);
            this.menuStrip.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.fileToolStripMenuItem.Text = "&Tập tin";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFromFileToolStripMenuItem,
            this.fromURLToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.openToolStripMenuItem.Text = "&Chọn file";
            // 
            // openFromFileToolStripMenuItem
            // 
            this.openFromFileToolStripMenuItem.Image = global::CafePrinterV2.Properties.Resources.Open;
            this.openFromFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFromFileToolStripMenuItem.Name = "openFromFileToolStripMenuItem";
            this.openFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFromFileToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.openFromFileToolStripMenuItem.Text = "Chọn từ &File...";
            this.openFromFileToolStripMenuItem.Click += new System.EventHandler(this.openFromFileToolStripMenuItem_Click);
            // 
            // fromURLToolStripMenuItem
            // 
            this.fromURLToolStripMenuItem.Name = "fromURLToolStripMenuItem";
            this.fromURLToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.fromURLToolStripMenuItem.Text = "From &URL...";
            this.fromURLToolStripMenuItem.Visible = false;
            this.fromURLToolStripMenuItem.Click += new System.EventHandler(this.fromURLToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.exitToolStripMenuItem.Text = "&Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.toolStripSeparator6,
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.editToolStripMenuItem.Text = "&Hiệu chỉnh";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Visible = false;
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(214, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::CafePrinterV2.Properties.Resources.SelectAll;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Visible = false;
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Image = global::CafePrinterV2.Properties.Resources.SelectNone;
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.selectNoneToolStripMenuItem.Text = "Select &None";
            this.selectNoneToolStripMenuItem.Visible = false;
            this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.settingToolStripMenuItem.Text = "Cấu hình";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitCursorLocationToBoundsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Visible = false;
            // 
            // fitCursorLocationToBoundsToolStripMenuItem
            // 
            this.fitCursorLocationToBoundsToolStripMenuItem.Checked = true;
            this.fitCursorLocationToBoundsToolStripMenuItem.CheckOnClick = true;
            this.fitCursorLocationToBoundsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fitCursorLocationToBoundsToolStripMenuItem.Name = "fitCursorLocationToBoundsToolStripMenuItem";
            this.fitCursorLocationToBoundsToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.fitCursorLocationToBoundsToolStripMenuItem.Text = "Fit Cursor Location To &Bounds";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GeneralDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 912);
            this.Controls.Add(this.selectionSplitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GeneralDemoForm";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Printer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.selectionSplitContainer.Panel1.ResumeLayout(false);
            this.selectionSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectionSplitContainer)).EndInit();
            this.selectionSplitContainer.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private Cyotek.Windows.Forms.ImageBox imageBox;
    private PropertyGrid propertyGrid;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel autoScrollPositionToolStripStatusLabel;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripButton showImageRegionToolStripButton;
    private System.Windows.Forms.ToolStripButton showSourceImageRegionToolStripButton;
    private System.Windows.Forms.ToolStripStatusLabel imageSizeToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel zoomToolStripStatusLabel;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton actualSizeToolStripButton;
    private System.Windows.Forms.ToolStripButton zoomInToolStripButton;
    private System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel cursorToolStripStatusLabel;
    private System.Windows.Forms.SplitContainer selectionSplitContainer;
    private Cyotek.Windows.Forms.ImageBox previewImageBox;
    private System.Windows.Forms.ToolStripStatusLabel selectionToolStripStatusLabel;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton selectAllToolStripButton;
    private System.Windows.Forms.ToolStripButton selectNoneToolStripButton;
    private System.Windows.Forms.ToolStripButton openFromFileToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripComboBox zoomLevelsToolStripComboBox;
    private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fitCursorLocationToBoundsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openFromFileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fromURLToolStripMenuItem;
        private ToolStripButton CropToolStripButton;
        private Button btnRotateLeft;
        private ToolStripButton RotateLeftToolStripButton;
        private ToolStripButton RotateRightToolStripButton;
        private ToolStripButton RotateHorizontalToolStripButton;
        private ToolStripButton RotateVerticalToolStripButton;
        private Button btnRotateVertical;
        private Button btnRotateHorizontal;
        private Button btnRotateRight;
        private Button btnCrop;
        private Button btnPrint;
        private ToolStripMenuItem settingToolStripMenuItem;
        private Button btnPreview;
    }
}

