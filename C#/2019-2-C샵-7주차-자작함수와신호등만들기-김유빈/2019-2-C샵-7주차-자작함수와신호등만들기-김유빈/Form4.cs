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
    public partial class Form4 : Form
    {
        public Form4()
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
                case 4:
                    pictureBox1.Image = Image.FromFile
               (System.Environment.CurrentDirectory + "/yellow.ico");
                     break;
            }
        }
        int Sinhodoong_Color = 1; //전역변수여야 함
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplaySinhodoong(Sinhodoong_Color);
            Sinhodoong_Color++;

            if (Sinhodoong_Color > 4) //case문 4를 추가한것과 같은 맥락
            {
                DisplaySinhodoong(2);
                Sinhodoong_Color = 1;
            }//변수 하나만 사용할때
        }
    }
}


