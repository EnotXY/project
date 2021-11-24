using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnogoEkzov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var summa = Convert.ToInt32(textBox1.Text);
            
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknota.jpg");
                if (radioButton4.Checked)
                {
                    textBox2.Text = Convert.ToString(summa / 104) + '£';
                    pictureBox2.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknotaf.jpg");
                }

                if (radioButton5.Checked)
                {
                    textBox2.Text = Convert.ToString(summa / 66) + '$';
                    pictureBox2.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknotad.jpg");
                }

                if (radioButton6.Checked)
                {
                    textBox2.Text = Convert.ToString(summa / 1) + '₽';
                    pictureBox2.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknota.jpg");
                }
            }

            if (radioButton2.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknotad.jpg");
                if (radioButton4.Checked)
                {
                    textBox2.Text = Convert.ToString(Math.Round(summa / 1.676)) + '£';
                    pictureBox2.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknotaf.jpg");
                }

                if (radioButton5.Checked)
                {
                    textBox2.Text = Convert.ToString(summa / 1) + '$';
                    pictureBox2.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknotad.jpg");
                }

                if (radioButton6.Checked)
                {
                    textBox2.Text = Convert.ToString(summa * 66) + '₽';
                    pictureBox2.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknota.jpg");
                }
            }

            if (radioButton3.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknotaf.jpg");
                if (radioButton4.Checked)
                {
                    textBox2.Text = Convert.ToString(summa / 1) + '£';
                    pictureBox2.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknotaf.jpg");
                }

                if (radioButton5.Checked)
                {
                    textBox2.Text = Convert.ToString(Math.Round(summa / 0.6)) + '$';
                    pictureBox2.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknotad.jpg");
                }

                if (radioButton6.Checked)
                {
                    textBox2.Text = Convert.ToString(summa * 104) + '₽';
                    pictureBox2.Image = Image.FromFile(@"C:\Users\student\Documents\Pahomov\Zadachahaha\banknota.jpg");
                }
            }
        }
    }
}
