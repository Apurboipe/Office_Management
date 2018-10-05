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
    class officeGateway : DBConnection
    {
        private string queray;
        private SqlCommand command;
        public List<int> GetAllRollNumberForTeacher(string session,string username)
        {
            try
            {
                List<int> rollList = new List<int>();
                connection.Open();
                queray = "Select studentRoll From teacher_tbl where session=('" + session + "') AND teacherUsername=('" + username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    int roll = 0;
                    roll = Convert.ToInt32(reader[0]);
                    rollList.Add(roll);
                }
                connection.Close();
                return rollList;
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
        public List<int> GetAllRollNumberForChairman(string session, string username)
        {
            try
            {
                List<int> rollList = new List<int>();
                connection.Open();
                queray = "Select studentRoll From chairmanView_tbl where session=('" + session + "') AND chairmanUsername=('" + username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    int roll = 0;
                    roll = Convert.ToInt32(reader[0]);
                    rollList.Add(roll);
                }
                connection.Close();
                return rollList;
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
        public List<int> GetAllRollNumberForAdministration(string session, string username)
        {
            try
            {
                List<int> rollList = new List<int>();
                connection.Open();
                queray = "Select studentRoll From administrationView_tbl where session=('" + session + "') AND administrationUsername=('" + username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    int roll = 0;
                    roll = Convert.ToInt32(reader[0]);
                    rollList.Add(roll);
                }
                connection.Close();
                return rollList;
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
        public string GetTeacherUsername(string username)
        {
            try
            {
                string ausername = "";
                connection.Open();
                queray = "Select username From teacherInfo_tbl where username=('" + username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    ausername = reader[0].ToString();
                }
                connection.Close();
                return ausername;
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
        public string SaveTeacherInfo(Teacher teacher)
        {
            try
            {
                connection.Open();
                string message;
                queray = "Insert into teacherInfo_tbl Values('" + teacher.Name + "','" + teacher.Username + "','" + teacher.Designation + "','" +
                         teacher.Note + "','" + teacher.Dept + "','" + teacher.Gender + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                if (effectiveRow != 0)
                {
                    message = "Teacher Insert Successful.";
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
        public Teacher GetTeacherInfo(string username)
        {
            try
            {
                Teacher teacher = new Teacher();
                connection.Open();
                queray = "Select * From teacherInfo_tbl where username=('" + username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    teacher.Name = reader[0].ToString();
                    teacher.Username = reader[1].ToString();
                    teacher.Designation = reader[2].ToString();
                    teacher.Note = reader[3].ToString();
                    teacher.Dept = reader[4].ToString();
                    teacher.Gender = reader[5].ToString();
                }
                connection.Close();
                return teacher;
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
        public string GetChairmanUsername(string username)
        {
            try
            {
                string ausername = "";
                connection.Open();
                queray = "Select username From chairmanInfo_tbl where username=('" + username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    ausername = reader[0].ToString();
                }
                connection.Close();
                return ausername;
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
        public string SaveChairmanInfo(Chairman chairman)
        {
            try
            {
                connection.Open();
                string message;
                queray = "Insert into chairmanInfo_tbl Values('" + chairman.Name + "','" + chairman.Username + "','" +
                         chairman.Dept + "','" + chairman.Gender + "','" + chairman.Note + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                if (effectiveRow != 0)
                {
                    message = "Chairman Insert Successful.";
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
        public Chairman GetChairmanInfo(string username)
        {
            try
            {
                Chairman chairman = new Chairman();
                connection.Open();
                queray = "Select * From chairmanInfo_tbl where username=('" + username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    chairman.Name = reader[0].ToString();
                    chairman.Username = reader[1].ToString();
                    chairman.Dept = reader[2].ToString();
                    chairman.Gender = reader[3].ToString();
                    chairman.Note = reader[4].ToString();
                }
                connection.Close();
                return chairman;
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
        public List<string> GetTeacherNameList()
        {
            try
            {
                List<string> chairmanNameList=new List<string>();
                
                connection.Open();
                queray = "Select name From teacherInfo_tbl";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    string name = "";
                    name = reader[0].ToString();
                    chairmanNameList.Add(name);
                }
                connection.Close();
                return chairmanNameList;
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
        public List<string> GetChairmanNameList()
        {
            try
            {
                List<string> chairmanNameList = new List<string>();

                connection.Open();
                queray = "Select name From chairmanInfo_tbl";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    string name = "";
                    name = reader[0].ToString();
                    chairmanNameList.Add(name);
                }
                connection.Close();
                return chairmanNameList;
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
        public List<string> GetAdministrationList()
        {
            try
            {
                List<string> administrationList = new List<string>();

                connection.Open();
                queray = "Select name From administrationInfo_tbl";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    string name = "";
                    name = reader[0].ToString();
                    administrationList.Add(name);
                }
                connection.Close();
                return administrationList;
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
        public List<string> GetStudentSessionList()
        {
            try
            {
                List<string> studentSessionList = new List<string>();
                connection.Open();
                queray = "Select DISTINCT session From assignStudentInfo_tbl";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    string session = "";
                    session = reader[0].ToString();
                    studentSessionList.Add(session);
                }
                connection.Close();
                return studentSessionList;
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
        public List<int> GetStudentRollNumberToOffice(string session)
        {
            try
            {
                List<int> rollList=new List<int>();
                connection.Open();
                queray = "Select roll From assignStudentInfo_tbl where session=('" + session + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    int roll = 0;
                    roll = Convert.ToInt32(reader[0]);
                    rollList.Add(roll);
                }
                connection.Close();
                return rollList;
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
        public string SetStudentToTeacher(Assign assign)
        {
            try
            {
                connection.Open();
                string message;
                queray = "Insert into teacher_tbl Values('" + assign.Name + "','" + assign.Roll + "','" +
                         assign.Session + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                if (effectiveRow != 0)
                {
                    message = "Student Assign Successful.";
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
        public string GetTeacherUserNameFromName(string name)
        {
            try
            {
                string ausername = "";
                connection.Open();
                queray = "Select username From teacherInfo_tbl where name=('" + name + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    ausername = reader[0].ToString();
                }
                connection.Close();
                return ausername;
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
        public int GetStudentRollNumberForTeacherOffice(string name)
        {
            try
            {
                int aroll = 0;
                connection.Open();
                queray = "Select studentRoll From teacher_tbl where teacherUsername=('" + name + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    aroll = Convert.ToInt32(reader[0]);
                }
                connection.Close();
                return aroll;
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
        public string SetStudentToChairman(Assign assign)
        {
            try
            {
                connection.Open();
                string message;
                queray = "Insert into chairmanView_tbl Values('" + assign.Name + "','" + assign.Roll + "','" +
                         assign.Session + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                if (effectiveRow != 0)
                {
                    message = "Student Assign Successful.";
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
        public string SetStudentToAdministration(Assign assign)
        {
            try
            {
                connection.Open();
                string message;
                queray = "Insert into administrationView_tbl Values('" + assign.Name + "','" + assign.Roll + "','" +
                         assign.Session + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                if (effectiveRow != 0)
                {
                    message = "Student Assign Successful.";
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
        public string GetChairmanUserNameFromName(string name)
        {
            try
            {
                string ausername = "";
                connection.Open();
                queray = "Select username From chairmanInfo_tbl where name=('" + name + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    ausername = reader[0].ToString();
                }
                connection.Close();
                return ausername;
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
        public string GetAdministrationUserNameFromName(string name)
        {
            try
            {
                string ausername = "";
                connection.Open();
                queray = "Select username From administrationInfo_tbl where name=('" + name + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    ausername = reader[0].ToString();
                }
                connection.Close();
                return ausername;
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
        public int GetStudentRollNumberForChairmanOffice(string name)
        {
            try
            {
                int aroll = 0;
                connection.Open();
                queray = "Select studentRoll From chairmanView_tbl where chairmanUsername=('" + name + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    aroll = Convert.ToInt32(reader[0]);
                }
                connection.Close();
                return aroll;
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
        public int GetStudentRollNumberForAdministrationOffice(string name)
        {
            try
            {
                int aroll = 0;
                connection.Open();
                queray = "Select studentRoll From administrationView_tbl where administrationUsername=('" + name + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    aroll = Convert.ToInt32(reader[0]);
                }
                connection.Close();
                return aroll;
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
        public string GetAdministrationUsername(string username)
        {
            try
            {
                string ausername = "";
                connection.Open();
                queray = "Select username From administrationInfo_tbl where username=('" + username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    ausername = reader[0].ToString();
                }
                connection.Close();
                return ausername;
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
        public string SaveAdministrationInfo(Administration administration)
        {
            try
            {
                connection.Open();
                string message;
                queray = "Insert into administrationInfo_tbl Values('" + administration.Name + "','" + administration.Username + "','" +
                         administration.Type + "','" + administration.Gender + "','" + administration.Note + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                if (effectiveRow != 0)
                {
                    message = "Administration Insert Successful.";
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
        public Administration GetAdministrationInfo(string username)
        {
            try
            {
                Administration administration = new Administration();
                connection.Open();
                queray = "Select * From administrationInfo_tbl where username=('" + username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    administration.Name = reader[0].ToString();
                    administration.Username = reader[1].ToString();
                    administration.Type = reader[2].ToString();
                    administration.Gender = reader[3].ToString();
                    administration.Note = reader[4].ToString();
                }
                connection.Close();
                return administration;
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
