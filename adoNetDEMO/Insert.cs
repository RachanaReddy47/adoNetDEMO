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
    public partial class Insert : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Insert()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            //step1
            Con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ADODB;Data Source=DESKTOP-FTR5U2I");

        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //step2
                Con.Open();
                //step3
                Cmd = new SqlCommand("insert into Emp values(@Eno,@En,@G,@D)", Con);
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtNumber1.Text));
                Cmd.Parameters.AddWithValue("@En", txtNumber2.Text);
                Cmd.Parameters.AddWithValue("@G", comboBox1.Text);
                Cmd.Parameters.AddWithValue("@D", DateTime.Parse(dateTimePicker1.Text));

                //step 4
                int R = Cmd.ExecuteNonQuery();
                MessageBox.Show(R + "Row inserted");
            }
            catch (Exception E)
            {
                if (E.Message.Contains("PK_Emp"))
                    MessageBox.Show("Empno cannot be duplicate");
                if (E.Message.Contains("CK_dob"))
                    MessageBox.Show("Age must be minimum 21");
                if (E.Message.Contains("CK_Gender"))
                    MessageBox.Show("Gender must be selected from list");

            }

            catch(FormatException E)
            {
                MessageBox.Show("Enter all details");
            }
            //step5
            finally
            {
                Con.Close();
            }
                
            

        }

        private void txtNumber3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
