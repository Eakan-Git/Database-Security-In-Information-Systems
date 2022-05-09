using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace _19127237_19127471_19127608
{
    public partial class AddUserForm : Form
    {
        string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
            ");User Id = PH1; password = hihi;";
        OracleConnection conn;
        OracleCommand cmd;
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != "" && tbUsername.Text != "")
            {
                try
                {
                    conn = new OracleConnection();
                    conn.ConnectionString = ConnectionString;
                    conn.Open();
                    cmd = new OracleCommand("sp_CreateUser", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tbUsername.Text;
                    cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = tbPassword.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User created!");
                    this.Close();
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Username existed!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all information!");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
