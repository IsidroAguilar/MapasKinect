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
        Skeleton[] skeletons;
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
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
