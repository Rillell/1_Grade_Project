using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_9주차_중간고사풀이_김유빈
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dan = 9; int GooGoo = 9;
            while (true)
            {
                GooGoo = 9;
                while (true)
                {
                    textBox2.Text = textBox2.Text + Dan + " X " + GooGoo + " = " + Dan * GooGoo + Environment.NewLine;
                    GooGoo--;
                    if (GooGoo <= 1) break;

                }
                Dan--;

                textBox2.Text = textBox2.Text + Environment.NewLine;
                if (Dan <= 1) break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int Dan =9; Dan >= 1; Dan--)
            {
                for(int GooGoo =9; GooGoo >=1; GooGoo--)
                {
                    textBox2.Text = textBox2.Text + Dan + " X " + GooGoo + " = " + Dan * GooGoo + Environment.NewLine;
                }
                textBox2.Text = textBox2.Text + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Dan = 9;
            while(Dan >= 1)
            {
                int GooGoo = 9;
                while(GooGoo >= 1)
                {
                    textBox2.Text = textBox2.Text + Dan + " X " + GooGoo + " = " + Dan * GooGoo + "\r\n";
                    GooGoo--;
                }
                textBox2.Text = textBox2.Text + "\r\n";
                Dan--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Dan = 9;
            do
            {
                int GooGoo = 9;
                do
                {
                    textBox2.Text = textBox2.Text + Dan + " X " + GooGoo + " = " + Dan * GooGoo + "\r\n";
                    GooGoo--;
                }while (GooGoo >= 1);
                textBox2.Text = textBox2.Text + "\r\n";
                Dan--;
            } while (Dan >= 1);
        }
    }
}
