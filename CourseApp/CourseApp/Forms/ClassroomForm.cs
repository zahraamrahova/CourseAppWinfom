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

        public ClassroomForm()
        {
            InitializeComponent();
            classroomDTO = new ClassroomDTO();
        }

        private void ClassroomForm_Load(object sender, EventArgs e)
        {
            FillClassrooms();
        }

        public void FillClassrooms()
        {
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
                MessageBox.Show("Successufully created");
            }
            else
            {
                MessageBox.Show("Not created");
            }

        }
    }
}
