using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Numerics;
using System.Runtime.CompilerServices;
namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private VideoCapture vcapture;

        Rectangle paddle1;
        Rectangle paddle2;
        Rectangle ball;


        Point paddle2Pos = new Point(100, 360);
        int paddle2Speed = 10; // Speed of the second paddle

        Point ballPos = new Point(0, 0);
        Point ballVel = new Point(3, 3);

        int paddleNextHit = 1;

        HashSet<Keys> pressedKeys = new();
        public Form1()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object? sender, EventArgs e)
        {
            // --------------------------Paddle Detection--------------------------
            using Mat workingMat = vcapture.QueryFrame(); // worked image

            CvInvoke.Flip(workingMat, workingMat, FlipType.Horizontal); // Flip the image horizontally if needed

            using Mat backMat = workingMat.Clone(); // background



            CvInvoke.CvtColor(workingMat, workingMat, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv); // Convert to hsv

            CvInvoke.InRange
                (workingMat,
                (ScalarArray)new MCvScalar(0, Map(71, 0, 100, 0, 255), Map(15, 0, 100, 0, 255)),
                (ScalarArray)new MCvScalar(42, 255, 255),
                workingMat);

            CvInvoke.MedianBlur(workingMat, workingMat, 13); // Apply median blur

            using VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            using Mat heirarchy = new Mat();
            CvInvoke.FindContours(workingMat, contours, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            CvInvoke.DrawContours(backMat, contours, -1, new MCvScalar(0, 255, 0), 2); // Draw contours on the background

            CvInvoke.Rectangle(backMat, ball, new MCvScalar(255, 255, 255), -1);

            CvInvoke.Rectangle(backMat, paddle2, new(255, 0, 0), -2);

            if (contours.Size == 0)
            {
                imageBox1.Image = backMat;
                return;
            }

            List<Rectangle> rects = new List<Rectangle>();

            for (int i = 0; i < contours.Size; i++)
            {
                using Moments moments = CvInvoke.Moments(contours[i]);
                double centerX = moments.M10 / moments.M00;
                double centerY = moments.M01 / moments.M00;

                CvInvoke.DrawMarker(backMat, new Point((int)centerX, (int)centerY), new MCvScalar(0, 255, 0), MarkerTypes.Diamond, 20, 5);

                rects.Add(CvInvoke.BoundingRectangle(contours[i])); //find the bounding rect

            }
            paddle1 = rects[rects.GetLargestIndex()]; //get the largest rect
            CvInvoke.Rectangle(backMat, paddle1, new MCvScalar(0, 255, 0), -1); //draw the bounding rect on the image



            imageBox1.Image?.Dispose();
            imageBox1.Image = backMat;

            // ---------------------------------------------------------------

            BallDetection(sender, e); // Call the ball detection method
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vcapture = new(0);
            imageBox1.Size = new Size(vcapture.Width, vcapture.Height);
            timer1.Enabled = true; // Enable the timer to call Application_Idle periodically
            timer1.Tick += BallDetection;
            //vcapture.FlipHorizontal = true; // Flip the camera horizontally if needed
        }

        int Map(int val, int accMin, int accMax, int otherMin, int otherMax)
        {
            return (int)(((float)(val - accMin) / (accMax - accMin)) * (otherMax - otherMin));
        }

        private void BallDetection(object? sender, EventArgs e)
        {
            if (pressedKeys.Contains(Keys.W))
            {
                paddle2Pos.Y -= paddle2Speed; // Move paddle2 up

            }
            else if (pressedKeys.Contains(Keys.S))
            {
                paddle2Pos.Y += paddle2Speed;
            }  
            


            paddle2Pos = new Point(paddle2Pos.X, paddle2Pos.Y); // Move paddle2 down
            paddle2 = new Rectangle(paddle2Pos.X, paddle2Pos.Y, 50, 75); // Create a rectangle for paddle2

            ballPos = new Point(ballPos.X + ballVel.X, ballPos.Y + ballVel.Y);

            ball = new Rectangle(ballPos.X, ballPos.Y, 20, 20); // Create a rectangle for the ball


            if (Rectangle.Intersect(ball, paddle1) != default && paddleNextHit == 1)
            {
                if(ballVel.X != Math.Abs(ballVel.X)) 
                {
                    // ballVel is negative
                    ballVel.X -= 1; 

                }
                else 
                {
                    ballVel.X += 1; // Ensure the ball is moving right after hitting the paddle
                }
                if(ballVel.Y != Math.Abs(ballVel.Y)) 
                {
                    // ballVel is negative
                    ballVel.Y -= 1; 
                }
                else 
                {
                    ballVel.Y += 1; // Ensure the ball is moving down after hitting the paddle
                }
                ballVel.X *= -1;
                paddleNextHit = 2;
                
            }
            if (Rectangle.Intersect(ball, paddle2) != default && paddleNextHit == 2)
            {
                if (ballVel.X != Math.Abs(ballVel.X))
                {
                    // ballVel is negative
                    ballVel.X -= 1;
                }
                else
                {
                    ballVel.X += 1; // Ensure the ball is moving right after hitting the paddle
                }
                if (ballVel.Y != Math.Abs(ballVel.Y))
                {
                    // ballVel is negative
                    ballVel.Y -= 1;
                }
                else
                {
                    ballVel.Y += 1; // Ensure the ball is moving down after hitting the paddle
                }
                ballVel.X *= -1;
                paddleNextHit = 1;
            }
            if (ball.X + ball.Width > imageBox1.Width)
            {
                ball.X = imageBox1.Width - ball.Width; // Keep the ball within the bounds of the image box
                ballVel.X *= -1;
            }
            if (ball.X < 0)
            {
                ball.X = 0; // Keep the ball within the bounds of the image box
                ballVel.X *= -1;
            }
            if (ball.Y + ball.Height > imageBox1.Height)
            {
                ball.Y = imageBox1.Height - ball.Height; // Keep the ball within the bounds of the image box
                ballVel.Y *= -1;
            }
            if (ball.Y < 0)
            {
                ball.Y = 0; // Keep the ball within the bounds of the image box
                ballVel.Y *= -1;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
        }
    }
    public static class Extensions
    {
        public static int GetArea(this Rectangle rect) => rect.Width * rect.Height;

        public static int GetLargestIndex(this List<Rectangle> rects)
        {
            if (rects.Count == 0) return 0;
            int largestIndex = 0;
            int largestArea = rects[0].GetArea();
            for (int i = 1; i < rects.Count; i++)
            {
                int area = rects[i].GetArea();
                if (area > largestArea)
                {
                    largestArea = area;
                    largestIndex = i;
                }
            }
            return largestIndex;
        }
    }

}
