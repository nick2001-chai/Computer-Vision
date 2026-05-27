
namespace Project_Computer_Vision_Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.aboutus = new System.Windows.Forms.Button();
            this.btnFaceDetection = new System.Windows.Forms.Button();
            this.btnVDO = new System.Windows.Forms.Button();
            this.btnContour = new System.Windows.Forms.Button();
            this.btnMorphology = new System.Windows.Forms.Button();
            this.btnEdgeDetection = new System.Windows.Forms.Button();
            this.btnImageBinarization = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.btnConvertToGray = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.about_US1 = new Final_Project_Computer_Vision.About_US();
            this.facedetection1 = new Project_Computer_Vision_Final.facedetection();
            this.vdo1 = new Project_Computer_Vision_Final.VDO();
            this.contour1 = new Project_Computer_Vision_Final.Contour();
            this.morphology1 = new Project_Computer_Vision_Final.Morphology();
            this.edgeDetection1 = new Project_Computer_Vision_Final.EdgeDetection();
            this.imageBinarization1 = new Project_Computer_Vision_Final.ImageBinarization();
            this.histogram1 = new Project_Computer_Vision_Final.Histogram();
            this.convertToGray1 = new Project_Computer_Vision_Final.ConvertToGray();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1170, 48);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel6.Controls.Add(this.lblH);
            this.panel6.Location = new System.Drawing.Point(419, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(301, 45);
            this.panel6.TabIndex = 0;
            // 
            // lblH
            // 
            this.lblH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblH.Location = new System.Drawing.Point(23, 6);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(265, 29);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "Photo Editor Program";
            this.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.aboutus);
            this.panel1.Controls.Add(this.btnFaceDetection);
            this.panel1.Controls.Add(this.btnVDO);
            this.panel1.Controls.Add(this.btnContour);
            this.panel1.Controls.Add(this.btnMorphology);
            this.panel1.Controls.Add(this.btnEdgeDetection);
            this.panel1.Controls.Add(this.btnImageBinarization);
            this.panel1.Controls.Add(this.btnHistogram);
            this.panel1.Controls.Add(this.btnConvertToGray);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 749);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aboutus
            // 
            this.aboutus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutus.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutus.FlatAppearance.BorderSize = 0;
            this.aboutus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.aboutus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.aboutus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutus.Location = new System.Drawing.Point(0, 499);
            this.aboutus.Name = "aboutus";
            this.aboutus.Size = new System.Drawing.Size(200, 35);
            this.aboutus.TabIndex = 10;
            this.aboutus.Text = "About us";
            this.aboutus.UseVisualStyleBackColor = false;
            this.aboutus.Click += new System.EventHandler(this.aboutus_Click);
            // 
            // btnFaceDetection
            // 
            this.btnFaceDetection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFaceDetection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFaceDetection.FlatAppearance.BorderSize = 0;
            this.btnFaceDetection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnFaceDetection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaceDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnFaceDetection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFaceDetection.Location = new System.Drawing.Point(0, 464);
            this.btnFaceDetection.Name = "btnFaceDetection";
            this.btnFaceDetection.Size = new System.Drawing.Size(200, 35);
            this.btnFaceDetection.TabIndex = 9;
            this.btnFaceDetection.Text = "Face Detection";
            this.btnFaceDetection.UseVisualStyleBackColor = false;
            this.btnFaceDetection.Click += new System.EventHandler(this.btnFaceDetection_Click_1);
            // 
            // btnVDO
            // 
            this.btnVDO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVDO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVDO.FlatAppearance.BorderSize = 0;
            this.btnVDO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnVDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnVDO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVDO.Location = new System.Drawing.Point(0, 429);
            this.btnVDO.Name = "btnVDO";
            this.btnVDO.Size = new System.Drawing.Size(200, 35);
            this.btnVDO.TabIndex = 8;
            this.btnVDO.Text = "VDO Processing";
            this.btnVDO.UseVisualStyleBackColor = false;
            this.btnVDO.Click += new System.EventHandler(this.btnVDO_Click_1);
            // 
            // btnContour
            // 
            this.btnContour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnContour.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContour.FlatAppearance.BorderSize = 0;
            this.btnContour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnContour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnContour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContour.Location = new System.Drawing.Point(0, 394);
            this.btnContour.Name = "btnContour";
            this.btnContour.Size = new System.Drawing.Size(200, 35);
            this.btnContour.TabIndex = 7;
            this.btnContour.Text = "Contour";
            this.btnContour.UseVisualStyleBackColor = false;
            this.btnContour.Click += new System.EventHandler(this.btnContour_Click_1);
            // 
            // btnMorphology
            // 
            this.btnMorphology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMorphology.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMorphology.FlatAppearance.BorderSize = 0;
            this.btnMorphology.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnMorphology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorphology.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnMorphology.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMorphology.Location = new System.Drawing.Point(0, 359);
            this.btnMorphology.Name = "btnMorphology";
            this.btnMorphology.Size = new System.Drawing.Size(200, 35);
            this.btnMorphology.TabIndex = 6;
            this.btnMorphology.Text = "Morphology";
            this.btnMorphology.UseVisualStyleBackColor = false;
            this.btnMorphology.Click += new System.EventHandler(this.btnMorphology_Click_1);
            // 
            // btnEdgeDetection
            // 
            this.btnEdgeDetection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdgeDetection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdgeDetection.FlatAppearance.BorderSize = 0;
            this.btnEdgeDetection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEdgeDetection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdgeDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEdgeDetection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdgeDetection.Location = new System.Drawing.Point(0, 324);
            this.btnEdgeDetection.Name = "btnEdgeDetection";
            this.btnEdgeDetection.Size = new System.Drawing.Size(200, 35);
            this.btnEdgeDetection.TabIndex = 5;
            this.btnEdgeDetection.Text = "Edge Detection";
            this.btnEdgeDetection.UseVisualStyleBackColor = false;
            this.btnEdgeDetection.Click += new System.EventHandler(this.btnEdgeDetection_Click_1);
            // 
            // btnImageBinarization
            // 
            this.btnImageBinarization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImageBinarization.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImageBinarization.FlatAppearance.BorderSize = 0;
            this.btnImageBinarization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnImageBinarization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageBinarization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnImageBinarization.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImageBinarization.Location = new System.Drawing.Point(0, 289);
            this.btnImageBinarization.Name = "btnImageBinarization";
            this.btnImageBinarization.Size = new System.Drawing.Size(200, 35);
            this.btnImageBinarization.TabIndex = 4;
            this.btnImageBinarization.Text = "Image Binarization";
            this.btnImageBinarization.UseVisualStyleBackColor = false;
            this.btnImageBinarization.Click += new System.EventHandler(this.btnImageBinarization_Click_1);
            // 
            // btnHistogram
            // 
            this.btnHistogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistogram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistogram.FlatAppearance.BorderSize = 0;
            this.btnHistogram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnHistogram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistogram.Location = new System.Drawing.Point(0, 254);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(200, 35);
            this.btnHistogram.TabIndex = 3;
            this.btnHistogram.Text = "Histogram";
            this.btnHistogram.UseVisualStyleBackColor = false;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click_1);
            // 
            // btnConvertToGray
            // 
            this.btnConvertToGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConvertToGray.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvertToGray.FlatAppearance.BorderSize = 0;
            this.btnConvertToGray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnConvertToGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertToGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnConvertToGray.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvertToGray.Location = new System.Drawing.Point(0, 219);
            this.btnConvertToGray.Name = "btnConvertToGray";
            this.btnConvertToGray.Size = new System.Drawing.Size(200, 35);
            this.btnConvertToGray.TabIndex = 2;
            this.btnConvertToGray.Text = "Convert To Gray";
            this.btnConvertToGray.UseVisualStyleBackColor = false;
            this.btnConvertToGray.Click += new System.EventHandler(this.btnConvertToGray_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Navy;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(0, 184);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 35);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 184);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(537, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome to Photo Editor Program";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(447, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(681, 421);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // about_US1
            // 
            this.about_US1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.about_US1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about_US1.Location = new System.Drawing.Point(200, 48);
            this.about_US1.Name = "about_US1";
            this.about_US1.Size = new System.Drawing.Size(1170, 701);
            this.about_US1.TabIndex = 19;
            this.about_US1.Visible = false;
            // 
            // facedetection1
            // 
            this.facedetection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facedetection1.Location = new System.Drawing.Point(200, 48);
            this.facedetection1.Margin = new System.Windows.Forms.Padding(2);
            this.facedetection1.Name = "facedetection1";
            this.facedetection1.Size = new System.Drawing.Size(1170, 701);
            this.facedetection1.TabIndex = 18;
            this.facedetection1.Visible = false;
            // 
            // vdo1
            // 
            this.vdo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vdo1.Location = new System.Drawing.Point(200, 48);
            this.vdo1.Name = "vdo1";
            this.vdo1.Size = new System.Drawing.Size(1170, 701);
            this.vdo1.TabIndex = 17;
            this.vdo1.Visible = false;
            // 
            // contour1
            // 
            this.contour1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contour1.Location = new System.Drawing.Point(200, 48);
            this.contour1.Name = "contour1";
            this.contour1.Size = new System.Drawing.Size(1170, 701);
            this.contour1.TabIndex = 16;
            this.contour1.Visible = false;
            // 
            // morphology1
            // 
            this.morphology1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.morphology1.Location = new System.Drawing.Point(200, 48);
            this.morphology1.Name = "morphology1";
            this.morphology1.Size = new System.Drawing.Size(1170, 701);
            this.morphology1.TabIndex = 15;
            this.morphology1.Visible = false;
            // 
            // edgeDetection1
            // 
            this.edgeDetection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edgeDetection1.Location = new System.Drawing.Point(200, 48);
            this.edgeDetection1.Name = "edgeDetection1";
            this.edgeDetection1.Size = new System.Drawing.Size(1170, 701);
            this.edgeDetection1.TabIndex = 14;
            this.edgeDetection1.Visible = false;
            // 
            // imageBinarization1
            // 
            this.imageBinarization1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBinarization1.Location = new System.Drawing.Point(200, 48);
            this.imageBinarization1.Name = "imageBinarization1";
            this.imageBinarization1.Size = new System.Drawing.Size(1170, 701);
            this.imageBinarization1.TabIndex = 13;
            this.imageBinarization1.Visible = false;
            // 
            // histogram1
            // 
            this.histogram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogram1.Location = new System.Drawing.Point(200, 48);
            this.histogram1.Name = "histogram1";
            this.histogram1.Size = new System.Drawing.Size(1170, 701);
            this.histogram1.TabIndex = 12;
            this.histogram1.Visible = false;
            // 
            // convertToGray1
            // 
            this.convertToGray1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertToGray1.Location = new System.Drawing.Point(200, 48);
            this.convertToGray1.Name = "convertToGray1";
            this.convertToGray1.Size = new System.Drawing.Size(1170, 701);
            this.convertToGray1.TabIndex = 11;
            this.convertToGray1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.about_US1);
            this.Controls.Add(this.facedetection1);
            this.Controls.Add(this.vdo1);
            this.Controls.Add(this.contour1);
            this.Controls.Add(this.morphology1);
            this.Controls.Add(this.edgeDetection1);
            this.Controls.Add(this.imageBinarization1);
            this.Controls.Add(this.histogram1);
            this.Controls.Add(this.convertToGray1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button aboutus;
        private System.Windows.Forms.Button btnFaceDetection;
        private System.Windows.Forms.Button btnVDO;
        private System.Windows.Forms.Button btnContour;
        private System.Windows.Forms.Button btnMorphology;
        private System.Windows.Forms.Button btnEdgeDetection;
        private System.Windows.Forms.Button btnImageBinarization;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.Button btnConvertToGray;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ConvertToGray convertToGray1;
        private Histogram histogram1;
        private ImageBinarization imageBinarization1;
        private EdgeDetection edgeDetection1;
        private Morphology morphology1;
        private Contour contour1;
        private VDO vdo1;
        private facedetection facedetection1;
        private Final_Project_Computer_Vision.About_US about_US1;
    }
}

