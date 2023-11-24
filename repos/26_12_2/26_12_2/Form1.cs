using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Contexts;
using System.Runtime.InteropServices.WindowsRuntime;

namespace _26_12_2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=LAPTOP-4QHEND5O\PHUONG;Initial Catalog=QLHOCSINH;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
            void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from HOCSINH";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            //txtID.ReadOnly = true;
            txtID.BackColor = SystemColors.Highlight;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

        }






        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           





        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
            
            
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
           



        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtTen.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống trường nào!");
            }
            else {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO  HOCSINH VALUES('" + txtID.Text + "','" + txtTen.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "')";
                cmd.ExecuteNonQuery();
                loaddata();
          }
;        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE  HOCSINH SET ID = '" + txtID.Text + "',NAME ='" + txtTen.Text + "', EMAIL ='" + txtEmail.Text + "',MOBILE ='" + txtPhone.Text + "' WHERE ID ='" + txtID.Text + "' ";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM HOCSINH WHERE ID = '" + txtID.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }

}
