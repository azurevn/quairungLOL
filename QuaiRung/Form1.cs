using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace QuaiRung
{
    public partial class Form1 : Form
    {
        public int seconds = 0; // Seconds.
        public int minutes = 0; // Minutes.
        public int seconds2 = 0; // Seconds.
        public int minutes2 = 0; // Minutes.
     
 
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            seconds = 55;
            minutes = 4;
           
        }

        void dongho_Elapsed(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0 && minutes == 0)
            {
                timer1.Enabled = false;
                label1.Text = "Xuat Hien";
            }
            else {
                if (seconds < 1)
                {
                    seconds = 59;
                    minutes -= 1;
                }
                else
                    seconds -= 1;
                label1.Text = minutes.ToString() + " : " + seconds.ToString();
            }
           
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            seconds2 = 55;
            minutes2 = 4;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (seconds2 == 0 && minutes2 == 0)
            {
                timer2.Enabled = false;
                label2.Text = "Xuat Hien";
            }
            else
            {
                if (seconds2 < 1)
                {
                    seconds2 = 59;
                    minutes2 -= 1;
                }
                else
                    seconds2 -= 1;
                label2.Text = minutes2.ToString() + " : " + seconds2.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
