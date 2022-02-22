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
        readonly Group selectedGroup;
        public GroupForm()
        {
            InitializeComponent();
            groupDTO = new GroupDTO();
            selectedGroup= new Group();
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            FillGroups();
        }

        public void FillGroups()
        {
            dgvGroup.Rows.Clear();
            List<Group> groups = groupDTO.GetAll();
            foreach (Group item in groups)
            {
                dgvGroup.Rows.Add(item.Id, item.Name, item.Classroom.Name);
                //cbxClassroom.DataSource = groups;
                //cbxClassroom.DisplayMember = item.ClassroomId;
                //cbxClassroom.ValueMember = item.Classroom.Name;
            }
        }
    }
}
