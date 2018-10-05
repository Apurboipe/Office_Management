using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Management.DLA.DAO;
using Office_Management.DLA.Getway;

namespace Office_Management.BLL.Manager
{
    class officeManager
    {
        officeGateway officegateway=new officeGateway();
        StudentGateway studentGateway=new StudentGateway();
        //public List<int> GetAllRollNumberForTeacher(string session)
        //{
        //   return officegateway.GetAllRollNumberForTeacher(session);
        //}

        public List<Student> GetStudentListForTeacher(string session, string username)
        {
            List<Student> studentList=new List<Student>();
            foreach (var roll in officegateway.GetAllRollNumberForTeacher(session, username))
            {
                foreach (var student in studentGateway.GetAllStudentInfo(session))
                {
                    if (roll==student.Roll)
                    {
                        studentList.Add(student);
                    }
                }
            }
            return studentList;
        }
        public List<Student> GetStudentListForChairman(string session, string username)
        {
            List<Student> studentList = new List<Student>();
            foreach (var roll in officegateway.GetAllRollNumberForChairman(session, username))
            {
                foreach (var student in studentGateway.GetAllStudentInfo(session))
                {
                    if (roll == student.Roll)
                    {
                        studentList.Add(student);
                    }
                }
            }
            return studentList;
        }
        public List<Student> GetStudentListForAdministration(string session, string username)
        {
            List<Student> studentList = new List<Student>();
            foreach (var roll in officegateway.GetAllRollNumberForAdministration(session, username))
            {
                foreach (var student in studentGateway.GetAllStudentInfo(session))
                {
                    if (roll == student.Roll)
                    {
                        studentList.Add(student);
                    }
                }
            }
            return studentList;
        }

        public string GetTeacherUsername(string username)
        {
            return officegateway.GetTeacherUsername(username);
        }
        public string SaveTeacherInfo(Teacher teacher)
        {
            string message = null;
            if (teacher.Name != "" && teacher.Dept != "" && teacher.Designation != "" && teacher.Gender != "" && teacher.Note != "")
            {
                message = officegateway.SaveTeacherInfo(teacher);
            }
            else if (teacher.Name == "")
            {
                message = "Please Enter Teacher Name.";
            }
            else if (teacher.Designation == "")
            {
                message = "Please Enter Teacher Designation.";
            }
            else if (teacher.Gender == "")
            {
                message = "Please Select Teacher Gender.";
            }
            else if (teacher.Note == "")
            {
                message = "Please S Enter Teacher Note.";
            }
            return message;
        }

        public Teacher GetTeacherInfo(string username)
        {
            return officegateway.GetTeacherInfo(username);
        }
        public string GetChairmanUsername(string username)
        {
            return officegateway.GetChairmanUsername(username);
        }
        public string SaveChairmanInfo(Chairman chairman)
        {
            string message = null;
            if (chairman.Name != "" && chairman.Dept != "" && chairman.Gender != "" && chairman.Note != "")
            {
                message = officegateway.SaveChairmanInfo(chairman);
            }
            else if (chairman.Name == "")
            {
                message = "Please Enter Chairman Name.";
            }
            else if (chairman.Gender == "")
            {
                message = "Please Select Chairman Gender.";
            }
            else if (chairman.Note == "")
            {
                message = "Please Enter Chairman Note.";
            }
            return message;
        }
        public Chairman GetChairmanInfo(string username)
        {
            return officegateway.GetChairmanInfo(username);
        }
        public List<string> GetTeacherNameList()
        {
            List<string> namelist = new List<string>();
            namelist = officegateway.GetTeacherNameList();
            return namelist;
        }
        public List<string> GetChairmanNameList()
        {
            List<string> namelist = new List<string>();
            namelist = officegateway.GetChairmanNameList();
            return namelist;
        }
        public List<string> GetAdministrationList()
        {
            List<string> namelist = new List<string>();
            namelist = officegateway.GetAdministrationList();
            return namelist;
        }
        public List<string> GetStudentSessionList()
        {
            List<string> sessionList = new List<string>();
            sessionList = officegateway.GetStudentSessionList();
            return sessionList;
        }

        public List<int> GetStudentRollNumberToOffice(string session)
        {
            return officegateway.GetStudentRollNumberToOffice(session);
        }

        public string GetTeacherUserNameFromName(string name)
        {
            return officegateway.GetTeacherUserNameFromName(name);
        }
        public string SetStudentToTeacher(Assign assign)
        {
            string message = null;
            if (assign.Name != "" && assign.Session != "" && assign.Roll != 0)
            {
                if (officegateway.GetStudentRollNumberForTeacherOffice(assign.Name)!=assign.Roll)
                {
                    message = officegateway.SetStudentToTeacher(assign);
                }
                else
                {
                    message = "Student Already Assign To Teacher.";
                }
            }
            else if (assign.Name == "")
            {
                message = "Please Select Name.";
            }
            else if (assign.Session == "")
            {
                message = "Please Select Session.";
            }
            return message;
        }

        public string GetChairmanUserNameFromName(string name)
        {
            return officegateway.GetChairmanUserNameFromName(name);
        }
        public string SetStudentToChairman(Assign assign)
        {
            string message = null;
            if (assign.Name != "" && assign.Session != "" && assign.Roll != 0)
            {
                if (officegateway.GetStudentRollNumberForChairmanOffice(assign.Name) != assign.Roll)
                {
                    message = officegateway.SetStudentToChairman(assign);
                }
                else
                {
                    message = "Student Already Assign To Chairman.";
                }
            }
            else if (assign.Name == "")
            {
                message = "Please Select Name.";
            }
            else if (assign.Session == "")
            {
                message = "Please Select Session.";
            }
            return message;
        }
        public string SetStudentToAdministration(Assign assign)
        {
            string message = null;
            if (assign.Name != "" && assign.Session != "" && assign.Roll != 0)
            {
                if (officegateway.GetStudentRollNumberForAdministrationOffice(assign.Name) != assign.Roll)
                {
                    message = officegateway.SetStudentToAdministration(assign);
                }
                else
                {
                    message = "Student Already Assign To Administration.";
                }
            }
            else if (assign.Name == "")
            {
                message = "Please Select Name.";
            }
            else if (assign.Session == "")
            {
                message = "Please Select Session.";
            }
            return message;
        }
        public string GetAdministrationUserNameFromName(string name)
        {
            return officegateway.GetAdministrationUserNameFromName(name);
        }
        public string GetAdministrationUsername(string username)
        {
            return officegateway.GetAdministrationUsername(username);
        }
        public string SaveAdministrationInfo(Administration administration)
        {
            string message = null;
            if (administration.Name != "" && administration.Type != "" && administration.Gender != "" && administration.Note != "")
            {
                message = officegateway.SaveAdministrationInfo(administration);
            }
            else if (administration.Name == "")
            {
                message = "Please Enter Administration Name.";
            }
            else if (administration.Gender == "")
            {
                message = "Please Select Administration Gender.";
            }
            else if (administration.Note == "")
            {
                message = "Please Enter Administration Note.";
            }
            else if (administration.Type == "")
            {
                message = "Please Select Administration Access Type.";
            }
            return message;
        }
        public Administration GetAdministrationInfo(string username)
        {
            return officegateway.GetAdministrationInfo(username);
        }
    }
}
