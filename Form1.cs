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

        }
        int newY1 = 12;
        int newY2 = 12;
        int newY3 = 12;
        int newY4 = 12;
        private void timer1_Tick(object sender, EventArgs e)
        {
            newY1 += 6; //newY = newY + 3;
            button1.Location = new Point(110, newY1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(110, 12);
            newY1 = 12;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Location = new Point(214, 12);
            newY2 = 12;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            newY2 += 2;
            button2.Location = new Point(214, newY2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(341, 12);
            newY3 = 12;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(461, 12);
            newY4 = 12;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            newY3 += 1;
            button3.Location = new Point(341, newY3);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            newY4 += 5;
            button4.Location = new Point(461, newY4);
        }
    }
}
