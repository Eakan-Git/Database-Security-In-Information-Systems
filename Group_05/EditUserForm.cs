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
    public partial class EditUserForm : Form
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
        OracleDataReader dr;
        DataTable dt;
        string username;
        public EditUserForm(string _username)
        {
            InitializeComponent();
            username = _username;
            loadTableList();
            loadRoleList();
        }
        private void loadTableList()
        {
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            OracleCommand cmd2 = new OracleCommand("SELECT table_name FROM user_tables", conn);
            dr = cmd2.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            TableDGV.DataSource = dt;
            conn.Close();
        }
        private void loadRoleList()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Fill_SelectDGV()
        {
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            //string tableName = TableDGV.SelectedCells[0].Value.ToString();
            string tableName = TableDGV.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(tableName);
            conn.Open();
            OracleDataReader dr2;
            cmd = new OracleCommand("select column_name from USER_TAB_COLUMNS where table_name = :tableName", conn);
            cmd.Parameters.Add(new OracleParameter("tableName", tableName.ToUpper()));
            dr2 = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            DGVSelect.DataSource = dt2;
            conn.Close();
        }
        private void Fill_UpdateDGV()
        {
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string tableName = TableDGV.CurrentRow.Cells[0].Value.ToString();
            OracleDataReader dr3;
            DataTable dt3 = new DataTable();

            OracleCommand cmd2 = new OracleCommand("select column_name from USER_TAB_COLUMNS where table_name = :tableName", conn);
            cmd2.Parameters.Add(new OracleParameter("tableName", tableName.ToUpper()));
            dr3 = cmd2.ExecuteReader();
            dt3.Load(dr3);
            DGVUpdate.DataSource = dt3;
            conn.Close();
        }
        private void TableDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Fill_SelectDGV();
                Fill_UpdateDGV();
                string tableName = TableDGV.CurrentRow.Cells[0].Value.ToString();
                cbInsertTable.Checked = loadCheckbox(username, tableName, "INSERT");
                cbDeleteTable.Checked = loadCheckbox(username, tableName, "DELETE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GrantPrivilegeSelectOnColumn(String username, String table, String column, bool grantable)
        {
            String grantableStr = "N";
            if (grantable)
            {
                grantableStr = "Y";
            }
            OracleCommand command = new OracleCommand("GRANT_SELECT_ON_COLUMN", conn);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("Table_name", OracleDbType.Varchar2);
            param1.Value = table;
            OracleParameter param2 = new OracleParameter("user_name", OracleDbType.Varchar2);
            param2.Value = username;
            OracleParameter param3 = new OracleParameter("column_list", OracleDbType.Varchar2);
            param3.Value = column;
            OracleParameter param4 = new OracleParameter("grant_opt", OracleDbType.Char);
            param4.Value = grantableStr;

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }
        private void cbDeleteTable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbInsertTable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RoleDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RevokeAllPrivilegesOnTable(String username, String table)
        {
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE ALL PRIVILEGES ON {table} FROM {username}";
            command.Connection = conn;
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (OracleException ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
        }
        private bool loadCheckbox(string username, string tablename, string privilege)
        {
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            OracleCommand command = new OracleCommand("SELECT PRIVILEGE FROM DBA_TAB_PRIVS WHERE GRANTEE = :userName AND TYPE = 'TABLE' AND TABLE_NAME = :tableName AND PRIVILEGE = :privilege", conn);
            command.Parameters.Add(new OracleParameter("userName", username.ToUpper()));
            command.Parameters.Add(new OracleParameter("tableName", tablename.ToUpper()));
            command.Parameters.Add(new OracleParameter("privilege", privilege.ToUpper()));
            OracleDataReader dr;
            dr = command.ExecuteReader();
            if (dr.HasRows) return true;
            return false;
        }
        private void buttonRevokeAllTable_Click(object sender, EventArgs e)
        {
            string tableName = TableDGV.CurrentRow.Cells[0].Value.ToString();
            var confirmResult = MessageBox.Show("Are you sure to revoke all privileges on this table?", "Confirm Revoke!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    RevokeAllPrivilegesOnTable(username.ToUpper(), tableName.ToUpper());
                    MessageBox.Show("Revoke Succeed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Fill_SelectDGV();
            Fill_UpdateDGV();
            cbInsertTable.Checked = loadCheckbox(username, tableName, "INSERT");
            cbDeleteTable.Checked = loadCheckbox(username, tableName, "DELETE");
        }

        private void DGVSelect_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string tableName = TableDGV.CurrentRow.Cells[0].Value.ToString();
            //string column = TableDGV.CurrentRow.Cells[2].Value.ToString();
            //bool grantable = (bool)TableDGV.CurrentRow.Cells[1].Value;
            //if (e.ColumnIndex == cbc_select.Index && e.RowIndex != -1 && cbc_select.Selected == true)
            //{
            //    GrantPrivilegeSelectOnColumn(username.ToUpper(), tableName.ToUpper(), column.ToUpper(), grantable);
            //}
            //else if(e.ColumnIndex == cbc_select.Index && e.RowIndex != -1 && cbc_select.Selected == false)
            //{
            //    RevokePrivilegeSelectOnColumn(username.ToUpper(), tableName.ToUpper(), column.ToUpper());
            //}
            //else
            //{
            //    MessageBox.Show("Unhandled Error!");
            //}
        }
        public void RevokePrivilegeSelectOnColumn(String username, String table, String column)
        {
            try
            {
                OracleCommand command = new OracleCommand();
                command.CommandText = $"REVOKE SELECT ON {table + "_" + column + "_" + username + "_view"} FROM {username}";
                command.Connection = conn;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
        }
    }
}
