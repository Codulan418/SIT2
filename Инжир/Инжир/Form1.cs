using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Инжир
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public const double PI = 3.1415926535897931;
        public const double E = 2.7182818284590451;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            System.Windows.Forms.Button B=(System.Windows.Forms.Button)sender;
            if(textBox1.Text=="0")        
                textBox1.Text= B.Text;
            else
                textBox1.Text = textBox1.Text+B.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button B = (System.Windows.Forms.Button)sender;
            D = B.Text;
            N1 =textBox1.Text;
            n2=true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
            

            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();



        }

        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn,2);
            textBox1.Text = res.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = dn * PI;
            textBox1.Text = res.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = dn * E;
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res=Math.Round(Math.Sin(dn * (Math.PI / 180.0)), 8);
            textBox1.Text = res.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Round(Math.Cos(dn * (Math.PI / 180.0)), 8);
            textBox1.Text = res.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Round(Math.Tan(dn * (Math.PI / 180.0)), 8);
            if (res > 1e+10)
                textBox1.Text= "not defined";
            else
                textBox1.Text = res.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double dn, res, y;

            dn = Convert.ToDouble(textBox1.Text);
            y = Math.Round(Math.Tan(dn * (Math.PI / 180.0)), 8);
            res = 1.0 / Math.Tan(y);
            if (res == double.NegativeInfinity)
                textBox1.Text = "not defined";
            else
                textBox1.Text = res.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
    }
}
