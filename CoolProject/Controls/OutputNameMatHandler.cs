using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;

namespace CoolProject.Controls
{
    public class OutputNameMatHandler
    {
        public string PreviousName 
        {
            get;
            private set;
        }

        public string CurrentName 
        {
            get;
            private set;
        }

        public Mat Mat 
        {
            get;
            private set;
        }
        public OutputNameMatHandler(string currName, string prevName, Mat mat) 
        {
            CurrentName = currName;
            PreviousName = prevName;
            Mat = mat;
        }

        
    }
}
