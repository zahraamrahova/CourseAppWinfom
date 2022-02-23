using CourseApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.DAL
{
    class GroupDTO : Base
    {
        public List<Group> GetAll()
        {
            _conn.Open();

            string q = @"SELECT g.*, c.* FROM Groups as g INNER JOIN Classrooms as c ON g.ClassroomId=c.Id";
            SqlCommand command = new SqlCommand(q, _conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Group> groups = new List<Group>();
            while (reader.Read())
            {
                Classroom c = new Classroom
                {
                    Id = reader.GetInt32(3),
                    Name = reader.GetString(4),
                    Capacity = reader.GetInt32(5)
                };
                Group g = new Group
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    ClassroomId = reader.GetInt32(2),
                    Classroom = c

                };
                groups.Add(g);
            }
            _conn.Close();
            return groups;
        }

        public Group Get(int Id)
        {
            _conn.Open();

            string q = @"SELECT * FROM Groups WHERE Groups.Id = @gid";
            SqlCommand command = new SqlCommand(q, _conn);
            command.Parameters.AddWithValue("@gid", Id);
            SqlDataReader reader = command.ExecuteReader();
            Group group = new Group();
            while (reader.Read())
            {
                group.Id = reader.GetInt32(0);
                group.Name = reader.GetString(1);
                group.ClassroomId = reader.GetInt32(2);

            }
            _conn.Close();
            return group;
        }


        public bool Create (Group group)
        {
            _conn.Open();
            string query = @"INSERT INTO GROUPS (name, classroomId) VALUES (@name, @cId)";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@name", group.Name);
            command.Parameters.AddWithValue("@cId", group.ClassroomId);
            int rowAffected = command.ExecuteNonQuery();
            _conn.Close();

            if (rowAffected > 0)
            {
                return true;
            }

            return false;

        }

        public bool Update (Group group)
        {
            _conn.Open();
            string query = @"UPDATE Groups SET Name = @name, ClassroomId= @cId WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@name", group.Name);
            command.Parameters.AddWithValue("@cId", group.ClassroomId);
            command.Parameters.AddWithValue("@Id", group.Id);
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
            string query = @"DELETE FROM Groups WHERE Groups.Id=@crid";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@crid", Id);
            int roweffected = command.ExecuteNonQuery();
            _conn.Close();
            if (roweffected>0)
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
