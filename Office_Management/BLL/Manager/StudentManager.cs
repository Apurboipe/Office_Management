using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Management.DLA.DAO;
using Office_Management.DLA.Getway;

namespace Office_Management.BLL.Manager
{
    class StudentManager
    {
        StudentGateway studentGateway =new StudentGateway();
        public string SaveStudentInfo(Student student)
        {
            string message = null;
            if (student.Roll != 0 && student.Name != "" && student.Dept != "" && student.Session != "" && student.Sex != "" && student.Note != "")
            {

                if (studentGateway.GetStudentRollNumber(student.Roll) != student.Roll)
                {
                    message = studentGateway.SaveStudentInfo(student);
                }
                else
                {
                    message = "Student Already Exist.";
                }
            }
            else if (student.Name == "")
            {
                message = "Please Enter Student Name.";
            }
            else if (student.Roll == 0)
            {
                message = "Please Enter Student Roll.";
            }
            else if (student.Session == "")
            {
                message = "Please Select Student Session.";
            }
            else if (student.Sex == "")
            {
                message = "Please Select Student Gender.";
            }
            else if (student.Note == "")
            {
                message = "Please Enter Student Note.";
            }
            return message;
        }

        public int GetStudentRollNumber(int rollNumber)
        {
            return studentGateway.GetStudentRollNumber(rollNumber);
        }

        public Student GetStudentInfo(int rollNumber)
        {
            return studentGateway.GetStudentInfo(rollNumber);
        }

        public string SaveStudentInfoToOffice(Student student)
        {
            string message = "";
            if (studentGateway.GetStudentRollNumberFromOffice(student.Roll)!=student.Roll)
            {
                message = studentGateway.SaveStudentInfoToOffice(student);
            }
            else
            {
                message = "Student Already Send To Office.";
            }
            return message;
        }
    }
}
