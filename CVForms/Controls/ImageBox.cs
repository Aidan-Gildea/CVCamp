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
    public partial class ImageBox : UserControl
    {
        public ImageBox()
        {
            InitializeComponent();
        }

        private bool enabled = true;
        public bool TextIsEnabled 
        {
            get => textBox.Text.Length != 0;
            set 
            {
            }
        }

        public string FilePath
        {
            get => openFileDialog.FileName;
            set { }
        }

        public PictureBox PictureBox
        {
            get => pictureBox;
            set => pictureBox = value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult != DialogResult.OK) return;

            string FilePath = openFileDialog.FileName;

            textBox.Text = FilePath;
            pictureBox.Image = Image.FromFile(FilePath);

        }
    }
}
