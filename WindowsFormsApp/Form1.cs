using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private VideoCapture vcapture;
        public Form1()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object? sender, EventArgs e)
        {
            using Mat workingMat = vcapture.QueryFrame(); // worked image
            using Mat backMat = workingMat.Clone(); // background

            CvInvoke.CvtColor(workingMat, workingMat, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv); // Convert to hsv

            CvInvoke.InRange
                (workingMat,
                (ScalarArray)new MCvScalar(0,Map(71,0,100,0,255), Map(15,0,100,0,255)),
                (ScalarArray)new MCvScalar(42,255,255),
                workingMat);

            CvInvoke.MedianBlur(workingMat, workingMat, 13); // Apply median blur

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat heirarchy = new Mat();
            CvInvoke.FindContours(workingMat, contours, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            CvInvoke.DrawContours(backMat, contours, -1, new MCvScalar(0, 255, 0), 2); // Draw contours on the background

            if(contours.Size != 0) 
            {
                Moments moments = CvInvoke.Moments(contours[0]);
                double centerX = moments.M10 / moments.M00;
                double centerY = moments.M01 / moments.M00;

                CvInvoke.DrawMarker(backMat, new Point((int)centerX, (int)centerY), new MCvScalar(0, 255, 0), MarkerTypes.Diamond, 20, 5);

                Rectangle rect = CvInvoke.BoundingRectangle(contours[0]); //find the bounding rect

                CvInvoke.Rectangle(backMat, rect, new MCvScalar(0, 255, 255), 5); //draw the bounding rect on the image
            }

            imageBox1.Image = backMat.Clone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vcapture = new(0);
            imageBox1.Size = new Size(1080, 720);
        }

        int Map(int val, int accMin, int accMax, int otherMin, int otherMax)
        {
            return (int)(((float)(val - accMin) / (accMax - accMin)) * (otherMax - otherMin));
        }

    }
}
