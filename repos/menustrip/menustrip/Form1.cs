using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void menuItem2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấp chuột vào menuItem2");
        }

        private void menuItem1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đẫ nhấp chuột vào MenuItem1");
        }

        private void menuItem3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đẫ nhấp chuột vào MenuItem3");
        }
    }
}
