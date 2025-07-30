using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolProject.Controls
{
    public partial class InputBox : IOBox
    {
<<<<<<< Updated upstream
=======
        
>>>>>>> Stashed changes

        public Mat CurrentImage
        {
            get => currentImage;
<<<<<<< Updated upstream
            set
            {
                currentImage = value;
                imageBox1.Image = currentImage;
            }
=======
            set 
            {
                currentImage = value;
                if (currentImage != null) 
                {
                    imageBox1.Image = currentImage;
                } 
            } 
>>>>>>> Stashed changes
        }

        public InputBox()
        {
            InitializeComponent();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK) return;

            CurrentImage = CvInvoke.Imread(openFileDialog1.FileName);

            imageBox1.Image = currentImage;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e) { }

        private void comboBox1_TextUpdate(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Length > 0)
            {
                if (availableMats.ContainsKey(comboBox1.Text))
                { 
                    CurrentImage = availableMats[comboBox1.Text].mat;
                }
                
            }
        }

        public override void UpdateImage()
        {
            if (availableMats.ContainsKey(comboBox1.Text)) 
            {
                // the text is valid 
                if (availableMats[comboBox1.Text].isEdited) 
                {
                    CurrentImage = availableMats[comboBox1.Text].mat;

                }
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!currentImage.Equals(new Mat()))
            {
                enabled = true;
                
                
            }
            imageBox1.Image = currentImage;
        }

        private void comboBox1_DropDown(object sender, EventArgs e) // update items whenever you open dropdown
        {
            foreach (string val in availableMats.Keys)
            {
                if (!comboBox1.Items.Contains(val))
                {
                    comboBox1.Items.Add(val);
                }
            }
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e) { }
    }
}
