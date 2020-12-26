using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOCI1
{
    public partial class Form1 : Form
    {
        ImageEditor imgEditor = new ImageEditor();
        Image<Bgr, byte> image, defaultImage;
        PointF[] srcPoints = new PointF[4];
        List<PointF> points = new List<PointF>();
        int mouseX, mouseY;
        VideoCapture capture;
        int frameCounter = 0;
        int minArea = 0;
        CascadeClassifier face = new CascadeClassifier("D:\\Tesseract\\haarcascade_frontalface_default.xml");
        Mat frame;
        Mat capImage = new Mat();

        public Form1()
        {
            InitializeComponent();
            imageBox1.MouseClick += new MouseEventHandler(imageBox2_MouseClick);
            radioButtonContour.Checked = true;
        }

        private void imageBox2_MouseClick(object sender, MouseEventArgs e)
        {
            mouseX = (int)(e.Location.X / imageBox1.ZoomScale / ((double)imageBox1.Width / (double)defaultImage.Width));
            mouseY = (int)(e.Location.Y / imageBox1.ZoomScale / ((double)imageBox1.Width / (double)defaultImage.Width));

            points.Add(new PointF(mouseX, mouseY));
            if(points.Count > 4)
            {
                points.RemoveAt(0);
            }
            if(points.Count == 4)
            {
                srcPoints = points.ToArray();
            }

            Point center = new Point(mouseX, mouseY);
            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Red).MCvScalar;
            // функция, рисующая на изображении круг с заданными параметрами
            CvInvoke.Circle(defaultImage, center, radius, color, thickness);
            imgEditor.ShowImage(imageBox1, defaultImage);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            defaultImage = imgEditor.SetSourceImage(OpenImageFile());
            imgEditor.ShowImage(imageBox1, defaultImage);
        }


        

        private void buttonCamera_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture();
            capture.Start();
            capture.ImageGrabbed += ProcessFrame;
            frameCounter = 0;
            timer1.Enabled = false;
            imgEditor.bg = null;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            var frame = new Mat();
            capture.Retrieve(frame);
            BeginInvoke(new MethodInvoker(delegate
            {
                minArea = trackBarArea.Value;
            }));
            //imageBox1.Image = frame;
            //imageBox2.Image = imgEditor.ReturnMovingArea(frame, minArea, radioButtonBoxes.Checked);
            imgEditor.ShowImage(imageBox1, imgEditor.ReturnMovingArea2(frame, minArea));
            imgEditor.ShowImage(imageBox2, imgEditor.ReturnMovingArea(frame, minArea, radioButtonBoxes.Checked));
        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            if(capture!=null)
                capture.Pause();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                capture = new VideoCapture(fileName);
                timer1.Enabled = true;
                imgEditor.bg = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            BeginInvoke(new MethodInvoker(delegate
            {
                minArea = trackBarArea.Value;
            }));
            var frame = capture.QueryFrame();
            var imgFrame = frame.ToImage<Bgr, byte>();
            imgEditor.ShowImage(imageBox1, imgEditor.ReturnMovingArea2(frame, minArea));
            //imageBox1.Image = frame;
            //imageBox2.Image = imgEditor.ReturnMovingArea(frame, minArea, radioButtonBoxes.Checked);
            imgEditor.ShowImage(imageBox2, imgEditor.ReturnMovingArea(frame, minArea, radioButtonBoxes.Checked));
            frameCounter++;
            if (frameCounter >= capture.GetCaptureProperty(CapProp.FrameCount))
            {
                frameCounter = 0;
                timer1.Enabled = false;
            }
        }

        private string OpenImageFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                return fileName;
            }
            return null;
        }
        

       //filllllllllllll

        private void FillImage2(bool mode = true)
        {
            
            imgEditor.ShowImage(imageBox2, image, mode);
        }

        
    }
}
