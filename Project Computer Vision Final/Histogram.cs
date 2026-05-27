using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;


namespace Project_Computer_Vision_Final
{
    public partial class Histogram : UserControl
    {
        public Histogram()
        {
            InitializeComponent();
        }
            Image<Bgr, byte> oriImage;
            Image<Gray, byte> R, G, B;

            private void radioR_CheckedChanged(object sender, EventArgs e)
            {
                if (radioR.Checked)
                {
                    imgOutput.Image = R;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(R, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show("Gray is from Red Channel");
                }
            }

            private void radioG_CheckedChanged(object sender, EventArgs e)
            {
                if (radioG.Checked)
                {
                    imgOutput.Image = G;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(G, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show("Gray is from Green Channel");
                }
            }

            private void radioB_CheckedChanged(object sender, EventArgs e)
            {

                if (radioB.Checked)
                {
                    imgOutput.Image = B;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(B, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show("Gray is from Blue Channel");
                }
            }

            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SaveFileDialog saveImage = new SaveFileDialog();
                saveImage.Title = "Save Processed Image";
                saveImage.DefaultExt = "*.jpg";
                saveImage.Filter = "Jpeg Files (.jpg)|.jpg|PNG files (.png)|.png|BMP files (.bmp)|.bmp";

                if (saveImage.ShowDialog() == DialogResult.OK)
                {
                    imgOutput.Image.Save(saveImage.FileName);
                    MessageBox.Show("Saving Complete");
                }
            }

            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {

                OpenFileDialog opendialog = new OpenFileDialog();
                if (opendialog.ShowDialog() == DialogResult.OK)
                {
                    oriImage = new Image<Bgr, byte>(opendialog.FileName);
                    B = oriImage[0];
                    G = oriImage[1];
                    R = oriImage[2];
                    imgInput.Image = oriImage;
                    if (radioR.Checked)
                    {
                        imgOutput.Image = R;
                        histogramBox1.ClearHistogram();
                        histogramBox1.GenerateHistograms(R, 256);
                        histogramBox1.Refresh();
                        MessageBox.Show("Gray is from Red Channel");
                    }

                    else if (radioG.Checked)
                    {
                        imgOutput.Image = G;
                        histogramBox1.ClearHistogram();
                        histogramBox1.GenerateHistograms(G, 256);
                        histogramBox1.Refresh();
                        MessageBox.Show("Gray is from Green Channel");
                    }
                    else
                    {
                        imgOutput.Image = B;
                        histogramBox1.ClearHistogram();
                        histogramBox1.GenerateHistograms(B, 256);
                        histogramBox1.Refresh();
                        MessageBox.Show("Gray is from Blue Channel");
                    }
                }
            }
        }
    }
