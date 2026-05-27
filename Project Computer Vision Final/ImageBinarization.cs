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
using Emgu.CV.CvEnum;
using Emgu.Util;


namespace Project_Computer_Vision_Final
{
    public partial class ImageBinarization : UserControl
    {
        public ImageBinarization()
        {
            InitializeComponent();
        }
            Image<Bgr, byte> imageInput;
            Image<Gray, byte> imageGray;
            Image<Gray, byte> imageBinarize;
            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    imageInput = new Image<Bgr, byte>(openFile.FileName);
                    pictureBoxOrigin.Image = imageInput.Bitmap;

                }
            }

            private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
            {
                imageGray = imageInput.Convert<Gray, byte>();
                pictureBoxOrigin.Image = imageGray.Bitmap;

                //binarization Simple Thresolding
                imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));
                CvInvoke.Threshold(imageGray, imageBinarize, 100, 255, ThresholdType.Binary);
                pictureBoxOutput.Image = imageBinarize.Bitmap;
            }

            private void binaryInvertToolStripMenuItem_Click(object sender, EventArgs e)
            {
                imageGray = imageInput.Convert<Gray, byte>();
                pictureBoxOrigin.Image = imageGray.Bitmap;

                //binarization Simple Thresolding
                imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));
                CvInvoke.Threshold(imageGray, imageBinarize, 100, 255, ThresholdType.BinaryInv);
                pictureBoxOutput.Image = imageBinarize.Bitmap;
            }

            private void oTSuToolStripMenuItem_Click(object sender, EventArgs e)
            {
                imageGray = imageInput.Convert<Gray, byte>();
                pictureBoxOrigin.Image = imageGray.Bitmap;

                //binarization Simple Thresolding
                imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));
                CvInvoke.Threshold(imageGray, imageBinarize, 100, 255, ThresholdType.Otsu);
                pictureBoxOutput.Image = imageBinarize.Bitmap;
            }

            private void guassianToolStripMenuItem_Click(object sender, EventArgs e)
            {

                pictureBoxOrigin.Image = imageGray.Bitmap;

                //binarization Adaptive Thresolding
                imageBinarize = imageGray.ThresholdAdaptive(new Gray(256.0), AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 3, new Gray(0.0));
                pictureBoxOutput.Image = imageBinarize.Bitmap;
            }

            private void meanToolStripMenuItem_Click(object sender, EventArgs e)
            {
                imageGray = imageInput.Convert<Gray, byte>();
                pictureBoxOrigin.Image = imageGray.Bitmap;
                //binarization Adaptive Thresolding
                imageBinarize = imageGray.ThresholdAdaptive(new Gray(256.0), AdaptiveThresholdType.MeanC, ThresholdType.Binary, 3, new Gray(0.0));
                pictureBoxOutput.Image = imageBinarize.Bitmap;
            }

            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SaveFileDialog saveImage = new SaveFileDialog();
                saveImage.Title = "Save Processed Image";
                saveImage.DefaultExt = "*.jpg";
                saveImage.Filter = "Jpeg Files (.jpg)|.jpg|PNG files (.png)|.png|BMP files (.bmp)|.bmp";

                if (saveImage.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxOutput.Image.Save(saveImage.FileName);
                    MessageBox.Show("Saving Complete");
                }
            }
        }
    }
