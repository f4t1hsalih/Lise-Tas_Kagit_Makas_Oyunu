using System;
using System.Windows.Forms;

namespace Tas_Kagit_Makas_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;
        Random rnd = new Random();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            a = rnd.Next(1, 4);
            if (a == 1)
            {
                pictureBox4.Image = Properties.Resources.tas;
                MessageBox.Show("Taş - Taş \nBerabere");
            }
            else if (a == 2)
            {
                pictureBox4.Image = Properties.Resources.kagıt;
                MessageBox.Show("Taş - Kağıt \nBilgisayar Kazandı");
            }
            else if (a == 3)
            {
                pictureBox4.Image = Properties.Resources.makas;
                MessageBox.Show("Taş - Makas \nSen Kazandın");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a = rnd.Next(1, 4);
            if (a == 1)
            {
                pictureBox4.Image = Properties.Resources.tas;
                MessageBox.Show("Kağıt - Taş \nSen Kazandın");
            }
            else if (a == 2)
            {
                pictureBox4.Image = Properties.Resources.kagıt;
                MessageBox.Show("Kağıt - Kağıt \nBerabere");
            }
            else if (a == 3)
            {
                pictureBox4.Image = Properties.Resources.makas;
                MessageBox.Show("Kağıt - Makas \nBilgisayar Kazandı");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            a = rnd.Next(1, 4);
            if (a == 1)
            {
                pictureBox4.Image = Properties.Resources.tas;
                MessageBox.Show("Makas - Taş \nBilgisayar Kazandı");
            }
            else if (a == 2)
            {
                pictureBox4.Image = Properties.Resources.kagıt;
                MessageBox.Show("Makas - Kağıt \nSen Kazandın");
            }
            else if (a == 3)
            {
                pictureBox4.Image = Properties.Resources.makas;
                MessageBox.Show("Makas - Makas \nBerabere");
            }
        }
    }
}
