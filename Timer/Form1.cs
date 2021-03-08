using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Timer
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //timer and stopwatch
            if (exampleTimer.Enabled == false)
            {
                exampleTimer.Enabled = true;
                startButton.Text = "Pause";

                myWatch.Start();
            }
            else
            {
                exampleTimer.Enabled = false;
                startButton.Text = "Start";

                myWatch.Stop();
                timerLabel.Text = $"Timer: {myWatch.Elapsed}";        
            }
        }

        private void exampleTimer_Tick(object sender, EventArgs e)
        {
            //timer
            counter++;
            countLabel.Text = $"Counter:                {counter}";

            //colour change 
            if (counter % 3 == 0)
            {
                colorLabel.BackColor = Color.LightPink;
            }
            else if (counter % 3 == 1)
            {
                colorLabel.BackColor = Color.Purple;
            }
            else if (counter % 3 == 2)
            {
                colorLabel.BackColor = Color.BlueViolet;
            }
        }
    }
}
