using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;

namespace CoolProject.Controls
{
    public class MatClass
    {
        public Mat mat;

        public bool isEdited; 
        public Mat Mat
        {
            get => mat;
            set 
            {
                mat = value;
                isEdited = true;
            }
        }
        public MatClass(Mat mat) 
        {
            this.mat = mat; 
        }
    }
}
