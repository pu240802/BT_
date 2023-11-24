using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDMDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form new_mdi_child = new Form();
            new_mdi_child.Text = "Cửa sổ con MDI";
            new_mdi_child.MdiParent = this;
            new_mdi_child.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           dateTimePicker1.Value=DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            DateTime p = new DateTime();
            p = dateTimePicker1.Value;
            MessageBox.Show("" + p);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("people");

            dt.Columns.Add("First Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Last Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Occupation", System.Type.GetType("System.String"));
            dt.Columns.Add("Salary", System.Type.GetType("System.Int32"));

            dt.Rows.Add(new object[] { "Rod", "Stephens", "Nerd", 10000 });
            dt.Rows.Add(new object[] { "Sergio", "Araones", "Cartoonist", 20000 });
            dt.Rows.Add(new object[] { "Eoin", "Colfer", "Author", 30000 });

           dataGridView1.DataSource = dt;
        }
    }
}
