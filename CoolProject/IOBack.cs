using CoolProject.Controls;
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

namespace CoolProject
{
    public partial class IOBack : CVIOBase
    {
        public IOBack()
        {
            InitializeComponent();
        }

        public bool isEnabled
        {
            get => !currentImage.Equals(new Mat());
            private set
            {
                enabled = value;
            }
        }

        protected Mat currentImage = new(); // consider splitting into input and output so that mat can be public
        protected bool enabled = false;

        private void InputOutputBack_Load(object sender, EventArgs e)
        {
            AutoSize = false;

            if (this is OutputBox oBox)
            {
                outputs.Add(oBox); // subscribing the input boxes to the output boxes
                foreach (InputBox i in inputs)
                {
                    i.SubscribeToOutputs();
                }

            }
            else if (this is InputBox iBox) // must be output box 
            {
                inputs.Add(iBox); // subscribing the input boxes to the output boxes
                iBox.SubscribeToOutputs();
            }
        }
        public void UpdateName(object sender, OutputNameMatHandler e)
        {
            if (e.CurrentName == e.PreviousName) return;

            if (e.Mat.Equals(new Mat())) return;
            if (e.PreviousName != null) // there was something before
            {
                availableMats.Remove(e.PreviousName);
            }
            availableMats.Add(e.CurrentName, e.Mat);
        }
    }
}
