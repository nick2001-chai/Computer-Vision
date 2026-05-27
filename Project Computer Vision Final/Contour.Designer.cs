
namespace Project_Computer_Vision_Final
{
    partial class Contour
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
            this.Shape_Detection = new System.Windows.Forms.PictureBox();
            this.Sorting_Contour = new System.Windows.Forms.PictureBox();
            this.Find_Contour = new System.Windows.Forms.PictureBox();
            this.Input_Image = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findContourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingContourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeDetectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Shape_Detection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sorting_Contour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Find_Contour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_Image)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Shape_Detection
            // 
            this.Shape_Detection.Location = new System.Drawing.Point(617, 395);
            this.Shape_Detection.Name = "Shape_Detection";
            this.Shape_Detection.Size = new System.Drawing.Size(373, 272);
            this.Shape_Detection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shape_Detection.TabIndex = 41;
            this.Shape_Detection.TabStop = false;
            // 
            // Sorting_Contour
            // 
            this.Sorting_Contour.Location = new System.Drawing.Point(189, 395);
            this.Sorting_Contour.Name = "Sorting_Contour";
            this.Sorting_Contour.Size = new System.Drawing.Size(357, 272);
            this.Sorting_Contour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sorting_Contour.TabIndex = 40;
            this.Sorting_Contour.TabStop = false;
            // 
            // Find_Contour
            // 
            this.Find_Contour.Location = new System.Drawing.Point(617, 67);
            this.Find_Contour.Name = "Find_Contour";
            this.Find_Contour.Size = new System.Drawing.Size(373, 271);
            this.Find_Contour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Find_Contour.TabIndex = 39;
            this.Find_Contour.TabStop = false;
            // 
            // Input_Image
            // 
            this.Input_Image.Location = new System.Drawing.Point(189, 67);
            this.Input_Image.Name = "Input_Image";
            this.Input_Image.Size = new System.Drawing.Size(357, 271);
            this.Input_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Input_Image.TabIndex = 38;
            this.Input_Image.TabStop = false;
            this.Input_Image.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(744, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Shape Detection";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(302, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Sorting Contour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(756, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Find Contour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(321, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Input Image";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.contourToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1170, 29);
            this.menuStrip1.TabIndex = 42;
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
            // 
            // contourToolStripMenuItem
            // 
            this.contourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findContourToolStripMenuItem,
            this.sortingContourToolStripMenuItem,
            this.shapeDetectionToolStripMenuItem1});
            this.contourToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contourToolStripMenuItem.Name = "contourToolStripMenuItem";
            this.contourToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.contourToolStripMenuItem.Text = "Contour";
            // 
            // findContourToolStripMenuItem
            // 
            this.findContourToolStripMenuItem.Name = "findContourToolStripMenuItem";
            this.findContourToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.findContourToolStripMenuItem.Text = "Find Contour";
            this.findContourToolStripMenuItem.Click += new System.EventHandler(this.findContourToolStripMenuItem_Click);
            // 
            // sortingContourToolStripMenuItem
            // 
            this.sortingContourToolStripMenuItem.Name = "sortingContourToolStripMenuItem";
            this.sortingContourToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.sortingContourToolStripMenuItem.Text = "Sorting Contour";
            this.sortingContourToolStripMenuItem.Click += new System.EventHandler(this.sortingContourToolStripMenuItem_Click);
            // 
            // shapeDetectionToolStripMenuItem1
            // 
            this.shapeDetectionToolStripMenuItem1.Name = "shapeDetectionToolStripMenuItem1";
            this.shapeDetectionToolStripMenuItem1.Size = new System.Drawing.Size(193, 26);
            this.shapeDetectionToolStripMenuItem1.Text = "Shape Detection";
            this.shapeDetectionToolStripMenuItem1.Click += new System.EventHandler(this.shapeDetectionToolStripMenuItem1_Click);
            // 
            // Contour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Shape_Detection);
            this.Controls.Add(this.Sorting_Contour);
            this.Controls.Add(this.Find_Contour);
            this.Controls.Add(this.Input_Image);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Contour";
            this.Size = new System.Drawing.Size(1170, 701);
            ((System.ComponentModel.ISupportInitialize)(this.Shape_Detection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sorting_Contour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Find_Contour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_Image)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Shape_Detection;
        private System.Windows.Forms.PictureBox Sorting_Contour;
        private System.Windows.Forms.PictureBox Find_Contour;
        private System.Windows.Forms.PictureBox Input_Image;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findContourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingContourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeDetectionToolStripMenuItem1;
    }
}
