
namespace Project_Computer_Vision_Final
{
    partial class Histogram
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
            this.components = new System.ComponentModel.Container();
            this.imgOutput = new Emgu.CV.UI.ImageBox();
            this.imgInput = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioG = new System.Windows.Forms.RadioButton();
            this.radioR = new System.Windows.Forms.RadioButton();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgOutput
            // 
            this.imgOutput.Location = new System.Drawing.Point(68, 349);
            this.imgOutput.Name = "imgOutput";
            this.imgOutput.Size = new System.Drawing.Size(393, 282);
            this.imgOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOutput.TabIndex = 18;
            this.imgOutput.TabStop = false;
            // 
            // imgInput
            // 
            this.imgInput.Location = new System.Drawing.Point(68, 72);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(393, 271);
            this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInput.TabIndex = 15;
            this.imgInput.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioB);
            this.groupBox1.Controls.Add(this.radioG);
            this.groupBox1.Controls.Add(this.radioR);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(962, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 172);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histogram";
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(6, 121);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(59, 24);
            this.radioB.TabIndex = 2;
            this.radioB.TabStop = true;
            this.radioB.Text = "Blue";
            this.radioB.UseVisualStyleBackColor = true;
            this.radioB.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // radioG
            // 
            this.radioG.AutoSize = true;
            this.radioG.Location = new System.Drawing.Point(6, 77);
            this.radioG.Name = "radioG";
            this.radioG.Size = new System.Drawing.Size(72, 24);
            this.radioG.TabIndex = 1;
            this.radioG.TabStop = true;
            this.radioG.Text = "Green";
            this.radioG.UseVisualStyleBackColor = true;
            this.radioG.CheckedChanged += new System.EventHandler(this.radioG_CheckedChanged);
            // 
            // radioR
            // 
            this.radioR.AutoSize = true;
            this.radioR.Location = new System.Drawing.Point(6, 39);
            this.radioR.Name = "radioR";
            this.radioR.Size = new System.Drawing.Size(57, 24);
            this.radioR.TabIndex = 0;
            this.radioR.TabStop = true;
            this.radioR.Text = "Red";
            this.radioR.UseVisualStyleBackColor = true;
            this.radioR.CheckedChanged += new System.EventHandler(this.radioR_CheckedChanged);
            // 
            // histogramBox1
            // 
            this.histogramBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramBox1.Location = new System.Drawing.Point(467, 72);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(470, 559);
            this.histogramBox1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 29);
            this.menuStrip1.TabIndex = 19;
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
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgOutput);
            this.Controls.Add(this.imgInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Histogram";
            this.Size = new System.Drawing.Size(1170, 701);
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgOutput;
        private Emgu.CV.UI.ImageBox imgInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioG;
        private System.Windows.Forms.RadioButton radioR;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}
