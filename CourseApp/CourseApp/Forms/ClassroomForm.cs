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
    public partial class ClassroomForm : Form
    {
        readonly ClassroomDTO classroomDTO;
        Classroom selectedClassroom;

        public ClassroomForm()
        {
            InitializeComponent();
            classroomDTO = new ClassroomDTO();
            selectedClassroom = new Classroom();
        }

        private void ClassroomForm_Load(object sender, EventArgs e)
        {
            FillClassrooms();
        }

        public void FillClassrooms()
        {

            dgvClassroom.Rows.Clear();
            List<Classroom> classrooms = classroomDTO.GetAll();
            foreach (Classroom item in classrooms)
            {
                dgvClassroom.Rows.Add(item.Id, item.Name, item.Capacity);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Classroom c = new Classroom();
            c.Name = txtClassroomName.Text;
            c.Capacity = (int)numericCapacity.Value;
            if(classroomDTO.Create(c))
            {
                ClearControls();
                MessageBox.Show("Successufully created");
            }
            else
            {
                MessageBox.Show("Not created");
            }
            FillClassrooms();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedClassroom != null)
            {
                selectedClassroom.Name= txtClassroomName.Text;
                selectedClassroom.Capacity = (int)numericCapacity.Value;
                txtClassroomName.Text = "";
                numericCapacity.Value = 0;
                if (classroomDTO.Update(selectedClassroom))
                {
                    ClearControls();
                    MessageBox.Show("Successufully updated");
                }
                else
                {
                    MessageBox.Show("Not updated");
                }
                FillClassrooms();
            }
                
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }
        private void dgvClassroom_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Id = (int)dgvClassroom.Rows[e.RowIndex].Cells[0].Value;

            selectedClassroom=classroomDTO.Get(Id);

            txtClassroomName.Text = selectedClassroom.Name;
            numericCapacity.Value = selectedClassroom.Capacity;

            btnSave.Visible = false;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedClassroom!=null)
            {
                classroomDTO.Delete(selectedClassroom.Id);
                FillClassrooms();
            }
        }

       

        private void ClearControls()
        {
            txtClassroomName.Text = "";
            numericCapacity.Value = 0;          
        }

    }
}
