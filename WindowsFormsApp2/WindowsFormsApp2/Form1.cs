using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool dff1 = false;
        bool dff2 = false;
        bool dff3 = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) pictureBox1.Top = pictureBox1.Top - 5;
            if (e.KeyCode == Keys.Down) pictureBox1.Top = pictureBox1.Top + 5;
            if (e.KeyCode == Keys.Left) pictureBox1.Left = pictureBox1.Left - 5;
            if (e.KeyCode == Keys.Right) pictureBox1.Left = pictureBox1.Left + 5;

            if (pictureBox1.Top < 0) pictureBox1.Top = 0;
            if (pictureBox1.Top > 400) pictureBox1.Top = 400;
            if (pictureBox1.Left < 0) pictureBox1.Left = 0;
            if (pictureBox1.Left > 1000) pictureBox1.Left = 1000;

            if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox3.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox4.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox5.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox6.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox7.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox8.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox9.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox10.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox11.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox12.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox13.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox14.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            if (pictureBox15.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 399);
            





        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (dff1 == false)
            {
                pictureBox4.Top = pictureBox4.Top + 2;
                if (pictureBox4.Top > 138) dff1 = true;
            }
            if (dff1 == true)
            {
                pictureBox4.Top = pictureBox4.Top - 2;
                if (pictureBox4.Top < 1) dff1 = false;
            }
        }

        private void timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (dff2 == false)
            {
                pictureBox2.Left = pictureBox2.Left + 2;
                if (pictureBox2.Left > 920) dff2 = true;
            }
            if (dff2 == true)
            {
                pictureBox2.Left = pictureBox2.Left - 2;
                if (pictureBox2.Left < 570) dff2 = false;
            }
        }

        private void timer3_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (dff3 == false)
            {
                pictureBox3.Top = pictureBox3.Top + 1;
                if (pictureBox3.Top > 399) dff3 = true;
            }
            if (dff3 == true)
            {
                pictureBox3.Top = pictureBox3.Top - 1;
                if (pictureBox3.Top < 261) dff3 = false;
            }
        }

        

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Bounds.IntersectsWith(pictureBox16.Bounds)) pictureBox2.Left=12;
        }
    }
}