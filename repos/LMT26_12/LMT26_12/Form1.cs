using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Contexts;

namespace LMT26_12
{
    public partial class Form1 : Form

    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-4QHEND5O\PHUONG;Initial Catalog=CONGVIEC;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from CONGVIEC";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMCV.ReadOnly = true;
            txtMCV.BackColor = SystemColors.GrayText;
            dataGridView1.ReadOnly = true;
            txtMCV.Text = getTheLastIndex();
            Reset();


        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           



        }
        public string getTheLastIndex()
        {
            string id_autoincrement = "";
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MACONGVIEC FROM CONGVIEC ORDER BY MACONGVIEC DESC";
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                int id = int.Parse(sqlDataReader[0].ToString().Remove(0, 2)) + 1;
                Console.WriteLine("Debuggggggggggg: ", id.ToString());
                if (id < 10)
                {
                    id_autoincrement = "CV0" + id.ToString();
                }
                else
                {
                    id_autoincrement = "CV" + id.ToString();
                }
            }
            sqlDataReader.Close();
            return id_autoincrement;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = " Insert into CONGVIEC values ('" + txtMCV.Text + "' , N'" + txtTCV.Text + "' ,'" + txtLT.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();

        }

        private void txtLT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLT_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsDigit(e.KeyChar)){
                e.Handled = true;

            }
            if (e.KeyChar == (char)8) e.Handled = false; //ASC = BACKSPACE
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMCV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTCV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtLT.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Delete from CONGVIEC where MACONGVIEC = '"+txtMCV.Text+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Update from CONGVIEC set  MACONGVIEC = '" + txtMCV.Text + "' , TENCONGVIEC = N'" + txtTCV.Text + "', LUONGTHANG = '" + txtLT.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();

        }
        public void Reset()
        {
            txtTCV.Text = "";
            txtLT.Text = "";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
                if (dataGridView1.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);
                    
                //cái trường ban đầu 
                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                    {
                        xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                //đưa dữ liệu vào excel 
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //Nothing
            }

        }
    }
}
