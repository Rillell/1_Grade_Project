using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_7주차_자작함수와신호등만들기_김유빈
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void DisplaySinhodoong(int a)
        {
            switch (a)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile
               (System.Environment.CurrentDirectory + "/red.ico");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile
               (System.Environment.CurrentDirectory + "/yellow.ico");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile
               (System.Environment.CurrentDirectory + "/blue.ico");
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DisplaySinhodoong(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplaySinhodoong(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplaySinhodoong(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplaySinhodoong(3);
        }
    }
}
