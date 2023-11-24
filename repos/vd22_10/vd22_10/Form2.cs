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
using Microsoft.Reporting.WinForms;

namespace vd22_10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnt;
            connetionString = @"Data Source = LAPTOP-4QHEND5O\PHUONG;
            Initial Catalog = STUDENT112;Integrated Security =True; User ID =sa; Password=1234";
            cnt = new SqlConnection(connetionString);
            cnt.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Student", cnt);
            DataTable dt = new DataTable("DataSetStudentdataset");
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSetStudentdataset", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
             cnt.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
