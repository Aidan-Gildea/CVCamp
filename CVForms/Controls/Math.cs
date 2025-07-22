using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (imageBox1.TextIsEnabled == true && imageBox2.TextIsEnabled == true)
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
            Bitmap image1 = imageBox1.PictureBox.Image as Bitmap;
            Bitmap image2 = imageBox2.PictureBox.Image as Bitmap;

            if(image1.Width != image2.Width || image1.Height != image2.Height)
            {
                MessageBox.Show("Images must be of the same size for mathematical operations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap newImage = new Bitmap(image1.Width, image1.Height);

            for(int y = 0; y < newImage.Height; y++) 
            {
                for(int x = 0; x < newImage.Width; x++) 
                {
                    Color pixel1 = image1.GetPixel(x, y);
                    Color pixel2 = image2.GetPixel(x, y);

                    int val; 
                    switch (comboBox1.Text.ToUpper()) 
                    {
                        case "AND":
                            val = pixel1.ToArgb() & pixel2.ToArgb();
                            break;
                        case "OR":
                            val = pixel1.ToArgb() | pixel2.ToArgb();
                            break;
                        case "XOR":
                            val = (pixel1.ToArgb() ^ pixel2.ToArgb()) | byte.MaxValue << 24;
                            break;
                        default:
                            MessageBox.Show("Unsupported operation: " + comboBox1.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                            
                    }

                    newImage.SetPixel(x, y, Color.FromArgb(val));
                }
            }

            imageBox3.PictureBox.Image = newImage;
        }
    }
}
