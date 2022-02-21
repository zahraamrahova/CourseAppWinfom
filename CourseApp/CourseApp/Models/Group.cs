﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    class Group
    {
        public int Id { get; set; }
        public int ClassroomId { get; set; }
        public string Name { get; set; }
        public Classroom Classroom { get; set; }

        public List<Student> Students { get; set; }

    }
}
