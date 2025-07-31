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
    public partial class InputBox : CVIOBase
    {
        public event EventHandler ImageChanged;
        public Mat CurrentImage
        {
            get
            {
                // here this is updating to the value

                UpdateCurrentImage();
                return currentImage;

            }
            set
            {
                //currentImage?.Dispose();
                currentImage = value;
                imageBox1.Image = currentImage;
                ImageChanged?.Invoke(this, EventArgs.Empty);
                //ImageChanged?.Invoke(this, new EventArgs());
            }
        }

        public InputBox()
        {
            InitializeComponent();
        }

        private void UpdateCurrentImage() => CurrentImage = availableMats.ContainsKey(comboBox1.Text) ? availableMats[comboBox1.Text] : currentImage;
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
            if (comboBox1.Text.Length > 0)
            {
                if (availableMats.ContainsKey(comboBox1.Text))
                {
                    CurrentImage = availableMats[comboBox1.Text];
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!currentImage.Equals(new Mat()))
            {
                enabled = true;


            }
            

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

        private void InputBox_Load(object sender, EventArgs e)
        {

        }
    }
}
