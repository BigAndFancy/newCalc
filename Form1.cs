using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true;


        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ',';
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            
        }
    }
}
