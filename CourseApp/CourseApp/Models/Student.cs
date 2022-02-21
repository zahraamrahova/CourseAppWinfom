using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    class Student
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public Group Group { get; set; }
    }
}
