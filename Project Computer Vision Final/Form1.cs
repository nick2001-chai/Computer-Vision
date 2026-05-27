using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;



namespace Project_Computer_Vision_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    private void btnHome_Click_1(object sender, EventArgs e)
        {
            lblH.Text = "Photo Editor Program";
            pictureBox2.Visible = true;
            convertToGray1.Visible = false;
            contour1.Visible = false;
            edgeDetection1.Visible = false;
            histogram1.Visible = false;
            vdo1.Visible = false;
            facedetection1.Visible = false;
            about_US1.Visible = false;
            label2.Visible = true;
            imageBinarization1.Visible = false;
            morphology1.Visible = false;
            if (btnHome.Focused == true)
            {
                btnHome.BackColor = Color.Navy;
                btnConvertToGray.BackColor = panel1.BackColor;
                btnHistogram.BackColor = panel1.BackColor;
                panel5.BackColor = Color.Navy;
                btnImageBinarization.BackColor = panel1.BackColor;
                btnEdgeDetection.BackColor = panel1.BackColor;
                btnMorphology.BackColor = panel1.BackColor;
                btnContour.BackColor = panel1.BackColor;
                btnVDO.BackColor = panel1.BackColor;
                btnFaceDetection.BackColor = panel1.BackColor;
                aboutus.BackColor = panel1.BackColor;
            }
        }
        private void btnConvertToGray_Click_1(object sender, EventArgs e)
        {
            lblH.Text = "Convet to Gray";
            pictureBox2.Visible = false;
            convertToGray1.Visible = true;
            contour1.Visible = false;
            label2.Visible = false;
            about_US1.Visible = false;
            edgeDetection1.Visible = false;
            histogram1.Visible = false;
            vdo1.Visible = false;
            facedetection1.Visible = false;
            imageBinarization1.Visible = false;
            morphology1.Visible = false;

            if (btnConvertToGray.Focused == true)
            {
                btnConvertToGray.BackColor = Color.DarkGray;
                btnHome.BackColor = panel1.BackColor;
                btnHistogram.BackColor = panel1.BackColor;
                panel5.BackColor = Color.DarkGray;
                btnImageBinarization.BackColor = panel1.BackColor;
                btnEdgeDetection.BackColor = panel1.BackColor;
                btnMorphology.BackColor = panel1.BackColor;
                btnContour.BackColor = panel1.BackColor;
                btnVDO.BackColor = panel1.BackColor;
                btnFaceDetection.BackColor = panel1.BackColor;
                aboutus.BackColor = panel1.BackColor;
            }
        }

        private void btnHistogram_Click_1(object sender, EventArgs e)
        {
                lblH.Text = "         Histogram";
                convertToGray1.Visible = false;
                pictureBox2.Visible = false;
                contour1.Visible = false;
                edgeDetection1.Visible = false;
                histogram1.Visible = true;
                vdo1.Visible = false;
                label2.Visible = false;
                about_US1.Visible = false;
                imageBinarization1.Visible = false;
                facedetection1.Visible = false;
                morphology1.Visible = false;
                if (btnHistogram.Focused == true)
                {
                    btnHistogram.BackColor = Color.DarkCyan;
                    btnHome.BackColor = panel1.BackColor;
                    btnConvertToGray.BackColor = panel1.BackColor;
                    panel5.BackColor = Color.DarkCyan;
                    btnImageBinarization.BackColor = panel1.BackColor;
                    btnEdgeDetection.BackColor = panel1.BackColor;
                    btnMorphology.BackColor = panel1.BackColor;
                    aboutus.BackColor = panel1.BackColor;
                    btnContour.BackColor = panel1.BackColor;
                    btnVDO.BackColor = panel1.BackColor;
                    btnFaceDetection.BackColor = panel1.BackColor;
                }
            }

        private void btnImageBinarization_Click_1(object sender, EventArgs e)
        {
                lblH.Text = "Image Binarization";
                convertToGray1.Visible = false;
                contour1.Visible = false;
                label2.Visible = false;
                edgeDetection1.Visible = false;
                pictureBox2.Visible = false;
                about_US1.Visible = false;
                histogram1.Visible = false;
                vdo1.Visible = false;
                imageBinarization1.Visible = true;
                facedetection1.Visible = false;
                morphology1.Visible = false;
                if (btnImageBinarization.Focused == true)
                {
                    btnImageBinarization.BackColor = Color.DarkGreen;
                    btnHome.BackColor = panel1.BackColor;
                    btnConvertToGray.BackColor = panel1.BackColor;
                    aboutus.BackColor = panel1.BackColor;
                    btnHistogram.BackColor = panel1.BackColor;
                    panel5.BackColor = Color.DarkGreen;
                    btnEdgeDetection.BackColor = panel1.BackColor;
                    btnMorphology.BackColor = panel1.BackColor;
                    btnContour.BackColor = panel1.BackColor;
                    btnVDO.BackColor = panel1.BackColor;
                    btnFaceDetection.BackColor = panel1.BackColor;
                }
            }

        private void btnEdgeDetection_Click_1(object sender, EventArgs e)
        {
                lblH.Text = "Edge Detection";
                convertToGray1.Visible = false;
                contour1.Visible = false;
                edgeDetection1.Visible = true;
                about_US1.Visible = false;
                pictureBox2.Visible = false;
                facedetection1.Visible = false;
                histogram1.Visible = false;
                vdo1.Visible = false;
                imageBinarization1.Visible = false;
                label2.Visible = false;
                morphology1.Visible = false;
                if (btnEdgeDetection.Focused == true)
                {
                    btnEdgeDetection.BackColor = Color.DarkKhaki;
                    btnHome.BackColor = panel1.BackColor;
                    btnConvertToGray.BackColor = panel1.BackColor;
                    btnHistogram.BackColor = panel1.BackColor;
                    panel5.BackColor = Color.DarkKhaki;
                    aboutus.BackColor = panel1.BackColor;
                    btnImageBinarization.BackColor = panel1.BackColor;
                    btnMorphology.BackColor = panel1.BackColor;
                    btnContour.BackColor = panel1.BackColor;
                    btnVDO.BackColor = panel1.BackColor;
                    btnFaceDetection.BackColor = panel1.BackColor;
                }
            }

        private void btnMorphology_Click_1(object sender, EventArgs e)
        {    
                lblH.Text = "        Morphology";
                convertToGray1.Visible = false;
                contour1.Visible = false;
                edgeDetection1.Visible = false;
                histogram1.Visible = false;
                pictureBox2.Visible = false;
                label2.Visible = false;
                facedetection1.Visible = false;
                vdo1.Visible = false;
                imageBinarization1.Visible = false;
                morphology1.Visible = true;
                about_US1.Visible = false;
                if (btnMorphology.Focused == true)
                {
                    btnMorphology.BackColor = Color.DarkMagenta;
                    aboutus.BackColor = panel1.BackColor;
                    btnHome.BackColor = panel1.BackColor;
                    btnConvertToGray.BackColor = panel1.BackColor;
                    btnHistogram.BackColor = panel1.BackColor;
                    panel5.BackColor = Color.DarkMagenta;
                    btnImageBinarization.BackColor = panel1.BackColor;
                    btnEdgeDetection.BackColor = panel1.BackColor;
                    btnContour.BackColor = panel1.BackColor;
                    btnVDO.BackColor = panel1.BackColor;
                    btnFaceDetection.BackColor = panel1.BackColor;
                }
            }

        private void btnContour_Click_1(object sender, EventArgs e)
        {
           
                lblH.Text = "           Contour";
                convertToGray1.Visible = false;
                contour1.Visible = true;
                edgeDetection1.Visible = false;
                histogram1.Visible = false;
                label2.Visible = false;
                pictureBox2.Visible = false;
                facedetection1.Visible = false;
                vdo1.Visible = false;
                about_US1.Visible = false;
                imageBinarization1.Visible = false;
                morphology1.Visible = false;
                if (btnContour.Focused == true)
                {
                    btnContour.BackColor = Color.DarkOliveGreen;
                    btnHome.BackColor = panel1.BackColor;
                    btnConvertToGray.BackColor = panel1.BackColor;
                    btnHistogram.BackColor = panel1.BackColor;
                    aboutus.BackColor = panel1.BackColor;
                    panel5.BackColor = Color.DarkOliveGreen;
                    btnImageBinarization.BackColor = panel1.BackColor;
                    btnEdgeDetection.BackColor = panel1.BackColor;
                    btnMorphology.BackColor = panel1.BackColor;
                    btnVDO.BackColor = panel1.BackColor;
                    btnFaceDetection.BackColor = panel1.BackColor;
                }
            }

        private void btnVDO_Click_1(object sender, EventArgs e)
        {
                lblH.Text = "     VDO Processing";
                convertToGray1.Visible = false;
                contour1.Visible = false;
                edgeDetection1.Visible = false;
                histogram1.Visible = false;
                vdo1.Visible = true;
                about_US1.Visible = false;
                pictureBox2.Visible = false;
                facedetection1.Visible = false;
                label2.Visible = false;
                imageBinarization1.Visible = false;
                morphology1.Visible = false;
                if (btnVDO.Focused == true)
                {
                    btnVDO.BackColor = Color.DarkOrchid;
                    btnHome.BackColor = panel1.BackColor;
                    btnConvertToGray.BackColor = panel1.BackColor;
                    aboutus.BackColor = panel1.BackColor;
                    btnHistogram.BackColor = panel1.BackColor;
                    panel5.BackColor = Color.DarkOrchid;
                    btnImageBinarization.BackColor = panel1.BackColor;
                    btnEdgeDetection.BackColor = panel1.BackColor;
                    btnMorphology.BackColor = panel1.BackColor;
                    btnContour.BackColor = panel1.BackColor;
                    btnFaceDetection.BackColor = panel1.BackColor;
                }
            }

        private void btnFaceDetection_Click_1(object sender, EventArgs e)
        {
                lblH.Text = "      Face Detection";
                facedetection1.Visible = true;
                convertToGray1.Visible = false;
                label2.Visible = false;
                contour1.Visible = false;
                edgeDetection1.Visible = false;
                histogram1.Visible = false;
                about_US1.Visible = false;
                vdo1.Visible = false;
                pictureBox2.Visible = false;
                imageBinarization1.Visible = false;
                morphology1.Visible = false;
                if (btnFaceDetection.Focused == true)
                {
                    btnFaceDetection.BackColor = Color.DarkTurquoise;
                    btnHome.BackColor = panel1.BackColor;
                    btnConvertToGray.BackColor = panel1.BackColor;
                    btnHistogram.BackColor = panel1.BackColor;
                    panel5.BackColor = Color.DarkTurquoise;
                    aboutus.BackColor = panel1.BackColor;
                    btnImageBinarization.BackColor = panel1.BackColor;
                    btnEdgeDetection.BackColor = panel1.BackColor;
                    btnMorphology.BackColor = panel1.BackColor;
                    btnContour.BackColor = panel1.BackColor;
                    btnVDO.BackColor = panel1.BackColor;
                }
            }

        private void aboutus_Click(object sender, EventArgs e)
        {
                lblH.Text = "          About Us";
                facedetection1.Visible = false;
                convertToGray1.Visible = false;
                label2.Visible = false;
                contour1.Visible = false;
                edgeDetection1.Visible = false;
                about_US1.Visible = true;
                histogram1.Visible = false;
                vdo1.Visible = false;
                pictureBox2.Visible = false;
                imageBinarization1.Visible = false;
                morphology1.Visible = false;
                if (aboutus.Focused == true)
                {
                    btnFaceDetection.BackColor = panel1.BackColor;
                    btnHome.BackColor = panel1.BackColor;
                    btnConvertToGray.BackColor = panel1.BackColor;
                    btnHistogram.BackColor = panel1.BackColor;
                    panel5.BackColor = Color.DarkSlateGray;
                    btnImageBinarization.BackColor = panel1.BackColor;
                    btnEdgeDetection.BackColor = panel1.BackColor;
                    aboutus.BackColor = Color.DarkSlateGray;
                    btnMorphology.BackColor = panel1.BackColor;
                    btnContour.BackColor = panel1.BackColor;
                    btnVDO.BackColor = panel1.BackColor;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
 
   
    
    

    

