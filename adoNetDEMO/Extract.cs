using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace adoNetDEMO
{
    public partial class Extract : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Extract()
        {
            
            InitializeComponent();
        }

        private void Extract_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(" Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Emp;Data Source=DESKTOP-FTR5U2I");
        }

        private void btngetdata1_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("select * from Empdata where deptno=@D", Con);
            Cmd.Parameters.AddWithValue("@D", int.Parse(txtDeptno.Text));
            SqlDataReader R=Cmd.ExecuteReader();
            DataSet DS = new DataSet();
            DS.Tables.Add("Deptdata");
            DS.Tables["Deptdata"].Load(R);
            dgvData.DataSource = DS.Tables["Deptdata"];
            Con.Close();



        }

        private void btngetdata1_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("select * from Empdata where hiredate between @S and @E", Con);
            Cmd.Parameters.AddWithValue("@S", DateTime.Parse(dateTimePicker1.Text));
            Cmd.Parameters.AddWithValue("@E", DateTime.Parse(dateTimePicker2.Text));
            SqlDataReader R = Cmd.ExecuteReader();
            DataSet DS = new DataSet();
            DS.Tables.Add("Deptdata");
            DS.Tables["Deptdata"].Load(R);
            dgvData.DataSource = DS.Tables["Deptdata"];
            Con.Close();
        }

        private void Getdata2_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("select * from VW_EMPDATA", Con);
            SqlDataReader R = Cmd.ExecuteReader();
            DataSet DS = new DataSet();
            DS.Tables.Add("Deptdata");
            DS.Tables["Deptdata"].Load(R);
            dgvData.DataSource = DS.Tables["Deptdata"];
            Con.Close();
        }
    }
}
