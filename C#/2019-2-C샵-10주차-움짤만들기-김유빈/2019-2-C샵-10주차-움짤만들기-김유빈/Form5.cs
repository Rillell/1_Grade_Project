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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int Sajin_Value = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/" + (Sajin_Value % 5 + 1) + ".jpg");
            pictureBox2.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 오버액션토끼/" + (Sajin_Value % 6 + 1) + ".jpg");
            pictureBox3.Image = Image.FromFile(System.Environment.CurrentDirectory + "/엄마에게 다가가는 새끼 코끼리/" + (Sajin_Value % 4 + 1) + ".jpg");
            Sajin_Value++;     
            if (Sajin_Value >= 60) Sajin_Value = 0;  //60 => 최소공배수
        }
    }
}
