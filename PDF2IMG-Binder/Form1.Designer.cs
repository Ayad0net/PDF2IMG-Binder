namespace PDF2IMG_Binder
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectImagesFolder = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSelectStorePath = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnDonation = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnCheckUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSavePath.Location = new System.Drawing.Point(10, 20);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(333, 26);
            this.txtSavePath.TabIndex = 4;
            this.txtSavePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Preview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSelectImagesFolder);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.btnSelectStorePath);
            this.groupBox1.Controls.Add(this.txtSavePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 409);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "(OR)";
            // 
            // btnSelectImagesFolder
            // 
            this.btnSelectImagesFolder.Image = global::PDF2IMG_Binder.Properties.Resources.image_files;
            this.btnSelectImagesFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectImagesFolder.Location = new System.Drawing.Point(140, 67);
            this.btnSelectImagesFolder.Name = "btnSelectImagesFolder";
            this.btnSelectImagesFolder.Size = new System.Drawing.Size(102, 30);
            this.btnSelectImagesFolder.TabIndex = 8;
            this.btnSelectImagesFolder.Text = "Select Images";
            this.btnSelectImagesFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectImagesFolder.UseVisualStyleBackColor = true;
            this.btnSelectImagesFolder.Click += new System.EventHandler(this.btnSelectImagesFolder_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::PDF2IMG_Binder.Properties.Resources.pdf;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(11, 65);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(92, 34);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select PDF";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(10, 132);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(423, 266);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // btnSelectStorePath
            // 
            this.btnSelectStorePath.Image = global::PDF2IMG_Binder.Properties.Resources.folder;
            this.btnSelectStorePath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectStorePath.Location = new System.Drawing.Point(349, 19);
            this.btnSelectStorePath.Name = "btnSelectStorePath";
            this.btnSelectStorePath.Size = new System.Drawing.Size(84, 30);
            this.btnSelectStorePath.TabIndex = 3;
            this.btnSelectStorePath.Text = "Save to ...";
            this.btnSelectStorePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectStorePath.UseVisualStyleBackColor = true;
            this.btnSelectStorePath.Click += new System.EventHandler(this.BtnSelectStorePath_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(16, 438);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(49, 13);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "{version}";
            // 
            // btnDonation
            // 
            this.btnDonation.Image = global::PDF2IMG_Binder.Properties.Resources.donate;
            this.btnDonation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonation.Location = new System.Drawing.Point(182, 427);
            this.btnDonation.Name = "btnDonation";
            this.btnDonation.Size = new System.Drawing.Size(82, 35);
            this.btnDonation.TabIndex = 9;
            this.btnDonation.Text = "Donation";
            this.btnDonation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonation.UseVisualStyleBackColor = true;
            this.btnDonation.Click += new System.EventHandler(this.BtnDonation_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Image = global::PDF2IMG_Binder.Properties.Resources.github;
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.Location = new System.Drawing.Point(270, 427);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(95, 35);
            this.btnHomePage.TabIndex = 6;
            this.btnHomePage.Text = "Home page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.BtnHomePage_Click);
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.Image = global::PDF2IMG_Binder.Properties.Resources.system_update;
            this.btnCheckUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckUpdate.Location = new System.Drawing.Point(371, 427);
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Size = new System.Drawing.Size(85, 35);
            this.btnCheckUpdate.TabIndex = 5;
            this.btnCheckUpdate.Text = "Update ...";
            this.btnCheckUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckUpdate.UseVisualStyleBackColor = true;
            this.btnCheckUpdate.Click += new System.EventHandler(this.BtnCheckUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 465);
            this.Controls.Add(this.btnDonation);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnCheckUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF2IMG-Binder  |   Crafted by :: Ayad E. Korial ::";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectStorePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnCheckUpdate;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnDonation;
        private System.Windows.Forms.Button btnSelectImagesFolder;
        private System.Windows.Forms.Label label2;
    }
}

