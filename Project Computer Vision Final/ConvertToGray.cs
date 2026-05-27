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
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace Project_Computer_Vision_Final
{
    public partial class ConvertToGray : UserControl
    {
        Image<Bgr, byte> imgInput;
        Bitmap pict_C;
        public ConvertToGray()
        {
            InitializeComponent();
        }

        public Bitmap ConvertToGrayScale(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        public Bitmap ConvertToGrayScale2(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    //Luminance
                    int nP = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(nP, nP, nP));
                }
            }
            return bmp;
        }

        public Bitmap Thresholding1(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);

            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg > t)
                        avg = 255;
                    else avg = 0;

                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        public Bitmap Negative(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int r1, g1, b1;
                    r1 = 255 - (int)(c.R);
                    g1 = 255 - (int)(c.G);
                    b1 = 255 - (int)(c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return bmp;
        }

        public Bitmap Invert(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg == 255)
                        avg = 0;
                    else if (avg == 0)
                        avg = 255;

                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(InputImage.Image);
            OutputImage.Image = Invert(pict_C);
        }
        public Bitmap logTransformation(Bitmap source)
        {
            Bitmap log = new Bitmap(source.Width, source.Height);
            int C = int.Parse(textBox2.Text);

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color n = source.GetPixel(x, y);
                    int sR = (int)(C * Math.Log10(1 + n.R));
                    int sG = (int)(C * Math.Log10(1 + n.G));
                    int sB = (int)(C * Math.Log10(1 + n.B));
                    log.SetPixel(x, y, Color.FromArgb(n.A, sR, sG, sB));
                }
            }
            return log;
        }

        public Bitmap powerLaw(Bitmap source, double R)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int c = int.Parse(textBox3.Text.ToString().Trim());

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color renk = source.GetPixel(x, y);
                    double gd = ((double)R / 20);
                    int sR = (int)(c * Math.Pow((renk.R / 255.0), gd));
                    int sG = (int)(c * Math.Pow((renk.G / 255.0), gd));
                    int sB = (int)(c * Math.Pow((renk.B / 255.0), gd));
                    bmp.SetPixel(x, y, Color.FromArgb(renk.A, sR, sG, sB));
                }
            }
            return bmp;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(openFile.FileName);
                InputImage.Image = imgInput.Bitmap;
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
                OutputImage.Image.Save(saveImage.FileName);
                MessageBox.Show("Saving Complete");
            }
        }

        private void btnBlackWhile_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(InputImage.Image);
            OutputImage.Image = Thresholding1(pict_C);
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(InputImage.Image);
            OutputImage.Image = ConvertToGrayScale(pict_C);
        }

        private void grayScale2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(InputImage.Image);
            OutputImage.Image = ConvertToGrayScale2(pict_C);
        }

        private void btnNagative_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(InputImage.Image);
            OutputImage.Image = Negative(pict_C);
        }

        private void btnInvert_Click_1(object sender, EventArgs e)
        {
            pict_C = new Bitmap(InputImage.Image);
            OutputImage.Image = Invert(pict_C);
        }

        private void btn_Log_Transformation_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(InputImage.Image);
            OutputImage.Image = logTransformation(pict_C);
        }

        private void lblC_PowerLaw_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(InputImage.Image);
            OutputImage.Image = powerLaw(pict_C, double.Parse(textBox4.Text.ToString()));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblcPowerLaw_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
