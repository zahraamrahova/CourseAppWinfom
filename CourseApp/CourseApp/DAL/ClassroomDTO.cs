using CourseApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.DAL
{
    class ClassroomDTO :Base
    {

        public List<Classroom> GetAll()
        {
            _conn.Open();

            string q = @"SELECT * FROM Classrooms";
            SqlCommand command = new SqlCommand(q, _conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Classroom> classrooms = new List<Classroom>();
            while (reader.Read())
            {
                Classroom c = new Classroom
                {
                    Id = reader.GetInt32(0),
                   Name = reader.GetString(1),
                   Capacity = reader.GetInt32(2)
                };
                classrooms.Add(c);
            }
            _conn.Close();
            return classrooms;
        }

        public Classroom Get(int Id)
        {
            _conn.Open();

            string q = @"SELECT * FROM Classrooms WHERE Classrooms.Id = @crid";
            SqlCommand command = new SqlCommand(q, _conn);
            command.Parameters.AddWithValue("@crid", Id);
            SqlDataReader reader = command.ExecuteReader();
            Classroom classroom= new Classroom();
            while (reader.Read())
            {
                classroom.Id = reader.GetInt32(0);
                classroom.Name = reader.GetString(1);
                classroom.Capacity = reader.GetInt32(2);
            
            }
            _conn.Close();
            return classroom;
        }

        public Classroom GetWithName(string Name)
        {
            _conn.Open();

            string q = @"SELECT * FROM Classrooms WHERE Classrooms.Name = @crname";
            SqlCommand command = new SqlCommand(q, _conn);
            command.Parameters.AddWithValue("@crname", Name);
            SqlDataReader reader = command.ExecuteReader();
            Classroom classroom = new Classroom();
            while (reader.Read())
            {
                classroom.Id = reader.GetInt32(0);
                classroom.Name = reader.GetString(1);
                classroom.Capacity = reader.GetInt32(2);

            }
            _conn.Close();
            return classroom;
        }

        public bool Create (Classroom cr)
        {
            _conn.Open();

            string q = @"INSERT INTO Classrooms (Name, Capacity) VALUES (@name, @capacity)";
            SqlCommand command = new SqlCommand(q, _conn);
            command.Parameters.AddWithValue("@name", cr.Name);
            command.Parameters.AddWithValue("@capacity", cr.Capacity);
            int rowAffected = command.ExecuteNonQuery();
            _conn.Close();

            if (rowAffected>0)
            {
                return true;
            }

            return false;
         
        }

        public bool Update (Classroom cr)
        {
            _conn.Open();

            string q = @"UPDATE Classrooms SET Name = @name, Capacity= @capacity WHERE Id = @Id";
            SqlCommand command = new SqlCommand(q, _conn);
            command.Parameters.AddWithValue("@name", cr.Name);
            command.Parameters.AddWithValue("@capacity", cr.Capacity);
            command.Parameters.AddWithValue("@Id", cr.Id);
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

            string q = @"DELETE FROM Classrooms WHERE Classrooms.Id=@crid";
            SqlCommand command = new SqlCommand(q, _conn);
            command.Parameters.AddWithValue("@crid", Id);
            
            int rowAffected = command.ExecuteNonQuery();
            _conn.Close();

            if (rowAffected > 0)
            {
                return true;
            }

            return false;

        }


    }
}
