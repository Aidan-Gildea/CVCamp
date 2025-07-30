using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CVForms.Controls;
using Emgu.CV;

namespace CoolProject.Controls
{
    public partial class CVIOBase : UserControl
    {
        protected Mat currentImage = new(); // consider splitting into input and output so that mat can be public
        protected Mat prevImage = new();
        protected bool enabled = false;

        protected static readonly Dictionary<string, MatClass> availableMats = new();
        protected static readonly List<CVIOBase> controls = new();

        protected static System.Windows.Forms.Timer timer = new();


        private static void UpdateAllImages(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            get => !currentImage.Equals(new Mat());
            private set
=======
            foreach (CVIOBase control in controls)
>>>>>>> Stashed changes
            {
                if (control is not IOBox iobox) continue;
                
                // tell iobox to update its image to the 
                iobox.UpdateImage();
            }
        }

        public CVIOBase()
        {
            InitializeComponent();

            this.AutoSize = false;
            timer.Enabled = true;

            timer.Tick += UpdateAllImages;
        }

        private void CVIOBase_Load(object sender, EventArgs e)
        {
            ;
            if (sender is CVIOBase newS) 
            {
                controls.Add(newS);
            }
        }


    }
}
