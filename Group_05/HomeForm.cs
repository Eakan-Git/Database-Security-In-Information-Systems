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
    public partial class HomeForm : Form
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

        public HomeForm()
        {
            InitializeComponent();

        }
        private void loadUserList()
        {
            OracleDataReader dr;
            DataTable dt;
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string pls = "SELECT username as, user_id, created FROM all_users where username not in ('ANONYMOUS','APEX_040200','APEX_PUBLIC_USER','APPQOSSYS','AUDSYS','BI','CTXSYS','DBSNMP','DIP','DVF','DVSYS','EXFSYS','FLOWS_FILES','GSMADMIN_INTERNAL','GSMCATUSER','GSMUSER','HR','IX','LBACSYS','MDDATA','MDSYS','OE','ORACLE_OCM','ORDDATA','ORDPLUGINS','ORDSYS','OUTLN','PM','SCOTT','SH','SI_INFORMTN_SCHEMA','SPATIAL_CSW_ADMIN_USR','SPATIAL_WFS_ADMIN_USR','SYS','SYSBACKUP','SYSDG','SYSKM','SYSTEM','WMSYS','XDB','SYSMAN','RMAN','RMAN_BACKUP','OWBSYS','OWBSYS_AUDIT','APEX_030200','MGMT_VIEW','OJVMSYS','XS$NULL', 'DBSFWUSER', 'GGSYS', 'OLAPSYS','REMOTE_SCHEDULER_AGENT', 'SYSRAC', 'GSMROOTUSER', 'DGPDB_INT', 'SYS$UMF') ORDER BY created DESC";
            cmd = new OracleCommand(pls, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            UserListDGV.DataSource = dt;
            conn.Close();
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            loadUserList();
            loadRoleList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadRoleList()
        {
            OracleDataReader dr2;
            DataTable dt2;
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            OracleCommand cmd2 = new OracleCommand("SELECT role, role_id FROM DBA_ROLES where role_id between 120 and 10000", conn);
            dr2 = cmd2.ExecuteReader();
            dt2 = new DataTable();
            dt2.Load(dr2);
            RoleDGV.DataSource = dt2;
            conn.Close();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form AddUser = new AddUserForm();
            AddUser.ShowDialog();
            loadUserList();
        }

        private void buttonRefreshUser_Click(object sender, EventArgs e)
        {
            loadUserList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    conn = new OracleConnection();
                    conn.ConnectionString = ConnectionString;
                    conn.Open();
                    cmd = new OracleCommand("sp_DeleteUser", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = UserListDGV.SelectedCells[0].Value.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted!");
                    // MessageBox.Show(UserListDGV.SelectedCells[0].Value.ToString());
                    //this.Close();
                    conn.Close();
                    loadUserList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string username = UserListDGV.SelectedCells[0].Value.ToString();
            Form EditUser = new EditUserForm(username);
            EditUser.ShowDialog();
        }

        private void buttonCreateRole_Click(object sender, EventArgs e)
        {
            Form crform = new CreateRoleForm();
            crform.ShowDialog();
            loadRoleList();
        }

        private void buttonDeleteRole_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this role?", "Confirm Delete!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    conn = new OracleConnection();
                    conn.ConnectionString = ConnectionString;
                    conn.Open();
                    cmd = new OracleCommand("sp_DeleteRole", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = RoleDGV.SelectedCells[0].ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Role deleted!");
                    // MessageBox.Show(UserListDGV.SelectedCells[0].Value.ToString());
                    //this.Close();
                    conn.Close();
                    loadRoleList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonRefreshRole_Click(object sender, EventArgs e)
        {
            loadRoleList();
        }
    }
}
