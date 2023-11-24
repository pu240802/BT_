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




namespace LMT23_12
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        String str = @"Data Source=LAPTOP-4QHEND5O\PHUONG;Initial Catalog=BANHANG1;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
            
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select MAHANG, TENHANG, TENCHATLIEU, DONGIANHAP, DONGIABAN, SOLUONG FROM CHATLIEU AS A, HANG AS B WHERE A.MACHATLIEU = B.MACHATLIEU";
            adapter.SelectCommand = cmd;

            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

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

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Ban co muon thoat khong?",
                "Tong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlTimkiem = "Select MAHANG, TENHANG, TENCHATLIEU, DONGIANHAP, DONGIABAN, SOLUONG FROM CHATLIEU AS A, HANG AS B WHERE A.MACHATLIEU = B.MACHATLIEU  AND MAHANG = @MAHANG AND THENHANG = @TENHANG, TENCHATLIEU= @TENCHATLIEU ";
            SqlCommand cmd = new SqlCommand(sqlTimkiem,conn);
            cmd.Parameters.AddWithValue("MAHANG", txtMH.Text);
            cmd.Parameters.AddWithValue("TENHANG", txtTH.Text);
            cmd.Parameters.AddWithValue("TENCHATLIEU", txtCL.Text);
            cmd.Parameters.AddWithValue("DONGIATU", txtĐGT.Text);
            cmd.Parameters.AddWithValue("DONGIADEN", txtDGD.Text);
            //SqlDataAdapter adapter = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            //dt.Load(adapter);
            dataGridView1.DataSource = dt;


        }
    }
}




