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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Please select different color spaces for conversion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(comboBox1.Text == "HSV" && comboBox2.Text == "BGR")
            {
                CvInvoke.CvtColor(inputBox1.CurrentImage, outputBox1.CurrentImage, Emgu.CV.CvEnum.ColorConversion.Hsv2Bgr);
            }
            else if(comboBox1.Text == "BGR" && comboBox2.Text == "HSV")
            {
                CvInvoke.CvtColor(inputBox1.CurrentImage, outputBox1.CurrentImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

                //Mat[] channels = outputBox1.CurrentImage.Split();
                //var max = channels[0].ToImage<Gray, byte>().Data.Cast<byte>().Max();

            }
            else if(comboBox1.Text == "BGR" && comboBox2.Text == "GREYSCALE") 
            {
                CvInvoke.CvtColor(inputBox1.CurrentImage, outputBox1.CurrentImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            }
            else
            {
                MessageBox.Show("Unsupported color space conversion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
