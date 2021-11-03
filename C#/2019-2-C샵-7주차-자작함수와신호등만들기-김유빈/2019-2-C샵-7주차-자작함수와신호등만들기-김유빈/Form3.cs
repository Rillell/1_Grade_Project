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
    public partial class Form3 : Form
    {
        public Form3()
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
               // case 4:
               //    pictureBox1.Image = Image.FromFile
               //(System.Environment.CurrentDirectory + "/yellow.ico");
               //     break;
            }
        }
        int Sinhodoong_Color = 1; //전역변수여야 함
        //Boolean Up_Down = false; //변수 추가할때
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplaySinhodoong(Sinhodoong_Color);
            Sinhodoong_Color++;
            if(Sinhodoong_Color > 4) //case문 4를 추가한것과 같은 맥락
            {
                DisplaySinhodoong(2);
                Sinhodoong_Color = 1;
            }//변수 하나만 사용할때

            //if(Up_Down == false) Sinhodoong_Color++;
            //if (Up_Down == true) Sinhodoong_Color--;
            //if (Sinhodoong_Color >= 3) Up_Down = true;         if (Sinhodoong_Color > 3)//3을 넘으면 다시 1로 초기화<- case를 사용할때
            //if (Sinhodoong_Color <= 1) Up_Down = false;
            //Sinhodoong_Color = 1;   case추가하여 해결할때 사용
        }
    }
    }

