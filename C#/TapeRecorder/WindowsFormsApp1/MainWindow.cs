using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapeRecorder
{
    public partial class MainWindow : Form
    {
        bool playing = false;
        bool recording = false;
        bool fastforward = false;
        bool rewinding = false;


        public MainWindow()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (playing)
            {
                if (playHead.Value < playHead.Maximum)
                    playHead.Value += 1;
            }

            if (rewinding)
                if (playHead.Value <= 12)
                    playHead.Value = 0;
                else
                    playHead.Value -= 12;

            if (fastforward)
            {
                if (playHead.Value >= playHead.Maximum - 12)
                    playHead.Value = playHead.Maximum;
                else
                    playHead.Value += 12;
            }
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {

        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                rewinding = true;
                textBox1.Text = "REWINDING";
            }
            else
            {
                playHead.Value = 0;
                textBox1.Text = "STOPPED";
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                playing = false;
                textBox1.Text = "PAUSED";
            }
            else
            {
                playing = true;
                textBox1.Text = "PLAYING";
            }
        }

        private void buttonFastForward_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                rewinding = false;
                fastforward = true;
                textBox1.Text = "FAST FORWARD";
            }
            else
            {
                playHead.Value = playHead.Maximum;
                textBox1.Text = "STOPPED";
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            playing = false;

            textBox1.Text = "STOPPED";
        }
    }
}
