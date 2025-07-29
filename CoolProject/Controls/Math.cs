using Emgu.CV;
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
    public partial class Math : UserControl
    {
        List<string> operations = new List<string>()
        {
            "AND",
            "OR",
            "XOR",
            "ADD",
            "SUBTRACT",
            "MULTIPLY",
            "DIVIDE"
        };
        public Math()
        {
            InitializeComponent();
        }

        private void Math_Load(object sender, EventArgs e)
        {

            foreach (string value in operations)
            {
                comboBox1.Items.Add(value);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (inputBox1.Enabled && inputBox2.Enabled)
            {

                switch (comboBox1.Text)
                {
                    case "AND":
                        CvInvoke.BitwiseAnd(inputBox1.CurrentImage, inputBox2.CurrentImage, outputBox1.CurrentImage);
                        break;
                    case "OR":
                        CvInvoke.BitwiseOr(inputBox1.CurrentImage, inputBox2.CurrentImage, outputBox1.CurrentImage);
                        break;
                    case "XOR":
                        CvInvoke.BitwiseXor(inputBox1.CurrentImage, inputBox2.CurrentImage, outputBox1.CurrentImage);
                        break;

                    case "ADD":
                        CvInvoke.Add(inputBox1.CurrentImage, inputBox2.CurrentImage, outputBox1.CurrentImage);
                        break;

                    case "SUBTRACT":
                        CvInvoke.Subtract(inputBox1.CurrentImage, inputBox2.CurrentImage, outputBox1.CurrentImage);
                        break;

                    case "MULTIPLY":
                        CvInvoke.Multiply(inputBox1.CurrentImage, inputBox2.CurrentImage, outputBox1.CurrentImage);
                        break;

                    case "DIVIDE":
                        CvInvoke.Divide(inputBox1.CurrentImage, inputBox2.CurrentImage, outputBox1.CurrentImage);
                        break;
                    default:
                        return;

                }
            }
        }

        private void TestTimer_Tick(object sender, EventArgs e)
        {

        }

        private void inputBox1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateImage(object sender, EventArgs e) 
        {
           
        }
    }
}
