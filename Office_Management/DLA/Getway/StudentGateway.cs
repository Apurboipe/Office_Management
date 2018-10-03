using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Management.DLA.DAO;

namespace Office_Management.DLA.Getway
{
    class StudentGateway : DBConnection
    {
        private string queray;
        private SqlCommand command;

        public string SaveStudentInfo(Student student)
        {
            try
            {
                connection.Open();
                string message;
                queray = "Insert into student_tbl Values('" + student.Roll + "','" + student.Name + "','" + student.Dept + "','" +
                         student.Session + "','" + student.Sex + "','" + student.Note + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                if (effectiveRow != 0)
                {
                    message = "Student Insert Successful.";
                }
                else
                {
                    message = "Sorry Please Tyr Again.";
                }
                connection.Close();
                return message;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public int GetStudentRollNumber(int rollNumber)
        {
            try
            {
                int roll = 0;
                connection.Open();
                queray = "Select roll From student_tbl where roll=('" + rollNumber + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    roll = Convert.ToInt32(reader[0]);
                }
                connection.Close();
                return roll;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public Student GetStudentInfo(int rollNumber)
        {
            try
            {
                Student student=new Student();
                connection.Open();
                queray = "Select * From student_tbl where roll=('" + rollNumber + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    student.Roll = Convert.ToInt32(reader[0]);
                    student.Name = reader[1].ToString();
                    student.Dept = reader[2].ToString();
                    student.Session = reader[3].ToString();
                    student.Sex = reader[4].ToString();
                    student.Note = reader[5].ToString();
                }
                connection.Close();
                return student;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public List<Student> GetAllStudentInfo(string session)
        {
            try
            {
                List<Student> studentList=new List<Student>();
                connection.Open();
                queray = "Select * From student_tbl where session=('" + session + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    Student student = new Student();
                    student.Roll = Convert.ToInt32(reader[0]);
                    student.Name = reader[1].ToString();
                    student.Dept = reader[2].ToString();
                    student.Session = reader[3].ToString();
                    student.Sex = reader[4].ToString();
                    student.Note = reader[5].ToString();
                    studentList.Add(student);
                }
                connection.Close();
                return studentList;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public string SaveStudentInfoToOffice(Student student)
        {
            try
            {
                connection.Open();
                string message;
                queray = "Insert into assignStudentInfo_tbl Values('" + student.Roll + "','" + student.Name + "','" + student.Dept + "','" +
                         student.Session + "','" + student.Sex + "','" + student.Note + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                if (effectiveRow != 0)
                {
                    message = "Student Send Successful.";
                }
                else
                {
                    message = "Sorry Please Tyr Again.";
                }
                connection.Close();
                return message;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public int GetStudentRollNumberFromOffice(int rollNumber)
        {
            try
            {
                int roll = 0;
                connection.Open();
                queray = "Select roll From assignStudentInfo_tbl where roll=('" + rollNumber + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    roll = Convert.ToInt32(reader[0]);
                }
                connection.Close();
                return roll;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
