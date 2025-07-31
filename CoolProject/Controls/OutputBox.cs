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
    public partial class OutputBox : IOBack
    {
        public event EventHandler ImageChanged;
        public event EventHandler<OutputNameMatHandler> NameChanged;

        private string previousName = null;

        public Mat CurrentImage
        {
            get => currentImage;
            set
            {
                currentImage = value;
                imageBox1.Image = currentImage;

                ImageChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public OutputBox()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string currName = textBox1.Text;
            Mat currMat = CurrentImage.Clone();

            OutputNameMatHandler nameMatHandler = new(currName, previousName, currMat);

            NameChanged?.Invoke(this, nameMatHandler);
            previousName = currName;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (!currentImage.Equals(new Mat()))
            {
                enabled = true;


            }
            imageBox1.Image = currentImage;
        }

        private void OutputBox_Load(object sender, EventArgs e)
        {
            NameChanged += UpdateAvailableMats;
        }
    }
}
