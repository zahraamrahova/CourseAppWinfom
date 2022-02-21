using CourseApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.DAL
{
    class StudentDTO : Base
    {

        public List<Student> GetAll()
        {
            _conn.Open();

            string q = @"SELECT s.*, g.*, Classrooms.* FROM Students as s INNER JOIN Groups as g ON s.GroupId=g.Id INNER JOIN Classrooms ON g.ClassroomId=Classrooms.Id";
            SqlCommand command = new SqlCommand(q, _conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {

                Classroom c = new Classroom
                {
                    Id = reader.GetInt32(8),
                    Name = reader.GetString(9),
                    Capacity = reader.GetInt32(10)
                };
                Group g = new Group
                {
                    Id = reader.GetInt32(5),
                    Name = reader.GetString(6),
                    ClassroomId = reader.GetInt32(7),
                    Classroom = c

                };
                Student s = new Student
                {
                    Id = reader.GetInt32(0),
                    Firstname = reader.GetString(1),
                    Lastname = reader.GetString(2),
                    Email = reader.GetString(3),
                    GroupId = reader.GetInt32(4),
                    Group = g
                };

                students.Add(s);
            }
            _conn.Close();
            return students;
        }
    }
}
