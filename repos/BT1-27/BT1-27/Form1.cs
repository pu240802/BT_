using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT1_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            var = comboBox1.Text;
            if (comboBox1.Text == "Hà Nội")
            {
              
                return;
            }
            if (comboBox1.Text == "Hồ Chí Minh")
            {
        
                return;
            }
            if (comboBox1.Text == "Cần Thơ")
            {
                
                return;
            }
            if (comboBox1.Text == "Bình Dương")
            {
             
                return;
            }
            if (comboBox1.Text == "Long An")
            {
             
                return;
            }

        }

        private void btnSublmit_Click(object sender, EventArgs e)
        {
          
           
            MessageBox.Show(
                "Name: " + txtInput.Text +
                "\nAddress: " + txtInput2.Text +
                "\nCity: " + comboBox1.Text 
                + "\nGender: " + Gender
                +"\nCouse: " + Course
                 );




        }

        private void groupGender_Enter(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            string var;
            var = txtInput.Text ;
        }

        private void txtInput2_TextChanged(object sender, EventArgs e)
        {
            string var2;
            var2 = txtInput2.Text;
        }
        string Gender = "";
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void radioLgbt_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "LGBT";
        }
        string Course = "";
        private void checkC_CheckedChanged(object sender, EventArgs e)
        {
            Course = "C#";
        }

        private void checkJava_CheckedChanged(object sender, EventArgs e)
        {
            Course = "Java";
        }

        private void checkPython_CheckedChanged(object sender, EventArgs e)
        {
            Course = "Python";
        }
    }

}
