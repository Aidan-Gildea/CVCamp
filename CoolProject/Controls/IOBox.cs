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
    public partial class IOBox : CVIOBase
    {

        public virtual void UpdateImage() { return; throw new NotImplementedException(); }
        public bool isEnabled
        {
            get => true;
            private set
            {
                enabled = value;
            }
        }

        public IOBox()
        {
            InitializeComponent();
        }
    }
}
