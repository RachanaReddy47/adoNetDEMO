using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace adoNetDEMO
{
    public partial class ConnectionLessEx1 : Form
    {
        SqlConnection Con=null;
        SqlDataAdapter adp = null;

        public ConnectionLessEx1()
        {
            InitializeComponent();
        }

        private void ConnectionLessEx1_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-FTR5U2I");
            adp = new SqlDataAdapter("select * from Deptdata ", Con);
            DataSet DS = new DataSet();
            adp.Fill(DS,"Dno");
            comboBox1.DataSource = DS.Tables["Dno"] ;
            comboBox1.ValueMember = "Deptno";
            comboBox1.DisplayMember = "dname";


        }

        private void btn_extract_Click(object sender, EventArgs e)
        {
           

           adp = new SqlDataAdapter("select * from Empdata where deptno=@D", Con);
            adp.SelectCommand.Parameters.AddWithValue("@D", comboBox1.SelectedValue);
            DataSet DS = new DataSet();
            adp.Fill(DS,"Emp");
            dgvData.DataSource = DS.Tables["Emp"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }
    }
}
