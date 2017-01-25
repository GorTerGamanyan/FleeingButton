using System;
using System.Drawing;
using System.Windows.Forms;

namespace FleeingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {


            Random rnd = new Random();

            button1.Location = new Point(rnd.Next(0, 1100), rnd.Next(0, 600));


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
