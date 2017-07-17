namespace CafePrinterV2
{
    partial class FrmSetting
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.cbbPrinter = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudDuongKinh = new System.Windows.Forms.NumericUpDown();
            this.nudLeTrai = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudVachKe = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudLeTrenVachKe = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudLeTren = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuongKinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVachKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeTrenVachKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeTren)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn thư mục ảnh";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(178, 12);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(396, 22);
            this.txtFolderPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Máy in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đã in";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(178, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(396, 22);
            this.textBox3.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(535, 606);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(580, 12);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(30, 23);
            this.btnChooseFolder.TabIndex = 2;
            this.btnChooseFolder.Text = "...";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // cbbPrinter
            // 
            this.cbbPrinter.FormattingEnabled = true;
            this.cbbPrinter.Location = new System.Drawing.Point(178, 40);
            this.cbbPrinter.Name = "cbbPrinter";
            this.cbbPrinter.Size = new System.Drawing.Size(396, 24);
            this.cbbPrinter.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(454, 606);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CafePrinterV2.Properties.Resources.setting;
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(598, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 504);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nudDuongKinh
            // 
            this.nudDuongKinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuongKinh.Location = new System.Drawing.Point(388, 212);
            this.nudDuongKinh.Name = "nudDuongKinh";
            this.nudDuongKinh.Size = new System.Drawing.Size(96, 41);
            this.nudDuongKinh.TabIndex = 5;
            // 
            // nudLeTrai
            // 
            this.nudLeTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLeTrai.Location = new System.Drawing.Point(388, 138);
            this.nudLeTrai.Name = "nudLeTrai";
            this.nudLeTrai.Size = new System.Drawing.Size(96, 41);
            this.nudLeTrai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lề trái (mm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đường kính (mm)";
            // 
            // nudVachKe
            // 
            this.nudVachKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVachKe.Location = new System.Drawing.Point(388, 426);
            this.nudVachKe.Name = "nudVachKe";
            this.nudVachKe.Size = new System.Drawing.Size(96, 41);
            this.nudVachKe.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vạch kẻ (mm)";
            // 
            // nudLeTrenVachKe
            // 
            this.nudLeTrenVachKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLeTrenVachKe.Location = new System.Drawing.Point(388, 526);
            this.nudLeTrenVachKe.Name = "nudLeTrenVachKe";
            this.nudLeTrenVachKe.Size = new System.Drawing.Size(96, 41);
            this.nudLeTrenVachKe.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lề trên cách vạch kẻ (mm)";
            // 
            // nudLeTren
            // 
            this.nudLeTren.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLeTren.Location = new System.Drawing.Point(15, 448);
            this.nudLeTren.Name = "nudLeTren";
            this.nudLeTren.Size = new System.Drawing.Size(96, 41);
            this.nudLeTren.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Lề trên (mm)";
            // 
            // FrmSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(620, 633);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudLeTrai);
            this.Controls.Add(this.nudLeTren);
            this.Controls.Add(this.nudLeTrenVachKe);
            this.Controls.Add(this.nudVachKe);
            this.Controls.Add(this.nudDuongKinh);
            this.Controls.Add(this.cbbPrinter);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuongKinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVachKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeTrenVachKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeTren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.ComboBox cbbPrinter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudDuongKinh;
        private System.Windows.Forms.NumericUpDown nudLeTrai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudVachKe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudLeTrenVachKe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudLeTren;
        private System.Windows.Forms.Label label8;
    }
}

