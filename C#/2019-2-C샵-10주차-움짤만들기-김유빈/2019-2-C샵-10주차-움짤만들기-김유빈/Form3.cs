﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void ChangeSajin(int a)
        {
            switch (a)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/엄마에게 다가가는 새끼 코끼리/1.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/엄마에게 다가가는 새끼 코끼리/2.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/엄마에게 다가가는 새끼 코끼리/3.jpg");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/엄마에게 다가가는 새끼 코끼리/4.jpg");
                    break;
            }
        }
        int Sajin_Value = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeSajin(Sajin_Value);
            Sajin_Value++;
            if (Sajin_Value > 4)
                Sajin_Value = 1;
        }
    }
}
