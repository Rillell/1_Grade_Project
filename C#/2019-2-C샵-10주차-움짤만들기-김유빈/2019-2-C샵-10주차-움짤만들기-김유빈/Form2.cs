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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void ChangeSajin(int a)
        {
            switch (a)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 오버액션토끼/1.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 오버액션토끼/2.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 오버액션토끼/3.jpg");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 오버액션토끼/4.jpg");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 오버액션토끼/5.jpg");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 오버액션토끼/6.jpg");
                    break;
            }
        }
        int Sajin_Value = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeSajin(Sajin_Value);
            Sajin_Value++;
            if (Sajin_Value > 6)
                Sajin_Value = 1;
        }
    }
}
