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


        public Student Get(int Id)
        {
            _conn.Open();
            string query = @"SELECT * FROM Students WHERE Students.Id = @sid";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@sid", Id);

            SqlDataReader reader = command.ExecuteReader();
            Student student = new Student();
            while (reader.Read())
            {
                student.Id = reader.GetInt32(0);
                student.Firstname = reader.GetString(1);
                student.Lastname = reader.GetString(2);
                student.Email = reader.GetString(3);
                student.GroupId = reader.GetInt32(4);

            }
            _conn.Close();
            return student;
        }


        public bool Create (Student student)
        {
            _conn.Open();

            string query = @"INSERT INTO Students (firstname, lastname, email, groupId) VALUES (@firstname, @lastname, @email, @gId)";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@firstname", student.Firstname);
            command.Parameters.AddWithValue("@lastname", student.Lastname);
            command.Parameters.AddWithValue("@email", student.Email);
            command.Parameters.AddWithValue("@gId", student.GroupId);
            int rowAffected = command.ExecuteNonQuery();
            _conn.Close();

            if (rowAffected > 0)
            {
                return true;
            }

            return false;
        }


        public bool Update (Student student)
        {
            _conn.Open();

            string query = @"UPDATE Students SET Firstname = @firstname,Lastname = @lastname, Email=@email, GroupId= @gId WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@firstname", student.Firstname);
            command.Parameters.AddWithValue("@lastname", student.Lastname);
            command.Parameters.AddWithValue("@email", student.Email);
            command.Parameters.AddWithValue("@gId", student.GroupId);
            int rowAffected = command.ExecuteNonQuery();
            _conn.Close();

            if (rowAffected > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete (int Id)
        {
            _conn.Open();
            string query = @"DELETE FROM Students WHERE Students.Id=@sId";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@sId", Id);
            int roweffected = command.ExecuteNonQuery();
            _conn.Close();
            if (roweffected > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
