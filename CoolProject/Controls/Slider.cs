using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolProject.Controls
{
    public partial class Slider : CVIOBase
    {
        public int MaxValue
        {
            get => trackBar1.Maximum;
            set  
                
            {
                trackBar1.Maximum = value;
                numericUpDown1.Maximum = value;
                
            } 
        }

        public string Title
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public int Value
        {
            get => trackBar1.Value;
            set
            {
                if (value < trackBar1.Minimum || value > trackBar1.Maximum)
                    throw new ArgumentOutOfRangeException(nameof(value), "Value must be within the range of the slider.");
                trackBar1.Value = value;
            }
        }
        public Slider()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            numericUpDown1.Value = trackBar1.Value;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
        }
    }
}
