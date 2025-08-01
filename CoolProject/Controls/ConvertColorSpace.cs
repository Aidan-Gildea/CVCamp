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

namespace CoolProject.Controls
{
    public partial class ConvertColorSpace : CVIOBase
    {
        public ConvertColorSpace()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = inputBox1.isEnabled;
        }

        private void ConvertColorSpace_Load(object sender, EventArgs e)
        {
            string[] items = { "HSV", "BGR", "GREYSCALE" };
            foreach (var item in items)
            {
                comboBox1.Items.Add(item);
                comboBox2.Items.Add(item);
            }
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 0;

            inputBox1.ImageChanged += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputBox1.CurrentImage.Equals(new Mat())) return;
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Please select different color spaces for conversion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using Mat newMat = new();

            if (comboBox1.Text == "HSV" && comboBox2.Text == "BGR")
            {
                CvInvoke.CvtColor(inputBox1.CurrentImage, newMat, Emgu.CV.CvEnum.ColorConversion.Hsv2Bgr);
                outputBox1.CurrentImage = newMat.Clone();
            }
            else if (comboBox1.Text == "BGR" && comboBox2.Text == "HSV")
            {
                CvInvoke.CvtColor(inputBox1.CurrentImage, newMat, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
                outputBox1.CurrentImage = newMat.Clone();
            }
            else if (comboBox1.Text == "BGR" && comboBox2.Text == "GREYSCALE")
            {
                CvInvoke.CvtColor(inputBox1.CurrentImage, newMat, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                outputBox1.CurrentImage = newMat.Clone();
            }
            else if (comboBox1.Text == "GREYSCALE" && comboBox2.Text == "BGR")
            {
                CvInvoke.CvtColor(inputBox1.CurrentImage, newMat, Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);
                outputBox1.CurrentImage = newMat.Clone();
            }
            else if (comboBox1.Text == "HSV" && comboBox2.Text == "GREYSCALE")
            {
                using Mat secondMat = new();
                CvInvoke.CvtColor(inputBox1.CurrentImage, newMat, Emgu.CV.CvEnum.ColorConversion.Hsv2Bgr);
                CvInvoke.CvtColor(newMat, secondMat, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                outputBox1.CurrentImage = secondMat.Clone();
            }
            else if (comboBox1.Text == "GREYSCALE" && comboBox2.Text == "HSV")
            {
                using Mat secondMat = new();
                CvInvoke.CvtColor(inputBox1.CurrentImage, newMat, Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);
                CvInvoke.CvtColor(newMat, secondMat, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
                outputBox1.CurrentImage = secondMat.Clone();
            }
            else
            {
                MessageBox.Show("Unsupported color space conversion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
