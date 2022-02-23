using CourseApp.DAL;
using CourseApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseApp.Forms
{
    public partial class GroupForm : Form
    {
       readonly  GroupDTO groupDTO;
        readonly ClassroomDTO classroomDTO;
         Group selectedGroup;
        public GroupForm()
        {
            InitializeComponent();
            groupDTO = new GroupDTO();
            classroomDTO = new ClassroomDTO();
            selectedGroup = new Group();
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            FillGroups();
            FillCombobox();
        }

        public void FillGroups()
        {
            dgvGroup.Rows.Clear();
            List<Group> groups = groupDTO.GetAll();
            foreach (Group item in groups)
            {
                dgvGroup.Rows.Add(item.Id, item.Name, item.Classroom.Name);
               
            }
        }

        public void FillCombobox()
        {
            List<Classroom> classrooms = classroomDTO.GetAll();
            foreach (Classroom item in classrooms)
            {
                
                cbxClassroom.Items.Add(item.Name);
            }
        }
        private void ClearControls()
        {
            tbxName.Text = "";
            cbxClassroom.SelectedIndex = -1;
        }

        private void btnSaveandUpdate_Click(object sender, EventArgs e)
        {
            if (btnSaveandUpdate.Text== "Save")
            {
                Group group = new Group();
                group.Name = tbxName.Text;
                string classroomName = cbxClassroom.SelectedItem.ToString();

                Classroom classroom = classroomDTO.GetWithName(classroomName);
                group.ClassroomId = classroom.Id;
                if (groupDTO.Create(group))
                {
                    ClearControls();
                    MessageBox.Show("Successufully created");
                }
                else
                {
                    MessageBox.Show("Not created");
                }
                FillGroups();

            }
            else
            {
                if (selectedGroup != null)
                {
                    selectedGroup.Name = tbxName.Text;
                    string name = cbxClassroom.SelectedItem.ToString();
                    Classroom classroom = classroomDTO.GetWithName(name);
                    selectedGroup.ClassroomId = classroom.Id;
                    tbxName.Text = "";
                    cbxClassroom.Text = "";
                    if (groupDTO.Update(selectedGroup))
                    {
                        ClearControls();
                        MessageBox.Show("Successufully updated");
                    }
                    else
                    {
                        MessageBox.Show("Not updated");
                    }
                    FillGroups();
                }

                btnSaveandUpdate.Text = "Save";
               

            }

        }

        
        private void dgvGroup_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Id = (int)dgvGroup.Rows[e.RowIndex].Cells[0].Value;

            selectedGroup = groupDTO.Get(Id);

            tbxName.Text = selectedGroup.Name;
            Classroom clasroom = classroomDTO.Get(selectedGroup.ClassroomId);
            cbxClassroom.Text = clasroom.Name;
            btnSaveandUpdate.Text = "Update";
            btnDelete.Visible = true;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedGroup != null)
            {
                groupDTO.Delete(selectedGroup.Id);
                FillGroups();
            }
        }
    }
}
