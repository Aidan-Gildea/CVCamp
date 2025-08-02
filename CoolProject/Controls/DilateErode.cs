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

namespace CoolProject.Controls
{
    public partial class DilateErode : UserControl
    {
        public DilateErode()
        {
            InitializeComponent();
        }

        private void DoWork(object? sender, EventArgs e)
        {
            if (!inputBox1.isEnabled) return;
            Mat kernelSize = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new((int)numericUpDown1.Value, (int)numericUpDown1.Value), new(-1, -1));
            if (comboBox1.SelectedIndex == 0) // dilate 
            {
                CvInvoke.Dilate(inputBox1.CurrentImage, outputBox1.CurrentImage, kernelSize, new(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Constant, new(0, 0, 0));
            }
            else if (comboBox1.SelectedIndex == 1) // erode
            {
                CvInvoke.Erode(inputBox1.CurrentImage, outputBox1.CurrentImage, kernelSize, new(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Constant, new(0, 0, 0));
            }
        }
        private void DilateErode_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dilate"); 
            comboBox1.Items.Add("Erode");
            
            comboBox1.SelectedIndex = 0; // Default to Dilate

            inputBox1.ImageChanged += DoWork;
            
        }
    }
}
