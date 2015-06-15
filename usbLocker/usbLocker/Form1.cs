
using System;
using System.Windows.Forms;

namespace usbLocker
{
    public partial class Form1 : Form
    {

        private Timer timer = new Timer();
        private int timeLeft = 15;

        public Form1()
        {
            InitializeComponent();


            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(setLabelText);
            timer.Start();
        }

        private void setLabelText(object sender, EventArgs e)
        {
            timeLeft--;
            label1.Text = timeLeft.ToString();

            if (timeLeft <= 0)
            {
                timer.Stop();
            }
        }
    }
}
