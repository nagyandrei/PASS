using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class StudentDAOSql : StudentDAO
    {
        public List<Student> mStudenti = new List<Student>();
        const string conString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrei\Documents\PASSDB.mdf;Integrated Security=True;Connect Timeout=30";

        public void addStudent(Student student)
        {
            mStudenti.Add(student);
            string query = "INSERT INTO Studenti (NrMatricol,Nume,Medie) VALUES (@NrMatricol,@Nume,@Medie)";

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@NrMatricol", int.Parse(student.mNrMatricol));
            command.Parameters.AddWithValue("@Nume", student.mNume);
            command.Parameters.AddWithValue("@Medie", student.mMedie);
   
            command.ExecuteNonQuery();


        }

        public void deleteStudent(string nrMatricol)
        {
            throw new NotImplementedException();
        }

        public List<Student> getAllStudents()
        {
            return mStudenti;
        }

        public Student getStudent(string nrMatricol)
        {
            return mStudenti.Find(_ => _.mNrMatricol.Equals(nrMatricol));
        }

        public void saveStudents()
        {
            throw new NotImplementedException();
        }

        public void loadStudents()
        {
            string sql = "SELECT * FROM Studenti";
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                mStudenti.Add(new Student(reader.GetValue(0).ToString(), reader.GetString(1), (float)reader.GetDouble(2)));
            }
        }
    }
}
