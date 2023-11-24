using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vd22_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            List<Student> listStudent = GetTempListStudent();
            
            

            this.reportViewer2.RefreshReport();
            
        }
        public class Student
        {
            public string StudentID { get; set; }

            public string FullName { get; set; }

            public DateTime Birthday { get; set; }

            public string Address { get; set; }

            public Student()
            {
            }
            public Student(String id, string name, DateTime dtBrthday, string add)
            {
                StudentID = id;
                FullName = name;
                Birthday = dtBrthday;
                Address = add;
            }
        }
        public List<Student> GetTempListStudent()
        {
            List<Student> listStudent = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student temp = new Student();
                temp.StudentID = "CNTT0120" + i;
                temp.FullName = "Nguyễn Văn" + i;
                temp.Birthday = new DateTime(2000, 1, 1);
                temp.Address = "Địa chỉ" + i;

                listStudent.Add(temp);
            }
            return listStudent;
        }

       

        private void reportViewer2_Load_1(object sender, EventArgs e)
        {
           
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            List<Student> listStudent = GetTempListStudent();
            ReportDataSource rds = new ReportDataSource("DataSetStudent", listStudent);
            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.RefreshReport();
        }
    }
}
