
namespace _19127237_19127471_19127608
{
    partial class EditUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RoleDGV = new System.Windows.Forms.DataGridView();
            this.cbc_grantRole = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbc_wgoRole = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonRevokeAllRole = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.DGVUpdate = new System.Windows.Forms.DataGridView();
            this.cbc_Update = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpdateWGO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.DGVSelect = new System.Windows.Forms.DataGridView();
            this.cbc_select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.select_WGO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TableDGV = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonRevokeAllTable = new System.Windows.Forms.Button();
            this.cbDeleteTable = new System.Windows.Forms.CheckBox();
            this.cbInsertTable = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDGV)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpdate)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelect)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableDGV)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.RoleDGV);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(800, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 485);
            this.panel2.TabIndex = 5;
            // 
            // RoleDGV
            // 
            this.RoleDGV.AllowUserToAddRows = false;
            this.RoleDGV.AllowUserToDeleteRows = false;
            this.RoleDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbc_grantRole,
            this.cbc_wgoRole});
            this.RoleDGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.RoleDGV.Location = new System.Drawing.Point(0, 45);
            this.RoleDGV.MultiSelect = false;
            this.RoleDGV.Name = "RoleDGV";
            this.RoleDGV.Size = new System.Drawing.Size(229, 355);
            this.RoleDGV.TabIndex = 3;
            // 
            // cbc_grantRole
            // 
            this.cbc_grantRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbc_grantRole.HeaderText = "GRANT";
            this.cbc_grantRole.Name = "cbc_grantRole";
            // 
            // cbc_wgoRole
            // 
            this.cbc_wgoRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbc_wgoRole.HeaderText = "WGO";
            this.cbc_wgoRole.Name = "cbc_wgoRole";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.buttonRevokeAllRole);
            this.panel6.Controls.Add(this.buttonClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 400);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 85);
            this.panel6.TabIndex = 2;
            // 
            // buttonRevokeAllRole
            // 
            this.buttonRevokeAllRole.Location = new System.Drawing.Point(83, 12);
            this.buttonRevokeAllRole.Name = "buttonRevokeAllRole";
            this.buttonRevokeAllRole.Size = new System.Drawing.Size(75, 23);
            this.buttonRevokeAllRole.TabIndex = 13;
            this.buttonRevokeAllRole.Text = "Revoke All";
            this.buttonRevokeAllRole.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(154, 50);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 45);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ROLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 485);
            this.panel1.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(166, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(612, 355);
            this.panel8.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.DGVUpdate);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(316, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(296, 355);
            this.panel10.TabIndex = 1;
            // 
            // DGVUpdate
            // 
            this.DGVUpdate.AllowUserToAddRows = false;
            this.DGVUpdate.AllowUserToDeleteRows = false;
            this.DGVUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUpdate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbc_Update,
            this.UpdateWGO});
            this.DGVUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUpdate.Location = new System.Drawing.Point(0, 0);
            this.DGVUpdate.MultiSelect = false;
            this.DGVUpdate.Name = "DGVUpdate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUpdate.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVUpdate.Size = new System.Drawing.Size(296, 355);
            this.DGVUpdate.TabIndex = 6;
            // 
            // cbc_Update
            // 
            this.cbc_Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbc_Update.HeaderText = "Update";
            this.cbc_Update.Name = "cbc_Update";
            // 
            // UpdateWGO
            // 
            this.UpdateWGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpdateWGO.HeaderText = "WGO";
            this.UpdateWGO.Name = "UpdateWGO";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.DGVSelect);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 355);
            this.panel9.TabIndex = 0;
            // 
            // DGVSelect
            // 
            this.DGVSelect.AllowUserToAddRows = false;
            this.DGVSelect.AllowUserToDeleteRows = false;
            this.DGVSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSelect.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbc_select,
            this.select_WGO});
            this.DGVSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSelect.Location = new System.Drawing.Point(0, 0);
            this.DGVSelect.MultiSelect = false;
            this.DGVSelect.Name = "DGVSelect";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVSelect.Size = new System.Drawing.Size(300, 355);
            this.DGVSelect.TabIndex = 5;
            // 
            // cbc_select
            // 
            this.cbc_select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbc_select.HeaderText = "SELECT";
            this.cbc_select.Name = "cbc_select";
            // 
            // select_WGO
            // 
            this.select_WGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.select_WGO.HeaderText = "WGO";
            this.select_WGO.Name = "select_WGO";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TableDGV);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(142, 355);
            this.panel7.TabIndex = 2;
            // 
            // TableDGV
            // 
            this.TableDGV.AllowUserToAddRows = false;
            this.TableDGV.AllowUserToDeleteRows = false;
            this.TableDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDGV.Dock = System.Windows.Forms.DockStyle.Right;
            this.TableDGV.Location = new System.Drawing.Point(15, 0);
            this.TableDGV.MultiSelect = false;
            this.TableDGV.Name = "TableDGV";
            this.TableDGV.ReadOnly = true;
            this.TableDGV.Size = new System.Drawing.Size(127, 355);
            this.TableDGV.TabIndex = 4;
            this.TableDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableDGV_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.buttonRevokeAllTable);
            this.panel5.Controls.Add(this.cbDeleteTable);
            this.panel5.Controls.Add(this.cbInsertTable);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 400);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(778, 85);
            this.panel5.TabIndex = 1;
            // 
            // buttonRevokeAllTable
            // 
            this.buttonRevokeAllTable.Location = new System.Drawing.Point(429, 14);
            this.buttonRevokeAllTable.Name = "buttonRevokeAllTable";
            this.buttonRevokeAllTable.Size = new System.Drawing.Size(95, 23);
            this.buttonRevokeAllTable.TabIndex = 8;
            this.buttonRevokeAllTable.Text = "Revoke All";
            this.buttonRevokeAllTable.UseVisualStyleBackColor = true;
            this.buttonRevokeAllTable.Click += new System.EventHandler(this.buttonRevokeAllTable_Click);
            // 
            // cbDeleteTable
            // 
            this.cbDeleteTable.AutoSize = true;
            this.cbDeleteTable.Location = new System.Drawing.Point(85, 18);
            this.cbDeleteTable.Name = "cbDeleteTable";
            this.cbDeleteTable.Size = new System.Drawing.Size(57, 17);
            this.cbDeleteTable.TabIndex = 3;
            this.cbDeleteTable.Text = "Delete";
            this.cbDeleteTable.UseVisualStyleBackColor = true;
            // 
            // cbInsertTable
            // 
            this.cbInsertTable.AutoSize = true;
            this.cbInsertTable.Location = new System.Drawing.Point(15, 18);
            this.cbInsertTable.Name = "cbInsertTable";
            this.cbInsertTable.Size = new System.Drawing.Size(52, 17);
            this.cbInsertTable.TabIndex = 2;
            this.cbInsertTable.Text = "Insert";
            this.cbInsertTable.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 45);
            this.panel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "UPDATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "SELECT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TABLE";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1057, 524);
            this.MinimumSize = new System.Drawing.Size(1057, 524);
            this.Name = "EditUserForm";
            this.Text = "Edit User";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoleDGV)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpdate)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelect)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableDGV)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView RoleDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbc_grantRole;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbc_wgoRole;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonRevokeAllRole;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView DGVUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbc_Update;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UpdateWGO;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView DGVSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbc_select;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select_WGO;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView TableDGV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonRevokeAllTable;
        private System.Windows.Forms.CheckBox cbDeleteTable;
        private System.Windows.Forms.CheckBox cbInsertTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}