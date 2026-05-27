
namespace Project_Computer_Vision_Final
{
    partial class ConvertToGray
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBlackWhile = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblcPowerLaw = new System.Windows.Forms.Label();
            this.lblC_PowerLaw = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblC_LogTransformation = new System.Windows.Forms.Label();
            this.btn_Log_Transformation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblThresold = new System.Windows.Forms.Label();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnNagative = new System.Windows.Forms.Button();
            this.OutputImage = new System.Windows.Forms.PictureBox();
            this.InputImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScale2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(618, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Output Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(177, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input Image";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBlackWhile);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.lblAlpha);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.lblcPowerLaw);
            this.groupBox1.Controls.Add(this.lblC_PowerLaw);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblC_LogTransformation);
            this.groupBox1.Controls.Add(this.btn_Log_Transformation);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblThresold);
            this.groupBox1.Controls.Add(this.btnInvert);
            this.groupBox1.Controls.Add(this.btnNagative);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(900, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 508);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert To Gray (Threshold)";
            // 
            // btnBlackWhile
            // 
            this.btnBlackWhile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBlackWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBlackWhile.ForeColor = System.Drawing.Color.White;
            this.btnBlackWhile.Location = new System.Drawing.Point(20, 75);
            this.btnBlackWhile.Name = "btnBlackWhile";
            this.btnBlackWhile.Size = new System.Drawing.Size(215, 40);
            this.btnBlackWhile.TabIndex = 30;
            this.btnBlackWhile.Text = "Black and While";
            this.btnBlackWhile.UseVisualStyleBackColor = false;
            this.btnBlackWhile.Click += new System.EventHandler(this.btnBlackWhile_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox4.Location = new System.Drawing.Point(92, 480);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 26);
            this.textBox4.TabIndex = 29;
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAlpha.Location = new System.Drawing.Point(25, 483);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(67, 20);
            this.lblAlpha.TabIndex = 28;
            this.lblAlpha.Text = "Alpha = ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox3.Location = new System.Drawing.Point(92, 439);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 26);
            this.textBox3.TabIndex = 27;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblcPowerLaw
            // 
            this.lblcPowerLaw.AutoSize = true;
            this.lblcPowerLaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblcPowerLaw.Location = new System.Drawing.Point(37, 436);
            this.lblcPowerLaw.Name = "lblcPowerLaw";
            this.lblcPowerLaw.Size = new System.Drawing.Size(33, 20);
            this.lblcPowerLaw.TabIndex = 26;
            this.lblcPowerLaw.Text = "C =";
            this.lblcPowerLaw.Click += new System.EventHandler(this.lblcPowerLaw_Click);
            // 
            // lblC_PowerLaw
            // 
            this.lblC_PowerLaw.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblC_PowerLaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblC_PowerLaw.ForeColor = System.Drawing.Color.White;
            this.lblC_PowerLaw.Location = new System.Drawing.Point(23, 383);
            this.lblC_PowerLaw.Name = "lblC_PowerLaw";
            this.lblC_PowerLaw.Size = new System.Drawing.Size(212, 39);
            this.lblC_PowerLaw.TabIndex = 25;
            this.lblC_PowerLaw.Text = "Power Law";
            this.lblC_PowerLaw.UseVisualStyleBackColor = false;
            this.lblC_PowerLaw.Click += new System.EventHandler(this.lblC_PowerLaw_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox2.Location = new System.Drawing.Point(92, 340);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 26);
            this.textBox2.TabIndex = 24;
            // 
            // lblC_LogTransformation
            // 
            this.lblC_LogTransformation.AutoSize = true;
            this.lblC_LogTransformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblC_LogTransformation.Location = new System.Drawing.Point(37, 343);
            this.lblC_LogTransformation.Name = "lblC_LogTransformation";
            this.lblC_LogTransformation.Size = new System.Drawing.Size(33, 20);
            this.lblC_LogTransformation.TabIndex = 23;
            this.lblC_LogTransformation.Text = "C =";
            // 
            // btn_Log_Transformation
            // 
            this.btn_Log_Transformation.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Log_Transformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Log_Transformation.ForeColor = System.Drawing.Color.White;
            this.btn_Log_Transformation.Location = new System.Drawing.Point(20, 282);
            this.btn_Log_Transformation.Name = "btn_Log_Transformation";
            this.btn_Log_Transformation.Size = new System.Drawing.Size(215, 39);
            this.btn_Log_Transformation.TabIndex = 22;
            this.btn_Log_Transformation.Text = "Log Transformation";
            this.btn_Log_Transformation.UseVisualStyleBackColor = false;
            this.btn_Log_Transformation.Click += new System.EventHandler(this.btn_Log_Transformation_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(92, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 24);
            this.textBox1.TabIndex = 21;
            // 
            // lblThresold
            // 
            this.lblThresold.AutoSize = true;
            this.lblThresold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblThresold.Location = new System.Drawing.Point(13, 134);
            this.lblThresold.Name = "lblThresold";
            this.lblThresold.Size = new System.Drawing.Size(79, 20);
            this.lblThresold.TabIndex = 20;
            this.lblThresold.Text = "Threshold";
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnInvert.ForeColor = System.Drawing.Color.White;
            this.btnInvert.Location = new System.Drawing.Point(23, 226);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(212, 39);
            this.btnInvert.TabIndex = 19;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = false;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click_1);
            // 
            // btnNagative
            // 
            this.btnNagative.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNagative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNagative.ForeColor = System.Drawing.Color.White;
            this.btnNagative.Location = new System.Drawing.Point(23, 170);
            this.btnNagative.Name = "btnNagative";
            this.btnNagative.Size = new System.Drawing.Size(212, 40);
            this.btnNagative.TabIndex = 18;
            this.btnNagative.Text = "Negative";
            this.btnNagative.UseVisualStyleBackColor = false;
            this.btnNagative.Click += new System.EventHandler(this.btnNagative_Click);
            // 
            // OutputImage
            // 
            this.OutputImage.Location = new System.Drawing.Point(475, 137);
            this.OutputImage.Name = "OutputImage";
            this.OutputImage.Size = new System.Drawing.Size(408, 429);
            this.OutputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutputImage.TabIndex = 10;
            this.OutputImage.TabStop = false;
            // 
            // InputImage
            // 
            this.InputImage.Location = new System.Drawing.Point(38, 137);
            this.InputImage.Name = "InputImage";
            this.InputImage.Size = new System.Drawing.Size(407, 429);
            this.InputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InputImage.TabIndex = 9;
            this.InputImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToGrayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 29);
            this.menuStrip1.TabIndex = 14;
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.openToolStripMenuItem.Text = "Open ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // convertToGrayToolStripMenuItem
            // 
            this.convertToGrayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScaleToolStripMenuItem,
            this.grayScale2ToolStripMenuItem});
            this.convertToGrayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertToGrayToolStripMenuItem.Name = "convertToGrayToolStripMenuItem";
            this.convertToGrayToolStripMenuItem.Size = new System.Drawing.Size(132, 25);
            this.convertToGrayToolStripMenuItem.Text = "Convert to Gray";
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.grayScaleToolStripMenuItem.Text = "Gray Scale 1";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // grayScale2ToolStripMenuItem
            // 
            this.grayScale2ToolStripMenuItem.Name = "grayScale2ToolStripMenuItem";
            this.grayScale2ToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.grayScale2ToolStripMenuItem.Text = "Gray Scale 2";
            this.grayScale2ToolStripMenuItem.Click += new System.EventHandler(this.grayScale2ToolStripMenuItem_Click);
            // 
            // ConvertToGray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OutputImage);
            this.Controls.Add(this.InputImage);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ConvertToGray";
            this.Size = new System.Drawing.Size(1190, 702);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBlackWhile;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblcPowerLaw;
        private System.Windows.Forms.Button lblC_PowerLaw;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblC_LogTransformation;
        private System.Windows.Forms.Button btn_Log_Transformation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblThresold;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnNagative;
        private System.Windows.Forms.PictureBox OutputImage;
        private System.Windows.Forms.PictureBox InputImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScale2ToolStripMenuItem;
    }
}
