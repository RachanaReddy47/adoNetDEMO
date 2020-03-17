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
    public partial class CommandBuilderEx1 : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        public CommandBuilderEx1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con= new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-FTR5U2I");
            Adp = new SqlDataAdapter("select * from Empdata",Con);
            DataSet DS = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(Adp);
            SqlCommand cmd = cb.GetDeleteCommand();
            MessageBox.Show(cmd.CommandText);

        }
    }
}
