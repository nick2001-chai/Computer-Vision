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

namespace Project_Computer_Vision_Final
{
    public partial class VDO : UserControl
    {
        VideoCapture capture;
        Mat frame;
        bool play;
        Image<Gray, byte> grayVDO, binaryVDO;
        public VDO()
        {
            InitializeComponent();
        }
        
            private void ProcessFrame1(object sender, EventArgs e)
            {
                if (capture != null)
                {
                    capture.Retrieve(frame);
                    imgBoxVDO.Image = frame.ToImage<Bgr, byte>();
                }
            }

            private void ProcessFrame2(object sender, EventArgs e)
            {
                grayVDO = frame.ToImage<Gray, byte>();
                binaryVDO = grayVDO.ThresholdBinary(new Gray(150), new Gray(255));
                imgBoxVDO.Image = binaryVDO;
            }

            private void ProcessFram3(object sender, EventArgs e)
            {
                grayVDO = frame.ToImage<Gray, byte>();
                imgBoxVDO.Image = grayVDO;

            }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    btnPlay.Visible = true; btnPause.Visible = true;
                    btnStop.Visible = true; btnGray.Visible = false;
                    btnBinary.Visible = false; btnCapture.Visible = false;
                    btnSave.Visible = false;

                    Application.Idle -= ProcessFrame1;
                    Application.Idle -= ProcessFrame2;
                    Application.Idle -= ProcessFram3;
                    imgBoxVDO.Image = null;

                    OpenFileDialog opf = new OpenFileDialog();
                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        capture = new VideoCapture(opf.FileName);
                        Mat matrix = new Mat();
                        capture.Read(matrix);
                        imgBoxVDO.Image = matrix;
                    }
                }
                else if (comboBox1.SelectedIndex == 0)
                {
                    btnPlay.Visible = false; btnPause.Visible = false;
                    btnStop.Visible = false; btnGray.Visible = true;
                    btnBinary.Visible = true; btnCapture.Visible = true;
                    btnSave.Visible = true;

                capture = new VideoCapture(0);
                    frame = new Mat();
                    Application.Idle += ProcessFrame1;
                }
            }

            private void btnGray_Click(object sender, EventArgs e)
            {
                //Testing Gray VDO
                if (!frame.IsEmpty)
                {
                    Application.Idle += ProcessFram3;
                }
            }

            private void btnBinary_Click(object sender, EventArgs e)
            {
                //Testing Binary VDO
                if (!frame.IsEmpty)
                {
                    Application.Idle += ProcessFrame2;
                }
            }

            private void btnCapture_Click(object sender, EventArgs e)
            {
                imgCapture.Image = imgBoxVDO.Image;
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                SaveFileDialog svf = new SaveFileDialog();
                svf.Title = " Save Capture Image";
                svf.DefaultExt = ".*jpg";
                svf.Filter = "Jpg Files(*.jpg)|*.jpg";
                if (svf.ShowDialog() == DialogResult.OK)
                {
                    imgCapture.Image.Save(svf.FileName);
                    imgCapture.Image = null;
                }
            }

            private void btnPause_Click(object sender, EventArgs e)
            {
                play = false;
            }

            private void btnStop_Click(object sender, EventArgs e)
            {
                play = false;
                imgBoxVDO.Image = null;
                imgBoxVDO.Refresh();
            }

        private void VDO_Load(object sender, EventArgs e)
        {

            btnGray.Visible = false;
            btnBinary.Visible = false;
            btnPlay.Visible = false;
            btnPause.Visible = false;
            btnStop.Visible = false;
            btnCapture.Visible = false;
            btnSave.Visible = false;

        }

        private async void btnPlay_Click(object sender, EventArgs e)
            {
                play = true;
                if (capture == null)
                {
                    return;
                }
                else
                {
                    while (play == true)
                    {
                        Mat matrix = new Mat();
                        capture.Read(matrix);
                        if (!matrix.IsEmpty)
                        {
                            imgBoxVDO.Image = matrix.ToImage<Bgr, byte>();
                            double fps = capture.GetCaptureProperty(CapProp.Fps);
                            await Task.Delay(1000 / Convert.ToInt32(fps));
                        }
                        else
                            break;
                    }
                }
            }
        }
    }

