using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool dff = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) pictureBox1.Top = pictureBox1.Top - 20;
            if (e.KeyCode == Keys.S) pictureBox1.Top = pictureBox1.Top + 20;
            if (e.KeyCode == Keys.A) pictureBox1.Left = pictureBox1.Left - 20;
            if (e.KeyCode == Keys.D) pictureBox1.Left = pictureBox1.Left + 20;

            if (pictureBox1.Top < 0) pictureBox1.Top = 0;
            if (pictureBox1.Top > 654) pictureBox1.Top = 654;
            if (pictureBox1.Left < 0) pictureBox1.Left = 0;
            if (pictureBox1.Left > 1094) pictureBox1.Left = 1094;

            if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox3.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox4.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox5.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox6.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox7.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox8.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox9.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox10.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox11.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox12.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275); 
            if (pictureBox13.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox14.Bounds.IntersectsWith(pictureBox1.Bounds)) pictureBox1.Location = new Point(12, 275);
            if (pictureBox16.Bounds.IntersectsWith(pictureBox1.Bounds)) MessageBox.Show("Победа");
            if (pictureBox17.Bounds.IntersectsWith(pictureBox1.Bounds)) MessageBox.Show("Тыче?");




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dff == false)
            {
                pictureBox14.Top = pictureBox14.Top + 10;
                if (pictureBox14.Top > 550) dff = true;
            }
            if (dff == true)
            {
                pictureBox14.Top = pictureBox14.Top - 10;
                if (pictureBox14.Top < 169) dff = false;
            }
                
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}
