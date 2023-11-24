using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblText.AutoSize = true;
            lblText.Text = " Do you want to submit this project ?";
           
            lblText.Font = new Font("French Script MT", 18);


            btnSubmit.Text = "Submit";
            btnSubmit.AutoSize = true;
            btnSubmit.BackColor = Color.LightBlue;
            btnSubmit.Padding = new Padding(6);
            btnSubmit.Font = new Font("French Script MT", 18);

            btnCancel.Text = "Cancel";
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.LightPink;
            btnCancel.Padding = new Padding(6);
            btnCancel.Font = new Font("French Script MT", 18);
        }
    }
}
