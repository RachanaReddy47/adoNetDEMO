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
    public partial class Example : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        public Example()
        {
            InitializeComponent();
        }

        private void Example_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-FTR5U2I");
            Adp = new SqlDataAdapter("Select * from Deptdata", Con);
            DataSet DS = new DataSet();
            Adp.Fill(DS, "Dno");
            comboBox.DataSource = DS.Tables["Dno"];
            comboBox.ValueMember = "deptno";
            comboBox.DisplayMember = "dname";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-FTR5U2I");
                Adp = new SqlDataAdapter("Select * from Empdata", Con);
                DataSet DS = new DataSet();
                Adp.Fill(DS, "E");
                DataRow R = DS.Tables["E"].NewRow();
                R[0] = int.Parse(txtempno.Text);
                R[1] = txtename.Text;
                R[2] = txtjob.Text;
                R[3] = int.Parse(txtmgr.Text);
                R[4] = DateTime.Parse(dateTimePicker.Text);
                R[5] = int.Parse(txtsalary.Text);
                R[6] = int.Parse(txtcmsn.Text);
                R[7] = comboBox.SelectedValue;
                DS.Tables["E"].Rows.Add(R);
                SqlCommandBuilder cb = new SqlCommandBuilder(Adp);
                Adp.InsertCommand = cb.GetInsertCommand();
                Adp.Update(DS, "E");
                MessageBox.Show("1 row updated");
                Clear();
            }
            catch(SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public void Clear()
        {
            txtempno.Text = " ";
            txtename.Text = " ";
            txtjob.Text = " ";
            txtmgr.Text = " ";
            txtsalary.Text = " ";
            txtcmsn.Text = " ";
            comboBox.Text = " ";


        }

       
    }
}
