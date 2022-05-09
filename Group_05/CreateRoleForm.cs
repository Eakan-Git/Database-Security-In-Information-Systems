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
    public partial class CreateRoleForm : Form
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
        public CreateRoleForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateRole_Click(object sender, EventArgs e)
        {
            if (tbRoleName.Text != "")
            {
                try
                {
                    conn = new OracleConnection();
                    conn.ConnectionString = ConnectionString;
                    conn.Open();
                    cmd = new OracleCommand("sp_CreateRole", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("role_name", OracleDbType.Varchar2).Value = tbRoleName.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Role created!");
                    this.Close();
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Role/User existed!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all information!");
            }
        }
    }
}
