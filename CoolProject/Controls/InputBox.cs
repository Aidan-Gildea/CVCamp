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
    public partial class InputBox : IOBack
    {
        public event EventHandler ImageChanged;
        public Mat CurrentImage
        {
            get => currentImage;
            set
            {
                // possibly add a dispose here for memory leaks. 
                currentImage = value;
                imageBox1.Image = currentImage;
            }
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


        public void DoWork()
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e) { }

        private void comboBox1_TextUpdate(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (InputBox i in inputs)
            {
                i.SubscribeToOutputs();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (!currentImage.Equals(new Mat()))
            //{
            //    enabled = true;


            //}
            //imageBox1.Image = CurrentImage;
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

        public void SubscribeToOutputs()
        {
            foreach(OutputBox o in outputs) 
            {
                if (o.Parent.Equals(Parent)) continue;
                if (o.CurrentName != comboBox1.Text) continue; 
                o.ImageChanged += CallImageChanged;
            }
        }
        private void InputBox_Load(object sender, EventArgs e)
        {
            // image changed event isn't working because I can't subscribe event to event. 
            ImageChanged += UpdateImage;
        }

        private void CallImageChanged(object sender, EventArgs e) 
        {
            ImageChanged?.Invoke(this, new());
        }

        private void UpdateImage(object sender, EventArgs e) 
        {
            if (comboBox1.Text.Length > 0)
            {
                if (availableMats.ContainsKey(comboBox1.Text))
                {
                    CurrentImage = availableMats[comboBox1.Text];
                }

            }
        }
    }
}
