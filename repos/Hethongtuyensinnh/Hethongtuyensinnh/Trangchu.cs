using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hethongtuyensinnh
{
    public partial class Trangchu : UserControl
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[r.Next(0, 2)];
        }
    }
}
