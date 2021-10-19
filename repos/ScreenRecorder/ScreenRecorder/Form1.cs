using Accord.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRecorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Timer timer1 = new Timer();
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            VideoFileWriter vf = new VideoFileWriter();
            vf.Open("Exported_Video.avi", 800, 600, 25, VideoCodec.MPEG4, 1000000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bp = new Bitmap(800, 600);
            var gr = Graphics.FromImage(bp);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(bp.Width, bp.Height));
            pictureBox1.Image = bp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            VideoFileWriter vf = new VideoFileWriter();
            vf.WriteVideoFrame(bp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            vf.Close();
        }
    }
}
