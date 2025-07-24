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
    public partial class SelectionBox : BackingControl
    {
        public Mat currentImage = new(); // consider splitting into input and output so that mat can be public
        public SelectionBox()
        {
            InitializeComponent();
        }

        public bool Enabled { get => currentImage != null; }
        
        public Mat image { get => currentImage; set
            {
                currentImage = value;
                imageBox1.Image = currentImage;
            }
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK) return;

            this.currentImage = CvInvoke.Imread(openFileDialog1.FileName);

            imageBox1.Image = currentImage;

            label1.Text = openFileDialog1.FileName;

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
            if (availableMats.Keys.Contains(comboBox1.Text))
            {

                imageBox1.Image = currentImage;

                label1.Text = openFileDialog1.FileName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != string.Empty && currentImage == null)
            {
                if (availableMats.Keys.Contains(comboBox1.Text)) 
                {
                    currentImage = availableMats[comboBox1.Text].mat;

                    imageBox1.Image = currentImage;

                    label1.Text = availableMats[comboBox1.Text].FileName; // could make class to hold the mat and filename
                    return;
                }
            }
            if (comboBox1.Text != string.Empty && currentImage != null)
            {
                if (availableMats.Keys.Contains(comboBox1.Text)) 
                {
                    MessageBox.Show("Name already exists");
                    return;
                }
                availableMats.Add(comboBox1.Text, new(openFileDialog1.FileName));
            }
            else MessageBox.Show("Unfulfilled ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            foreach (string val in availableMats.Keys)
            {
                if (!comboBox1.Items.Contains(val))
                {
                    comboBox1.Items.Add(val);
                }
            }
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (availableMats.Keys.Contains(comboBox1.Text))
            {


            }
        }
    }
}
