
namespace _19127237_19127471_19127608
{
    partial class HomeForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRefreshRole = new System.Windows.Forms.Button();
            this.buttonDeleteRole = new System.Windows.Forms.Button();
            this.buttonEditRole = new System.Windows.Forms.Button();
            this.buttonCreateRole = new System.Windows.Forms.Button();
            this.RoleDGV = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUsersList = new System.Windows.Forms.Panel();
            this.panelListControl = new System.Windows.Forms.Panel();
            this.buttonRefreshUser = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.UserListDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDGV)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelUsersList.SuspendLayout();
            this.panelListControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserListDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Controls.Add(this.panelUsersList);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 79);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 434);
            this.panelContent.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.RoleDGV);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(408, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 411);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.buttonRefreshRole);
            this.panel3.Controls.Add(this.buttonDeleteRole);
            this.panel3.Controls.Add(this.buttonEditRole);
            this.panel3.Controls.Add(this.buttonCreateRole);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 70);
            this.panel3.TabIndex = 4;
            // 
            // buttonRefreshRole
            // 
            this.buttonRefreshRole.Location = new System.Drawing.Point(265, 24);
            this.buttonRefreshRole.Name = "buttonRefreshRole";
            this.buttonRefreshRole.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshRole.TabIndex = 4;
            this.buttonRefreshRole.Text = "Refresh";
            this.buttonRefreshRole.UseVisualStyleBackColor = true;
            this.buttonRefreshRole.Click += new System.EventHandler(this.buttonRefreshRole_Click);
            // 
            // buttonDeleteRole
            // 
            this.buttonDeleteRole.Location = new System.Drawing.Point(184, 24);
            this.buttonDeleteRole.Name = "buttonDeleteRole";
            this.buttonDeleteRole.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRole.TabIndex = 2;
            this.buttonDeleteRole.Text = "Delete";
            this.buttonDeleteRole.UseVisualStyleBackColor = true;
            this.buttonDeleteRole.Click += new System.EventHandler(this.buttonDeleteRole_Click);
            // 
            // buttonEditRole
            // 
            this.buttonEditRole.Location = new System.Drawing.Point(103, 24);
            this.buttonEditRole.Name = "buttonEditRole";
            this.buttonEditRole.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRole.TabIndex = 1;
            this.buttonEditRole.Text = "Edit";
            this.buttonEditRole.UseVisualStyleBackColor = true;
            // 
            // buttonCreateRole
            // 
            this.buttonCreateRole.Location = new System.Drawing.Point(22, 24);
            this.buttonCreateRole.Name = "buttonCreateRole";
            this.buttonCreateRole.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateRole.TabIndex = 0;
            this.buttonCreateRole.Text = "Create";
            this.buttonCreateRole.UseVisualStyleBackColor = true;
            this.buttonCreateRole.Click += new System.EventHandler(this.buttonCreateRole_Click);
            // 
            // RoleDGV
            // 
            this.RoleDGV.AllowUserToAddRows = false;
            this.RoleDGV.AllowUserToDeleteRows = false;
            this.RoleDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleDGV.Location = new System.Drawing.Point(0, 71);
            this.RoleDGV.MaximumSize = new System.Drawing.Size(363, 264);
            this.RoleDGV.MinimumSize = new System.Drawing.Size(363, 264);
            this.RoleDGV.MultiSelect = false;
            this.RoleDGV.Name = "RoleDGV";
            this.RoleDGV.ReadOnly = true;
            this.RoleDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RoleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoleDGV.Size = new System.Drawing.Size(363, 264);
            this.RoleDGV.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 65);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ROLE";
            // 
            // panelUsersList
            // 
            this.panelUsersList.Controls.Add(this.panelListControl);
            this.panelUsersList.Controls.Add(this.UserListDGV);
            this.panelUsersList.Controls.Add(this.panel2);
            this.panelUsersList.Location = new System.Drawing.Point(30, 12);
            this.panelUsersList.Name = "panelUsersList";
            this.panelUsersList.Size = new System.Drawing.Size(363, 411);
            this.panelUsersList.TabIndex = 2;
            // 
            // panelListControl
            // 
            this.panelListControl.BackColor = System.Drawing.Color.Gainsboro;
            this.panelListControl.Controls.Add(this.buttonRefreshUser);
            this.panelListControl.Controls.Add(this.buttonDelete);
            this.panelListControl.Controls.Add(this.buttonEdit);
            this.panelListControl.Controls.Add(this.buttonAdd);
            this.panelListControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListControl.Location = new System.Drawing.Point(0, 341);
            this.panelListControl.Name = "panelListControl";
            this.panelListControl.Size = new System.Drawing.Size(363, 70);
            this.panelListControl.TabIndex = 4;
            // 
            // buttonRefreshUser
            // 
            this.buttonRefreshUser.Location = new System.Drawing.Point(265, 24);
            this.buttonRefreshUser.Name = "buttonRefreshUser";
            this.buttonRefreshUser.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshUser.TabIndex = 3;
            this.buttonRefreshUser.Text = "Refresh";
            this.buttonRefreshUser.UseVisualStyleBackColor = true;
            this.buttonRefreshUser.Click += new System.EventHandler(this.buttonRefreshUser_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(184, 24);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(103, 24);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(22, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Create";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // UserListDGV
            // 
            this.UserListDGV.AllowUserToAddRows = false;
            this.UserListDGV.AllowUserToDeleteRows = false;
            this.UserListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListDGV.Location = new System.Drawing.Point(0, 71);
            this.UserListDGV.MaximumSize = new System.Drawing.Size(363, 264);
            this.UserListDGV.MinimumSize = new System.Drawing.Size(363, 264);
            this.UserListDGV.MultiSelect = false;
            this.UserListDGV.Name = "UserListDGV";
            this.UserListDGV.ReadOnly = true;
            this.UserListDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UserListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserListDGV.Size = new System.Drawing.Size(363, 264);
            this.UserListDGV.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 79);
            this.panelTitle.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(201, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(399, 42);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ADMIN DASHBOARD";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitle);
            this.MaximumSize = new System.Drawing.Size(816, 552);
            this.MinimumSize = new System.Drawing.Size(816, 552);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panelContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoleDGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelUsersList.ResumeLayout(false);
            this.panelListControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserListDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRefreshRole;
        private System.Windows.Forms.Button buttonDeleteRole;
        private System.Windows.Forms.Button buttonEditRole;
        private System.Windows.Forms.Button buttonCreateRole;
        private System.Windows.Forms.DataGridView RoleDGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelUsersList;
        private System.Windows.Forms.Panel panelListControl;
        private System.Windows.Forms.Button buttonRefreshUser;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView UserListDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
    }
}

