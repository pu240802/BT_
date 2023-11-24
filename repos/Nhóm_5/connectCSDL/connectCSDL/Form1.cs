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

namespace connectCSDL
{
    public partial class Form1 : Form
    {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string str = @"Data Source=LAPTOP-4QHEND5O\\PHUONG;Initial Catalog=HOCSINH12;Integrated Security=True;User ID=sa;Password=1234 ";
            DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from Student";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             connection = new SqlConnection(str);
         

            Model3 context = new Model3();
            List<Student> listStudents = context.Student.ToList();  
            dataGridView1.DataSource = listStudents;

            List<Falculty> listFal = context.Falculty.ToList();
           comboBox1.DataSource = listFal;
           comboBox1.ValueMember = "faculty_id";
           comboBox1.DisplayMember = "facultyName";
          
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                txtMasv.Text = dgvRow.Cells[0].Value.ToString();
                Txthoten.Text = dgvRow.Cells[1].Value.ToString();
                txtDiemTB.Text = dgvRow.Cells[2].Value.ToString();
                comboBox1.SelectedValue = dgvRow.Cells[3].Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            command = connection.CreateCommand();
            command.CommandText = " insert into Student(student_id,fullname,averageScore,faculty_id) values ('"+ txtMasv.Text +"','"+Txthoten.Text+"', '"+ txtDiemTB.Text+"', '"+ comboBox1.Text+"')";
            command.ExecuteNonQuery();
            
            loaddata();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " delete from Student where student_id= '"+txtMasv.Text+"' ";

            command.ExecuteNonQuery();
            loaddata();

        }
    }
}
