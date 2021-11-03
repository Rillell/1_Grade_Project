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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int Sajin_Value1 = 1;
        int Sajin_Value2 = 1;
        int Sajin_Value3 = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/" + Sajin_Value1 + ".jpg");
            Sajin_Value1++;
            if (Sajin_Value1 > 5) Sajin_Value1 = 1;

            pictureBox2.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 오버액션토끼/" + Sajin_Value2 + ".jpg");
            Sajin_Value2++;
            if (Sajin_Value2 > 6) Sajin_Value2 = 1;

            pictureBox3.Image = Image.FromFile(System.Environment.CurrentDirectory + "/엄마에게 다가가는 새끼 코끼리/" + Sajin_Value3 + ".jpg");
            Sajin_Value3++;
            if (Sajin_Value3 > 4) Sajin_Value3 = 1;
        }
    }
}
