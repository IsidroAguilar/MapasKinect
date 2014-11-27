using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace MapKinectApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variable Globales

        KinectSensor sensor = new KinectSensor();
        Skeleton[] Skeletons;
        int i = 0;
        int shoulderA = 0;

        #endregion

        #region Metodos Generales
        void InicializaSensor()
        {
            sensor = KinectSensor.KinectSensors[0];
            sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
            sensor.DepthStream.Enable(DepthImageFormat.Resolution320x240Fps30);
            sensor.SkeletonStream.Enable();
            sensor.AllFramesReady += FramesReady;
            sensor.Start();
        }

        Bitmap ImageToBitmap(ColorImageFrame Image)
        {
            byte[] pixeldata = new byte[Image.PixelDataLength];
            Image.CopyPixelDataTo(pixeldata);
            Bitmap bmap = new Bitmap(
                Image.Width,
                Image.Height,
                PixelFormat.Format32bppRgb);
            BitmapData bmapdata = bmap.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.WriteOnly, bmap.PixelFormat);
            IntPtr ptr = bmapdata.Scan0;
            Marshal.Copy(pixeldata, 0, ptr, Image.PixelDataLength);
            bmap.UnlockBits(bmapdata);
            return bmap;
        }

        void FramesReady(object sender, AllFramesReadyEventArgs e)
        {
            ColorImageFrame VFrame = e.OpenColorImageFrame();
            if (VFrame == null) return;
            byte[] pixeldata = new byte[VFrame.PixelDataLength];
            Bitmap bmap = ImageToBitmap(VFrame);
            //Graphics g = Graphics.FromImage(bmap);
            //g.DrawEllipse(Pens.Red, new Rectangle(x - 10, y - 10, 20, 20));
            imgMapa.Image = bmap;

            SkeletonFrame SFrame = e.OpenSkeletonFrame();
            if (SFrame == null) return;

            Skeletons = new Skeleton[SFrame.SkeletonArrayLength];
            SFrame.CopySkeletonDataTo(Skeletons);
            foreach (Skeleton unSkeleton in Skeletons)
            {
                if (unSkeleton.TrackingState == SkeletonTrackingState.Tracked)
                {
                    lblShoulderPosition.Text = "X:" +
                        unSkeleton.Joints[JointType.ShoulderRight].Position.X.ToString()
                        + " Y:" + unSkeleton.Joints[JointType.ShoulderRight].Position.Y.ToString() + " Z:"
                        + unSkeleton.Joints[JointType.ShoulderRight].Position.Y.ToString();
                    lblMensaje.Text = "Mueve..." + i++;
                    SkeletonPoint Sloc = unSkeleton.Joints[JointType.HandRight].Position;
                    ColorImagePoint Cloc = sensor.MapSkeletonPointToColor(Sloc, ColorImageFormat.RgbResolution640x480Fps30);
                    markAtPoint(Cloc, bmap);
                    Sloc = unSkeleton.Joints[JointType.HandLeft].Position;
                    Cloc = sensor.MapSkeletonPointToColor(Sloc, ColorImageFormat.RgbResolution640x480Fps30);
                    markAtPoint(Cloc, bmap);
                    //imgMapa.Image = bmap;
                }

                if (unSkeleton.TrackingState == SkeletonTrackingState.PositionOnly)
                {
                    if (unSkeleton.Joints[JointType.ShoulderRight].TrackingState == JointTrackingState.Tracked)
                        lblShoulder.Text = "Mueve..." + shoulderA++;
                }
            }
        }

        void markAtPoint(ColorImagePoint p, Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            SolidBrush colorPoint = new SolidBrush(Color.Navy);
            g.FillEllipse(colorPoint, new Rectangle(p.X - 5, p.Y - 5, 10, 10));
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializaSensor();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sensor.Stop();
        }
    }
}
