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
        public StudentForm()
        {
            InitializeComponent();
            studentDTO = new StudentDTO();
            classroomDTO = new ClassroomDTO();
            groupDTO = new GroupDTO();
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
    }
}
