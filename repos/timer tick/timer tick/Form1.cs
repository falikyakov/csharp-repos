using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_tick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Mayeer Simcha, you did a great job tonight, now it's time for you to go to sleep!");
            //Thread.Sleep(1000);
            //synth.Speak("No, seriously, you really do have to go to sleep, like right now.");
            //synth.Speak("OK now, get your toosik in to bed!!!");
            //synth.Speak("I don't really care that you want to eat. But, I love you, so I'll let you this time. After you eat, you must get" +
            //   "into bed right away, because you have to do the avvodoss habborray.");
            //synth.Speak("Hello estee and yehoodah oaryey, how was your day today?");
            synth.Speak("OK, mendee, get your toosik in to bed!!!");
            Thread.Sleep(1000);

            synth.Speak("Do you really need a potch");
            synth.Speak("Do you really need a potch???");
            Thread.Sleep(1000);

            synth.Speak("Yes, I do need a potch!");
            Thread.Sleep(1000);
            synth.Speak("OK, I'm giving you a potch!");







        }
    }
}
