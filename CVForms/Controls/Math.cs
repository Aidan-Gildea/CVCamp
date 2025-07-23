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

namespace CVForms.Controls
{
    public partial class Math : UserControl
    {
        public Math()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cvImageBox1.FilePath != "" && cvImageBox2.FilePath != "")
            {
                comboBox1.Enabled = true;

                if (comboBox1.Text != "")
                {
                    button1.Enabled = true;

                }

            }
        }





        private void Math_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            comboBox1.Enabled = false;
            comboBox1.Text = "AND";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mat mat1 = CvInvoke.Imread(cvImageBox1.FilePath);
            Mat mat2 = CvInvoke.Imread(cvImageBox2.FilePath);
            Mat mat3 = new();


            MessageBox.Show(comboBox1.Text + "-ing");


            switch (comboBox1.Text) 
            {
                case "AND":
                    CvInvoke.BitwiseAnd(mat1, mat2, mat3);
                    break;
                case "OR":
                    CvInvoke.BitwiseOr(mat1, mat2, mat3);
                    break;
                case "XOR":
                    CvInvoke.BitwiseXor(mat1, mat2, mat3);
                    break;
                default:
                    MessageBox.Show("Invalid operation selected.");
                    return;
            }
            imageBox1.Image = mat3;
        }
    }
}
