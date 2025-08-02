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
using Emgu.CV.Structure;

namespace CoolProject.Controls
{
    public partial class InRange : CVIOBase
    {
        int Map(int val, int accMin, int accMax, int otherMin, int otherMax) 
        {
            return (int)(((float)(val - accMin) / (accMax - accMin)) * (otherMax - otherMin));
        }
        List<Slider> sliders = new List<Slider>();
        private void SwitchColorSpace(string colorSpace) 
        {
            switch (colorSpace)
            {
                case "BGR":
                    slider1.MaxValue= 255;
                    slider2.MaxValue= 255;
                    slider3.MaxValue= 255;
                    slider4.MaxValue= 255;
                    slider5.MaxValue= 255;
                    slider6.MaxValue= 255;
                    break;
                case "HSV":
                    slider1.MaxValue= 179; // Hue range in OpenCV
                    slider2.MaxValue= 100; // Saturation range
                    slider3.MaxValue= 100; // Value range
                    slider4.MaxValue= 179;
                    slider5.MaxValue= 100;
                    slider6.MaxValue= 100;
                    break;
            }
        }
        public InRange()
        {
            InitializeComponent();
        }
        
        private void DoWork(object? sender, EventArgs e) 
        {
            int[] values =
                    {
                slider1.Value,
                slider2.Value,
                slider3.Value,
                slider4.Value,
                slider5.Value,
                slider6.Value
            };

            if (!inputBox1.isEnabled) return;

            Mat output = new();

            // Debug code...
            //Mat[] channels = inputBox1.CurrentImage.Split();
            //var max = channels[0].ToImage<Gray, byte>().Data.Cast<byte>().Max();


            values[1] = Map(values[1], 0, sliders[1].MaxValue, 0, 255);
            values[2] = Map(values[2], 0, sliders[2].MaxValue, 0, 255);
            values[4] = Map(values[4], 0, sliders[4].MaxValue, 0, 255);
            values[5] = Map(values[5], 0, sliders[5].MaxValue, 0, 255);


            CvInvoke.InRange
                (inputBox1.CurrentImage,
                (ScalarArray)new MCvScalar(values[0], values[1], values[2]),
                (ScalarArray)new MCvScalar(values[3], values[4], values[5]),
                output);
            outputBox1.CurrentImage = output;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newString = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < sliders.Count; i++)
            {
                sliders[i].Title = newString[i % 3].ToString();
            }
            SwitchColorSpace(newString);
            
        }

        private void InRange_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            SwitchColorSpace("BGR");
            inputBox1.Enabled = true;
            outputBox1.Enabled = true;

            sliders.Add(slider1);
            sliders.Add(slider2);
            sliders.Add(slider3);
            sliders.Add(slider4);
            sliders.Add(slider5);
            sliders.Add(slider6);

            inputBox1.ImageChanged += DoWork;
        }

    }
}
