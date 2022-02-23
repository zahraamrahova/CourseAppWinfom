
namespace CourseApp.Forms
{
    partial class GroupForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblClassroom = new System.Windows.Forms.Label();
            this.cbxClassroom = new System.Windows.Forms.ComboBox();
            this.btnSaveandUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Group Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(12, 51);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(156, 20);
            this.tbxName.TabIndex = 1;
            // 
            // lblClassroom
            // 
            this.lblClassroom.AutoSize = true;
            this.lblClassroom.Location = new System.Drawing.Point(15, 105);
            this.lblClassroom.Name = "lblClassroom";
            this.lblClassroom.Size = new System.Drawing.Size(55, 13);
            this.lblClassroom.TabIndex = 2;
            this.lblClassroom.Text = "Classroom";
            // 
            // cbxClassroom
            // 
            this.cbxClassroom.FormattingEnabled = true;
            this.cbxClassroom.Location = new System.Drawing.Point(12, 130);
            this.cbxClassroom.Name = "cbxClassroom";
            this.cbxClassroom.Size = new System.Drawing.Size(156, 21);
            this.cbxClassroom.TabIndex = 3;
            // 
            // btnSaveandUpdate
            // 
            this.btnSaveandUpdate.Location = new System.Drawing.Point(12, 187);
            this.btnSaveandUpdate.Name = "btnSaveandUpdate";
            this.btnSaveandUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveandUpdate.TabIndex = 4;
            this.btnSaveandUpdate.Text = "Save";
            this.btnSaveandUpdate.UseVisualStyleBackColor = true;
            this.btnSaveandUpdate.Click += new System.EventHandler(this.btnSaveandUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvGroup
            // 
            this.dgvGroup.AllowUserToAddRows = false;
            this.dgvGroup.AllowUserToDeleteRows = false;
            this.dgvGroup.AllowUserToResizeRows = false;
            this.dgvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GroupName,
            this.ClassroomName});
            this.dgvGroup.Location = new System.Drawing.Point(249, 28);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.Size = new System.Drawing.Size(270, 293);
            this.dgvGroup.TabIndex = 6;
            this.dgvGroup.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGroup_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Group Name";
            this.GroupName.Name = "GroupName";
            // 
            // ClassroomName
            // 
            this.ClassroomName.HeaderText = "Classroom Name";
            this.ClassroomName.Name = "ClassroomName";
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 331);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveandUpdate);
            this.Controls.Add(this.cbxClassroom);
            this.Controls.Add(this.lblClassroom);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Name = "GroupForm";
            this.Text = "Group";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblClassroom;
        private System.Windows.Forms.ComboBox cbxClassroom;
        private System.Windows.Forms.Button btnSaveandUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomName;
    }
}