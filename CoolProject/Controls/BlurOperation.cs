using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CVForms.Controls;
using Emgu.CV;

namespace CoolProject.Controls
{

    public partial class BlurOperation : CVIOBase
    {
        public class BlurType

        {

            private string name;
            public Action<int> action;
            public BlurType(Action<int> Action, string Name)
            {
                action = Action;
                name = Name;
            }

            public override string ToString()
            {
                return name;
            }
        }

        //public class BlurType(Action<Mat, Mat, Size> action) 
        //{
        //    public Action<Mat, Mat, Size> Action { get; set; } = action;

        //}
        private bool hidden = false;
        public BlurOperation()
        {
            InitializeComponent();
        }

        private void BlurOperation_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox1.Items.Add(new BlurType((val) => CvInvoke.Blur(inputBox1.CurrentImage, outputBox1.CurrentImage, new(val, val), new(-1, -1)), "StandardBlur"));
            comboBox1.Items.Add(new BlurType((val) => CvInvoke.MedianBlur(inputBox1.CurrentImage, outputBox1.CurrentImage, val), "MedianBlur"));
            comboBox1.Items.Add(new BlurType((val) => CvInvoke.StackBlur(inputBox1.CurrentImage, outputBox1.CurrentImage, new(val, val)), "StackBlur"));

            inputBox1.ImageChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(inputBox1.isEnabled) 
            {
                BlurType blurtype = (BlurType)comboBox1.SelectedItem;
                if (blurtype == null) return;
                blurtype.action((int)numericUpDown1.Value);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (inputBox1.isEnabled)
            {
                comboBox1.Enabled = true;
                //comboBox1_SelectedIndexChanged(sender, e);
            }
        }
    }
}
