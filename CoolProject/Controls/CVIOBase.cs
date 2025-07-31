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
    public partial class CVIOBase : UserControl
    {
        protected Mat currentImage = new(); // consider splitting into input and output so that mat can be public
        protected Mat prevImage = new();
        protected bool enabled = false;

        protected static readonly Dictionary<string, Mat> availableMats = new();
        protected static readonly List<UserControl> inputs = new List<UserControl>();
        protected static readonly List<UserControl> outputs = new List<UserControl>();
        
        public bool isEnabled
        {
            get => !currentImage.Equals(new Mat());
            private set
            {
                enabled = value;
            }
        }

        public CVIOBase()
        {
            InitializeComponent();

        }

        // works 
        
        

    }
}
