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

using Emgu.CV;

namespace CoolProject.Controls
{
    public partial class CVIOBase : UserControl
    {
        protected Mat currentImage = new(); // consider splitting into input and output so that mat can be public
        protected Mat prevImage = new();
        protected bool enabled = false;

        protected static readonly Dictionary<string, Mat> availableMats = new();
        
        public bool isEnabled
        {
            get => true;
            private set
            {
                enabled = value;
            }
        }

        public CVIOBase()
        {
            InitializeComponent();

            this.AutoSize = false;
        }

        

    }
}
