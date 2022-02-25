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
    public partial class StudentForm : Form
    {
        readonly StudentDTO studentDTO;
        readonly ClassroomDTO classroomDTO;
        readonly GroupDTO groupDTO;
        Student selectedStudent;
        public StudentForm()
        {
            InitializeComponent();
            studentDTO = new StudentDTO();
            classroomDTO = new ClassroomDTO();
            groupDTO = new GroupDTO();
            selectedStudent = new Student();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            FillStudents();
            FillClassroomBx();
            FillGroupBx();
            ClearControls();

        }

        public void FillStudents()
        {
            dgvStudentList.Rows.Clear();
            List<Student> students = studentDTO.GetAll();
            foreach (Student item in students)
            {
                dgvStudentList.Rows.Add(item.Id, item.Firstname, item.Lastname, item.Email, item.Group.Name, item.Group.Classroom.Name);

            }
        }

        public void FillClassroomBx()
        {
            List<Classroom> classrooms = classroomDTO.GetAll();
            foreach (Classroom item in classrooms)
            {

                cbxClassroomName.Items.Add(item.Name);
            }
        }

        public void FillGroupBx()
        {
            List<Group> groups = groupDTO.GetAll();
            foreach (Group item in groups)
            {

                cbxGroupName.Items.Add(item.Name);
            }
        }

        public void ClearControls()
        {
            txtStudentFirstname.Text = "";
            txtStudentLastname.Text = "";
            txtStudentEmail.Text = "";
            cbxClassroomName.SelectedIndex = -1;
            cbxGroupName.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Firstname = txtStudentFirstname.Text;
            student.Lastname = txtStudentLastname.Text;
            student.Email = txtStudentEmail.Text;
            string groupName = cbxGroupName.SelectedItem.ToString();
            Group group = groupDTO.GetWithName(groupName);
            student.GroupId = group.Id;


            if (studentDTO.Create(student))
            {
                ClearControls();
                MessageBox.Show("Successufully created");
            }
            else
            {
                MessageBox.Show("Not created");
            }
            FillStudents();

        }

        private void dgvStudentList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Id = (int)dgvStudentList.Rows[e.RowIndex].Cells[0].Value;

            selectedStudent = studentDTO.Get(Id);

            txtStudentFirstname.Text = selectedStudent.Firstname;
            txtStudentLastname.Text = selectedStudent.Lastname;
            txtStudentEmail.Text = selectedStudent.Email;
            Group group = groupDTO.Get(selectedStudent.GroupId);
            cbxGroupName.Text = group.Name;
            Classroom clasroom = classroomDTO.Get(group.ClassroomId);
            cbxClassroomName.Text = clasroom.Name;
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudent != null)
            {
                selectedStudent.Firstname = txtStudentFirstname.Text;
                selectedStudent.Lastname = txtStudentLastname.Text;
                selectedStudent.Email = txtStudentEmail.Text;
                string groupName = cbxGroupName.SelectedItem.ToString();
                Group group = groupDTO.GetWithName(groupName);
                selectedStudent.GroupId = group.Id;
                string classroomName = cbxClassroomName.SelectedItem.ToString();
                Classroom classroom = classroomDTO.GetWithName(classroomName);
                group.ClassroomId = classroom.Id;


                if (studentDTO.Update(selectedStudent))
                {
                    ClearControls();
                    MessageBox.Show("Successufully updated");
                }
                else
                {
                    MessageBox.Show("Not updated");
                }
                FillStudents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudent != null)
            {
                studentDTO.Delete(selectedStudent.Id);
                FillStudents();
                ClearControls();
                btnUpdate.Visible = false;
                btnSave.Visible = true;
            }
        }
    }
}
