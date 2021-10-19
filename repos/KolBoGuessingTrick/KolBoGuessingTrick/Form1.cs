using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolBoGuessingTrick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int mod7 = Convert.ToInt32(modular7box.Text);
            int m7total = (mod7 * 15);
            int mod5 = Convert.ToInt32(modular5box.Text);
            int m5total = (mod5 * 21);
            int mod3 = Convert.ToInt32(modular3box.Text);
            int m3total = (mod3 * 70);

            int subTotal = (m7total + m5total + m3total);
            int total;

            if (subTotal > 315)
            {
                total = (subTotal - 315);
            }
            else if (subTotal > 210)
            {
                total = (subTotal - 210);
            }
            else if (subTotal > 105)
            {
                total = subTotal - 105;
            }
            else
            {
                total = subTotal;
            }


            MessageBox.Show($"Your number is  {total}");
        }
    }
}
