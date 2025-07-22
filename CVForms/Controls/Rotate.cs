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
    public partial class Rotate : UserControl
    {
        string PreviousState;
        public Rotate()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageBox1.TextIsEnabled) 
            {
                comboBox1.Enabled = true;
            }
            if (imageBox1.TextIsEnabled && PreviousState != comboBox1.Text)
            {
                PreviousState = comboBox1.Text;
                PerformOperation();
            }
        }

        private void Rotate_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;

            PreviousState = comboBox1.Text;
        }

        void PerformOperation() 
        {
            Bitmap image1 = imageBox1.PictureBox.Image as Bitmap;
            Bitmap outImage;
            if(image1.Width >= image1.Height) 
            {
                outImage = new(image1.Width, image1.Width);

            }
            else 
            {
                outImage = new(image1.Height, image1.Height);

            }

            int outerWidth = image1.Width - 1;
            int outerHeight = image1.Height - 1; 

            for (int y = 0; y < image1.Height; y++) 
            {
                for (int x = 0; x < image1.Width; x++) 
                {

                    switch (comboBox1.Text.ToUpper()) 
                    {
                        case "ROTATE 90":
                            outImage.SetPixel(outerWidth-y, x, image1.GetPixel(x, y));
                            break;
                        case "ROTATE -90":
                            outImage.SetPixel(y, outerHeight - x, image1.GetPixel(x, y));
                            break;
                        case "NOT":
                            Color pixelColor = image1.GetPixel(x, y);
                            int val = pixelColor.ToArgb() ^ int.MaxValue;
                            outImage.SetPixel(x, y, Color.FromArgb(val));
                            break;
                    }
                    

                } 

            }
            imageBox2.PictureBox.Image = outImage;
        }
    }
}
