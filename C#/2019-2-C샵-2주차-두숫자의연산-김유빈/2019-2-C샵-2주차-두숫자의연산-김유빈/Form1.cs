using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_2주차_두숫자의연산_김유빈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        double Digit1, Digit2; //전역 변수
        private void button1_Click(object sender, EventArgs e)
        {           
            Digit1 = double.Parse(textBox1.Text);
            Digit2 = double.Parse(textBox2.Text);
            textBox3.Text = (Digit1 + Digit2).ToString();
            label4.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            Digit1 = double.Parse(textBox1.Text);
            Digit2 = double.Parse(textBox2.Text);
            textBox3.Text = (Digit1 - Digit2).ToString();
            label4.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Digit1 = double.Parse(textBox1.Text);
            Digit2 = double.Parse(textBox2.Text);
            textBox3.Text = (Digit1 * Digit2).ToString();
            label4.Text = "X";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Digit1 = double.Parse(textBox1.Text);
            Digit2 = double.Parse(textBox2.Text);
            textBox3.Text = (Digit1 % Digit2).ToString();
            label4.Text = "mod";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Digit1 = double.Parse(textBox1.Text);
            Digit2 = double.Parse(textBox2.Text);
            textBox3.Text = Math.Pow(Digit1 , Digit2).ToString();
            label4.Text = "^";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Digit1 = double.Parse(textBox1.Text);
            Digit2 = double.Parse(textBox2.Text);
            textBox3.Text = (Digit1 / Digit2).ToString();
            label4.Text = "÷";
        }
    }
}
