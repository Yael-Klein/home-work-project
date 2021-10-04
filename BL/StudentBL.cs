using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StudentBL
    {

        public List<StudentDTO> GetStudents()
        {
            StudentDAL sDaL = new StudentDAL();
            List<StudentDTO> listDTO = new List<StudentDTO>();
            foreach (var item in sDaL.GetStudents().ToList())
            {
                StudentDTO student = new StudentDTO();
                student.studentId = item.studentId;
                student.studentTz = item.studentTz;
                student.studentFirstName = item.studentFirstName;
                student.studentLastName = item.studentLastName;
                student.studentAddress = item.studentAddress;
                student.studentCity = item.studentCity;
                student.studentPel = item.studentPel;
                student.studentParentPel = item.studentParentPel;
                student.studentParentName = item.studentParentName;
                student.studentParentEmail = item.studentParentEmail;

                listDTO.Add(student);
            }
            return listDTO;
        }



        public StudentDTO GetStudentDTO(string Tz)
        {
            StudentDAL student = new StudentDAL();
            Student s = student.GetStudent(Tz);
            StudentDTO studentDTO = new StudentDTO();
            if (s != null)
            {
                studentDTO.studentId = s.studentId;
                studentDTO.studentTz = s.studentTz;
                studentDTO.studentFirstName = s.studentFirstName;
                studentDTO.studentLastName = s.studentLastName;
                studentDTO.studentPel = s.studentPel;
                studentDTO.studentCity = s.studentCity;
                studentDTO.studentAddress = s.studentAddress;
                studentDTO.studentParentName = s.studentParentName;
                studentDTO.studentParentPel = s.studentParentPel;
                studentDTO.studentParentEmail = s.studentParentEmail;
                return studentDTO;
            }
            else
                return null;
        }
            
            
        public int AddStudentBL(StudentDTO sd)
        {
            Student s = new Student();
           // s.studentId = sd.studentId;
            s.studentFirstName = sd.studentFirstName;
            s.studentLastName = sd.studentLastName;
            s.studentAddress = sd.studentAddress;
            s.studentCity = sd.studentCity;
            s.studentParentEmail = sd.studentParentEmail;
            s.studentParentName = sd.studentParentName;
            s.studentParentPel = sd.studentParentPel;
            s.studentPel = sd.studentPel;
            s.studentTz = sd.studentTz;
            StudentDAL student = new StudentDAL();
           int result= student.AddStudentDAL(s);
            return result;
        }

        public List<HwForStudentForToday> HwForStudentForToday(int id)
        {
            StudentDAL s = new StudentDAL();
            return s.GetHwForToday(id);
        }
    }
}
