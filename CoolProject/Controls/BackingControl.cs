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

namespace CoolProject.Controls
{
    public partial class BackingControl : UserControl
    {
        private int width;
        private int height;

        protected static readonly Dictionary<string, MatHolder> availableMats = new();
        public BackingControl()
        {
            InitializeComponent();

            this.AutoSize = false;
        }

        

    }
}
