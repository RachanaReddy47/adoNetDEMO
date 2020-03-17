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
    public partial class Example1 : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;

        public Example1()
        {
            InitializeComponent();
        }

        private void txtempno_Leave(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-FTR5U2I ");
            Adp = new SqlDataAdapter("Select * from Empdata where empno=@Eno",Con);
            Adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtempno.Text));
            DS = new DataSet();
            Adp.Fill(DS, "E");
            DataRow R = DS.Tables["E"].Rows[0];
            txtename.Text=R[1].ToString();
            txtjob.Text = R[2].ToString();
            txtmgr.Text = R[3].ToString();
            dateTimePicker.Text = R[4].ToString();
            txtsalary.Text = R[5].ToString();
            txtcmsn.Text = R[6].ToString();
            comboBox.Text= R[7].ToString();


        }
         
       
        private void btndelete_Click(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-FTR5U2I ");
            Adp = new SqlDataAdapter("Select * from Empdata where empno=@Eno", Con);
            Adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtempno.Text));
            DS = new DataSet();
            Adp.Fill(DS, "E");
            DS.Tables["E"].Rows[0].Delete();
            SqlCommandBuilder cb = new SqlCommandBuilder(Adp);
            Adp.DeleteCommand = cb.GetDeleteCommand();
            Adp.Update(DS, "E");
            MessageBox.Show("1 row deleted");

        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-FTR5U2I ");
            Adp = new SqlDataAdapter("Select * from Empdata where empno=@Eno", Con);
            Adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtempno.Text));
            DS = new DataSet();
            Adp.Fill(DS, "E");
            DataRow R = DS.Tables["E"].Rows[0];
            R[2] = txtjob.Text;
            R[3] = txtmgr.Text;
            R[5] = txtsalary.Text;
            if(txtcmsn.Text.Length!=0)
            R[6] = txtcmsn.Text;
            R[7] = comboBox.Text;
            SqlCommandBuilder cb = new SqlCommandBuilder(Adp);
            Adp.UpdateCommand = cb.GetUpdateCommand();
            Adp.Update(DS, "E");
            MessageBox.Show("1 row updated");
        }
    }
}
