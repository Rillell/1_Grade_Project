using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_10주차_움짤만들기_김유빈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ChangeSajin(int a)
        {
            switch(a)
            {
                case 1:
                    pictureBox1.Image= Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/1.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/2.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/3.jpg");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/4.jpg");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/5.jpg");
                    break;
            }
        }

        int Sajin_Value = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeSajin(Sajin_Value);
            Sajin_Value++;
            if (Sajin_Value > 5)
                Sajin_Value = 1;
        }
    }
}
