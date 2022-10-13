using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pk111GameStruev
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

        private void Form1_Load(object sender, EventArgs e)
        {
            window = this.Size.Height;
        }
        Random rnd = new Random();
        int window;
        int score = 0;
        int newY1 = 12;
        int newY2 = 12;
        int newY3 = 12;
        int newY4 = 12;
        private void timer1_Tick(object sender, EventArgs e)
        {
            newY1 += 6; //newY = newY + 3;
            button1.Location = new Point(110, newY1);
            if (button1.Location.Y >= window -50- button1.Size.Height)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                button5.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(110, 12);
            newY1 = 12;
            if (timer1.Enabled==true)
            {
                score++;
            }
            label1.Text = "Score:" + score.ToString();
            timer1.Interval = rnd.Next(10, 40);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Location = new Point(246, 12);
            newY2 = 12;
            if (timer2.Enabled == true)
            {
                score++;
            }
            label1.Text = "Score:" + score.ToString();
            timer2.Interval = rnd.Next(10, 40);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            newY2 += 2;
            button2.Location = new Point(246, newY2);
            if (button2.Location.Y >= window - 50 - button2.Size.Height)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                button5.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Location = new Point(373, 12);
            newY3 = 12;
            if (timer3.Enabled == true)
            {
                score++;
            }
            label1.Text = "Score:" + score.ToString();
            timer3.Interval = rnd.Next(10, 40);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Location = new Point(493, 12);
            newY4 = 12;
            if (timer4.Enabled == true)
            {
                score++;
            }
            label1.Text = "Score:" + score.ToString();
            timer4.Interval = rnd.Next(10, 40);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            newY3 += 1;
            button3.Location = new Point(373, newY3);
            if (button3.Location.Y >= window - 50 - button3.Size.Height)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                button5.Visible = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            newY4 += 5;
            button4.Location = new Point(493, newY4);
            if (button4.Location.Y >= window - 50 - button4.Size.Height)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                button5.Visible = true;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                score--;
                label1.Text = "Score:" + score.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {//restart
            newY1 = newY2 = newY3 = newY4 = 12;
            score = 0;
            label1.Text = "Score:";
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            button5.Visible = false;
        }
    }
}
