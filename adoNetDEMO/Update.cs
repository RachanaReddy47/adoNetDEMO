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
    public partial class Update : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-FTR5U2I");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                Cmd = new SqlCommand("Update Emp set ename=@Ename, Deptno=@D where Empno=@Eno", Con);
                Cmd.Parameters.AddWithValue("@Ename", txtNumber2.Text);
                Cmd.Parameters.AddWithValue("@D", int.Parse(textBox1.Text));
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtNumber1.Text));
                int r = Cmd.ExecuteNonQuery();
                if (r != 0)
                    MessageBox.Show(r + "updated");
                else
                    MessageBox.Show("No Employee Exists");


            }
            //catch(InvalidOperationException E)
            //{
            // MessageBox.Show("No Employee exists");
            //}

            catch (FormatException E)
            {
                MessageBox.Show("Enter details in deptno");
            }
            catch (SqlException E)
            {
                MessageBox.Show("Ename must be given within 50 characters");
            }
            finally
            {
                Con.Close();
            }

        }

        private void btn_Extract_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                Cmd = new SqlCommand("Select * from Emp where Empno=@eno", Con);
                Cmd.Parameters.AddWithValue("@eno", int.Parse(txtNumber1.Text));
                SqlDataReader R = Cmd.ExecuteReader();
                R.Read();
                txtNumber2.Text = R[1].ToString();
                comboBox1.Text = R[2].ToString();
                dateTimePicker1.Text = R[3].ToString();
                textBox1.Text = R[4].ToString();
               
            }
            catch(InvalidOperationException E)
            {
                MessageBox.Show("No Employee exists with this number"+E.Message);
                txtNumber2.Text = "";
                textBox1.Text = "";


            }

            catch (FormatException E)
            {
                MessageBox.Show("Enter only number in Empno");
            }
            finally
            {
                Con.Close();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("delete from Emp where Empno=@Eno",Con);
            Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtNumber1.Text));
            int r = Cmd.ExecuteNonQuery();
            MessageBox.Show(r + "deleted");
            Con.Close();
        }
    }
}
