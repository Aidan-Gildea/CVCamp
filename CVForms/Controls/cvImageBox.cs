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
    public partial class cvImageBox : UserControl
    {
        public cvImageBox()
        {
            InitializeComponent();
        }

        public string FilePath 
        {
            get => imageBox1.Image != null ? openFileDialog1.FileName : string.Empty;
            set { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult success = openFileDialog1.ShowDialog();
            if (success != DialogResult.OK) return;

            imageBox1.Image = CvInvoke.Imread(openFileDialog1.FileName);
            label1.Text = openFileDialog1.FileName;
        }
    }
}
