using Emgu.CV;
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
    public partial class OutputBox : IOBox
    {
        
        public Mat CurrentImage
        {
            get => currentImage;
            set
            {
                currentImage = value;
                imageBox1.Image = currentImage;
<<<<<<< Updated upstream
=======
                if (availableMats.ContainsKey(textBox1.Text)) 
                {
                    availableMats[textBox1.Text].mat = value;
                }
>>>>>>> Stashed changes

            }
        }

        public OutputBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ;
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                if (imageBox1.Image != null)
                {
                    if (!availableMats.ContainsKey(textBox1.Text))
                    {
<<<<<<< Updated upstream
                        availableMats.Add(textBox1.Text, imageBox1.Image as Mat);
=======
                        //availableMats.Add(textBox1.Text, new()currentImage);
>>>>>>> Stashed changes
                    }
                    else
                    {
                        MessageBox.Show("This already exists buddy");
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputBox_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (!currentImage.Equals(new Mat()))
            {
                enabled = true;


            }
            imageBox1.Image = currentImage;
        }
    }
}
