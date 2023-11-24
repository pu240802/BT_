using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_thue_nha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Hóa đơn");
            dt.Columns.Add("     ", System.Type.GetType("System.String"));
            dt.Columns.Add("Số mới", System.Type.GetType("System.String"));
            dt.Columns.Add("Số cũ", System.Type.GetType("System.String"));
            dt.Columns.Add("Số dùng", System.Type.GetType("System.String"));
            dt.Columns.Add("Đơn giá", System.Type.GetType("System.String"));
            dt.Columns.Add("Thành tiền", System.Type.GetType("System.String"));

            dt.Rows.Add(new object[] { "Điện", "", "", "", "", "" });
            dt.Rows.Add(new object[] { "Nước", "", "", "", "", "" });
            dataHoadon.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
