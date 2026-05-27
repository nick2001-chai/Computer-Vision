
namespace Project_Computer_Vision_Final
{
    partial class ImageBinarization
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBinarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryInvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptiveThresoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guassianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Location = new System.Drawing.Point(605, 126);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(505, 438);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOutput.TabIndex = 8;
            this.pictureBoxOutput.TabStop = false;
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.Location = new System.Drawing.Point(69, 126);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(521, 438);
            this.pictureBoxOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrigin.TabIndex = 7;
            this.pictureBoxOrigin.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageBinarizationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // imageBinarizationToolStripMenuItem
            // 
            this.imageBinarizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleThresholdToolStripMenuItem,
            this.adaptiveThresoldToolStripMenuItem});
            this.imageBinarizationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBinarizationToolStripMenuItem.Name = "imageBinarizationToolStripMenuItem";
            this.imageBinarizationToolStripMenuItem.Size = new System.Drawing.Size(151, 25);
            this.imageBinarizationToolStripMenuItem.Text = "Image Binarization";
            // 
            // simpleThresholdToolStripMenuItem
            // 
            this.simpleThresholdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.binaryInvertToolStripMenuItem,
            this.oTSuToolStripMenuItem});
            this.simpleThresholdToolStripMenuItem.Name = "simpleThresholdToolStripMenuItem";
            this.simpleThresholdToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.simpleThresholdToolStripMenuItem.Text = "Simple Threshold";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // binaryInvertToolStripMenuItem
            // 
            this.binaryInvertToolStripMenuItem.Name = "binaryInvertToolStripMenuItem";
            this.binaryInvertToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.binaryInvertToolStripMenuItem.Text = "Binary Invert";
            this.binaryInvertToolStripMenuItem.Click += new System.EventHandler(this.binaryInvertToolStripMenuItem_Click);
            // 
            // oTSuToolStripMenuItem
            // 
            this.oTSuToolStripMenuItem.Name = "oTSuToolStripMenuItem";
            this.oTSuToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.oTSuToolStripMenuItem.Text = "OT’Su";
            this.oTSuToolStripMenuItem.Click += new System.EventHandler(this.oTSuToolStripMenuItem_Click);
            // 
            // adaptiveThresoldToolStripMenuItem
            // 
            this.adaptiveThresoldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guassianToolStripMenuItem,
            this.meanToolStripMenuItem});
            this.adaptiveThresoldToolStripMenuItem.Name = "adaptiveThresoldToolStripMenuItem";
            this.adaptiveThresoldToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.adaptiveThresoldToolStripMenuItem.Text = "Adaptive Thresold";
            // 
            // guassianToolStripMenuItem
            // 
            this.guassianToolStripMenuItem.Name = "guassianToolStripMenuItem";
            this.guassianToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.guassianToolStripMenuItem.Text = "Guassian";
            this.guassianToolStripMenuItem.Click += new System.EventHandler(this.guassianToolStripMenuItem_Click);
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.meanToolStripMenuItem.Text = "Mean";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // ImageBinarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxOutput);
            this.Controls.Add(this.pictureBoxOrigin);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ImageBinarization";
            this.Size = new System.Drawing.Size(1170, 701);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageBinarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryInvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaptiveThresoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guassianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
    }
}
