
namespace CourseApp.Forms
{
    partial class StudentForm
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
            this.lblStudentFirstname = new System.Windows.Forms.Label();
            this.txtStudentFirstname = new System.Windows.Forms.TextBox();
            this.lblStudentLastname = new System.Windows.Forms.Label();
            this.txtStudentLastname = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.cbxGroupName = new System.Windows.Forms.ComboBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblClassroomName = new System.Windows.Forms.Label();
            this.cbxClassroomName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentFirstname
            // 
            this.lblStudentFirstname.AutoSize = true;
            this.lblStudentFirstname.Location = new System.Drawing.Point(9, 19);
            this.lblStudentFirstname.Name = "lblStudentFirstname";
            this.lblStudentFirstname.Size = new System.Drawing.Size(92, 13);
            this.lblStudentFirstname.TabIndex = 0;
            this.lblStudentFirstname.Text = "Student Firstname";
            // 
            // txtStudentFirstname
            // 
            this.txtStudentFirstname.Location = new System.Drawing.Point(12, 35);
            this.txtStudentFirstname.Name = "txtStudentFirstname";
            this.txtStudentFirstname.Size = new System.Drawing.Size(203, 20);
            this.txtStudentFirstname.TabIndex = 1;
            // 
            // lblStudentLastname
            // 
            this.lblStudentLastname.AutoSize = true;
            this.lblStudentLastname.Location = new System.Drawing.Point(9, 74);
            this.lblStudentLastname.Name = "lblStudentLastname";
            this.lblStudentLastname.Size = new System.Drawing.Size(93, 13);
            this.lblStudentLastname.TabIndex = 2;
            this.lblStudentLastname.Text = "Student Lastname";
            // 
            // txtStudentLastname
            // 
            this.txtStudentLastname.Location = new System.Drawing.Point(12, 90);
            this.txtStudentLastname.Name = "txtStudentLastname";
            this.txtStudentLastname.Size = new System.Drawing.Size(200, 20);
            this.txtStudentLastname.TabIndex = 3;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(12, 153);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(200, 20);
            this.txtStudentEmail.TabIndex = 4;
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Location = new System.Drawing.Point(12, 137);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(32, 13);
            this.lblStudentEmail.TabIndex = 5;
            this.lblStudentEmail.Text = "Email";
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.AllowUserToResizeRows = false;
            this.dgvStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Firstname,
            this.Lastname,
            this.GroupName,
            this.ClassroomName});
            this.dgvStudentList.Location = new System.Drawing.Point(227, 35);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.Size = new System.Drawing.Size(442, 350);
            this.dgvStudentList.TabIndex = 6;
            // 
            // cbxGroupName
            // 
            this.cbxGroupName.FormattingEnabled = true;
            this.cbxGroupName.Location = new System.Drawing.Point(12, 214);
            this.cbxGroupName.Name = "cbxGroupName";
            this.cbxGroupName.Size = new System.Drawing.Size(197, 21);
            this.cbxGroupName.TabIndex = 7;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(12, 198);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(36, 13);
            this.lblGroupName.TabIndex = 8;
            this.lblGroupName.Text = "Group";
            // 
            // lblClassroomName
            // 
            this.lblClassroomName.AutoSize = true;
            this.lblClassroomName.Location = new System.Drawing.Point(9, 260);
            this.lblClassroomName.Name = "lblClassroomName";
            this.lblClassroomName.Size = new System.Drawing.Size(55, 13);
            this.lblClassroomName.TabIndex = 9;
            this.lblClassroomName.Text = "Classroom";
            // 
            // cbxClassroomName
            // 
            this.cbxClassroomName.FormattingEnabled = true;
            this.cbxClassroomName.Location = new System.Drawing.Point(12, 277);
            this.cbxClassroomName.Name = "cbxClassroomName";
            this.cbxClassroomName.Size = new System.Drawing.Size(197, 21);
            this.cbxClassroomName.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 365);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(119, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Student Firstname";
            this.Firstname.Name = "Firstname";
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Student Lastname";
            this.Lastname.Name = "Lastname";
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Group";
            this.GroupName.Name = "GroupName";
            // 
            // ClassroomName
            // 
            this.ClassroomName.HeaderText = "Classroom";
            this.ClassroomName.Name = "ClassroomName";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 395);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxClassroomName);
            this.Controls.Add(this.lblClassroomName);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.cbxGroupName);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.lblStudentEmail);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtStudentLastname);
            this.Controls.Add(this.lblStudentLastname);
            this.Controls.Add(this.txtStudentFirstname);
            this.Controls.Add(this.lblStudentFirstname);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentFirstname;
        private System.Windows.Forms.TextBox txtStudentFirstname;
        private System.Windows.Forms.Label lblStudentLastname;
        private System.Windows.Forms.TextBox txtStudentLastname;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomName;
        private System.Windows.Forms.ComboBox cbxGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblClassroomName;
        private System.Windows.Forms.ComboBox cbxClassroomName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}