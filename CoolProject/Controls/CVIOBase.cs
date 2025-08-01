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
        protected static readonly List<IOBack> inputs = new List<IOBack>();
        protected static readonly List<IOBack> outputs = new List<IOBack>();

        
        
        public bool isEnabled => !currentImage.Equals(new Mat());



        public CVIOBase()
        {
            InitializeComponent();
        }

        // works 
        
        

    }
}
