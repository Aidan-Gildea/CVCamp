using Emgu.CV;
using Emgu.CV.Dai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolProject.Controls
{
    public partial class VCapture : CVIOBase
    {
        public VCapture()
        {
            InitializeComponent();
            Application.Idle += GrabFrameWhileIdle;
        }

        private VideoCapture capture;
        private int exposure => slider1.Value;

        private bool isChecked = false;

        private void GetImage()
        {
            if (!capture.IsOpened)
            {
                return;
            }
            if (!capture.Grab())
            {
                return;
            }
            Mat currentFrame = capture.QueryFrame(); // exposure currently not set. 
            outputBox1.CurrentImage = currentFrame;
        }

        private void GrabFrameWhileIdle(object sender, EventArgs e)
        {
            if (!capture.IsOpened)
            {
                return;
            }
            if (!capture.Grab())
            {
                return;
            }
            using Mat currentFrame = capture.QueryFrame(); // exposure currently not set. 
            imageBox1.Image = currentFrame;

            if (checkBox1.Checked) 
            {
                outputBox1.CurrentImage = currentFrame;
            }
        }

        private void VCapture_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetImage();
        }

        private void slider1_InputChanged(object sender, EventArgs e)
        {
            capture.Set(Emgu.CV.CvEnum.CapProp.Exposure, slider1.Value - 8); // magic number
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
