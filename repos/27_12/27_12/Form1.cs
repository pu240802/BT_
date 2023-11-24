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
using System.Threading;
using System.Xml.Linq;

namespace _27_12
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=LAPTOP-4QHEND5O\PHUONG;Initial Catalog=DMCONGVIEC;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = " SELECT * FROM CONGVIEC";
            adapter.SelectCommand = cmd;

            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            txtMCV.ReadOnly = true;
            txtMCV.BackColor = SystemColors.Highlight;
            dataGridView1.ReadOnly = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMCV.Text = getID();
            resettextbox();



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
        public void resettextbox()
        {
            txtMCV.Text = "";
            txtTCV.Text = "";
            txtLT.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as String))
            {
                txtMCV.Text = getID();
                txtTCV.Text = "";
                txtLT.Text = "";
                return;
            }
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMCV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTCV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtLT.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

        }

        private void txtLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMCV.Text == "" || txtTCV.Text == "" || txtLT.Text == "")
            {
                MessageBox.Show("Không được bỏ trống trường nào!");

            }
            else {
                cmd = conn.CreateCommand();
                cmd.CommandText = " Insert into CONGVIEC values ('" + txtMCV.Text + "' , N'" + txtTCV.Text + "' ,'" + txtLT.Text + "')";
                cmd.ExecuteNonQuery();
                loaddata();
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = " UPDATE CONGVIEC SET MACONGVIEC = '" + txtMCV.Text + "', TENCONGVIEC = '" + txtTCV.Text + "',LUONGTHANG = '" + txtLT.Text + "' WHERE MACONGVIEC = '" + txtMCV.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Delete from CONGVIEC where MACONGVIEC = '" + txtMCV.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }
        public string getID()
        {

            string id_congviec = "";
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MACONGVIEC FROM CONGVIEC ORDER BY MACONGVIEC DESC";
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                int id = int.Parse(sqlDataReader[0].ToString().Remove(0, 2)) + 1;
                Console.WriteLine("Debuggggggggggg: ", id.ToString());
                if (id < 10)
                {
                    id_congviec = "CV0" + id.ToString();
                }
                else
                {
                    id_congviec = "CV" + id.ToString();
                }
            }
            sqlDataReader.Close();
            return id_congviec;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes){
                Application.Exit();

            }
            else
            {

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select   MACONGVIEC, TENCONGVIEC ,LUONGTHANG From CONGVIEC where TENCONGVIEC LIKE'%"+txTCVtim.Text+"'";
            adapter = new SqlDataAdapter(cmd);
            table.Clear();
            adapter.Fill(table);

            dataGridView1.DataSource = table;

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dataGridView1.Rows.Count+1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                }
                for ( int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for ( int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

            }

        }
    }
}
