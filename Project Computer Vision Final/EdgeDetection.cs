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
    public partial class EdgeDetection : UserControl
    {
        public EdgeDetection()
        {
            InitializeComponent();
        }

            int thr1, thr2, kSobel, kLapalcian;
            Image<Bgr, byte> imgInput;
            Image<Gray, byte> imgCanny;
            Image<Gray, float> imgSobel;
            Image<Gray, float> imgLaplacian;

            private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (imgInput == null)
                {
                    return;
                }
                imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
                imgCanny = imgInput.Canny(thr1, thr2);
                pictureBoxOutput.Image = imgCanny;
            }

            private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (imgInput == null)
                {
                    return;
                }
                Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
                imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

                imgSobel = imgGray.Sobel(1, 1, kSobel);
                pictureBoxOutput.Image = imgSobel;
            }

            private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
            {

                if (imgInput == null)
                {
                    return;
                }
                Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
                imgLaplacian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

                imgLaplacian = imgGray.Laplace(kLapalcian);
                pictureBoxOutput.Image = imgLaplacian;
            }

            private void txtThr1_KeyUp(object sender, KeyEventArgs e)
            {
                if (string.IsNullOrEmpty(txtThr1.Text))
                {
                    //MessageBox.Show("Not null");
                    return;
                }
                else
                {
                    if (imgInput == null)
                    {
                        return;
                    }
                    imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
                    imgCanny = imgInput.Canny(int.Parse(txtThr1.Text.ToString()), int.Parse(txtThr2.Text.ToString()));
                    pictureBoxOutput.Image = imgCanny;
                }
            }

            private void txtThr2_KeyUp(object sender, KeyEventArgs e)
            {
                if (string.IsNullOrEmpty(txtThr2.Text))
                {
                    //MessageBox.Show("Not null");
                    return;
                }
                else
                {
                    if (imgInput == null)
                    {
                        return;
                    }
                    imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
                    imgCanny = imgInput.Canny(int.Parse(txtThr1.Text.ToString()), int.Parse(txtThr2.Text.ToString()));
                    pictureBoxOutput.Image = imgCanny;
                }
            }

            private void txtKSizeSobel_KeyUp(object sender, KeyEventArgs e)
            {
                if (string.IsNullOrEmpty(txtKSizeSobel.Text))
                {
                    //MessageBox.Show("Not null");
                    return;
                }
                else
                {
                    if (imgInput == null)
                    {
                        return;
                    }
                    Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
                    imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

                    imgSobel = imgGray.Sobel(1, 1, int.Parse(txtKSizeSobel.Text.ToString()));
                    pictureBoxOutput.Image = imgSobel;
                }
            }

        private void EdgeDetection_Load(object sender, EventArgs e)
        {
            thr1 = int.Parse(txtThr1.Text);
            thr2 = int.Parse(txtThr2.Text);
            kSobel = int.Parse(txtKSizeSobel.Text);
            kLapalcian = int.Parse(txtKSizeLapalcian.Text);
        }

        private void txtKSizeLapalcian_KeyUp(object sender, KeyEventArgs e)
            {
                if (string.IsNullOrEmpty(txtKSizeLapalcian.Text))
                {
                    //MessageBox.Show("Not null");
                    return;
                }
                else
                {
                    if (imgInput == null)
                    {
                        return;
                    }
                    Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
                    imgLaplacian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

                    imgLaplacian = imgGray.Laplace(int.Parse(txtKSizeLapalcian.Text.ToString()));
                    pictureBoxOutput.Image = imgLaplacian;
                }
            }

            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new Image<Bgr, byte>(openFile.FileName);
                    pictureBoxInput.Image = imgInput;
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
                    pictureBoxOutput.Image.Save(saveImage.FileName);
                    MessageBox.Show("Saving Complete");
                }
            }
        }
    }
