using Emgu.CV;
using Microsoft.VisualBasic;
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
    public partial class Math : UserControl
    {
        List<string> operations = new List<string>()
        {
            "AND",
            "OR",
            "XOR",
            "ADD",
            "SUBTRACT",
            "MULTIPLY",
            "DIVIDE"
        };
        public Math()
        {
            InitializeComponent();
        }

        private void Math_Load(object sender, EventArgs e)
        {

            foreach (string value in operations)
            {
                comboBox1.Items.Add(value);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(selectionBox1.Enabled && selectionBox2.Enabled) 
            {
                switch(comboBox1.Text)
                {
                    case "AND":
                        CvInvoke.BitwiseAnd(selectionBox1.image, selectionBox2.image, selectionBox3.currentImage);
                        break;
                }
            }
        }
    }
}
