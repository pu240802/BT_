using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nhapdiem1.Hide();
            nhapHoSo1.Hide();
            lensbd1.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
           pictureBox1.Image = imageList1.Images[r.Next(0,3)];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nhapdiem1.Hide();
            nhapHoSo1.Hide();
            lensbd1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nhapdiem1.Hide();
            nhapHoSo1.Show();
            lensbd1.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhapdiem1.Hide();
            nhapHoSo1.Hide();
            lensbd1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nhapdiem1.Show();
            nhapHoSo1.Hide();
            lensbd1.Hide();
        }
    }
}
