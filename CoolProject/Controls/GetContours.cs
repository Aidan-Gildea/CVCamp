using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Microsoft.VisualBasic;
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
    public partial class GetContours : CVIOBase
    {
        private Color currentColor = Color.Blue;
        private int lineThickness => (int)numericUpDown1.Value;

        private Emgu.CV.CvEnum.ChainApproxMethod chainApproxMethod => GetApproxMethod();

        public GetContours()
        {
            InitializeComponent();
        }

        private void GetContours_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetNames<Emgu.CV.CvEnum.ChainApproxMethod>());
            comboBox1.SelectedIndex = 1;

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Value = 1;

            inputBox1.ImageChanged += button2_Click;
            inputBox2.ImageChanged += button2_Click;
        }

        private Emgu.CV.CvEnum.ChainApproxMethod GetApproxMethod() 
        {
            return Enum.Parse<Emgu.CV.CvEnum.ChainApproxMethod>(comboBox1.SelectedItem.ToString()
                                                                        ?? throw new Exception());
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e) // draw contours
        {
            if (inputBox1.isEnabled && inputBox2.isEnabled)
            {
                VectorOfVectorOfPoint contours = new();
                Mat heirarchy = new Mat();

                CvInvoke.FindContours(inputBox1.CurrentImage, contours, heirarchy, Emgu.CV.CvEnum.RetrType.External, chainApproxMethod);

                Mat bgimage = inputBox2.CurrentImage.Clone();

                CvInvoke.DrawContours(bgimage, contours, -1, new MCvScalar(255,0,0), lineThickness);
                
                outputBox1.CurrentImage = bgimage;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result != DialogResult.OK) return;

            currentColor = colorDialog1.Color;
        }
    }
}
