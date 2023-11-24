using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VM_STYLE
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            
                pictureBox1.Image = imageList1.Images[r.Next(0, 3)];
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
           
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }
    }
}
