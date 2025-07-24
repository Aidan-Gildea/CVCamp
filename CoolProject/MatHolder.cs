using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using Emgu.CV;

namespace CoolProject
{
    public class MatHolder
    {
        public Mat mat;
        public string FileName;

        public MatHolder(string FileName) 
        {
            this.FileName = FileName;
            mat = CvInvoke.Imread(FileName);
        }
    }
}
