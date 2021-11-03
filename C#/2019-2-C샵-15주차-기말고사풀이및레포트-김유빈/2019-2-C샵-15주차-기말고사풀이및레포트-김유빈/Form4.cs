using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_15주차_기말고사풀이및레포트_김유빈
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int a = 1;
        int b = 1;
        int c = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/" + (a == 6 ? a = 1 : a++) + ".jpg"); //a가 6이면 a=1이고 그렇지 않으면 a++이다.
            pictureBox2.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 오버액션토끼/" + (b == 7 ? b = 1 : b++) + ".jpg");
            pictureBox3.Image = Image.FromFile(System.Environment.CurrentDirectory + "/엄마에게 다가가는 새끼 코끼리/" + (c == 5 ? c = 1 : c++) + ".jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200; //느리게
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100; //중간
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50; //빠르게
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = hScrollBar1.Value;
        }
    }
}
