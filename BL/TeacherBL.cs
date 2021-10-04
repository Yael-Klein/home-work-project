using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class TeacherBL
    {
        public List<TeacherDTO> GetTeachers()
        {
            TeacherDAL tDaL = new TeacherDAL();

            List<TeacherDTO> listDTO = new List<TeacherDTO>();

            foreach (var item in tDaL.GetTeachers().ToList())
            {
                TeacherDTO td = new TeacherDTO();
                td.teacherId = item.teacherId;
                td.teacherTz = item.teacherTz;
                td.teacherFirstName = item.teacherFirstName;
                td.teacherLastName = item.teacherLastName;
                td.teacherPel = item.teacherPel;
                td.teacherEmail = item.teacherEmail;
                td.teacherPassword = item.teacherPassword;
                listDTO.Add(td);
            }
            return listDTO;
        }

        public int AddTeacher(TeacherDTO teacherDTO)
        {
            Teacher teacher = new Teacher();
            teacher.teacherId = 13;
            teacher.teacherTz = teacherDTO.teacherTz;
            teacher.teacherFirstName = teacherDTO.teacherFirstName;
            teacher.teacherLastName = teacherDTO.teacherLastName;
            teacher.teacherPel = teacherDTO.teacherPel;
            teacher.teacherEmail = teacherDTO.teacherEmail;
            teacher.teacherPassword = teacherDTO.teacherPassword;
            TeacherDAL t = new TeacherDAL();
            int result = t.AddTeacher(teacher);
            return result;
        }

        //UserDAL userDAL = new UserDAL();
        public TeacherDTO GetTeacherDTO(string Name, string password)
        {
            TeacherDAL td = new TeacherDAL();
            Teacher t = td.GetTeacher(Name, password);
            TeacherDTO teacherDTO = new TeacherDTO();
            if (t != null)
            {
                teacherDTO.teacherId = t.teacherId;
                teacherDTO.teacherTz = t.teacherTz;
                teacherDTO.teacherFirstName = t.teacherFirstName;
                teacherDTO.teacherLastName = t.teacherLastName;
                teacherDTO.teacherPel = t.teacherPel;
                teacherDTO.teacherEmail = t.teacherEmail;
                teacherDTO.teacherPassword = t.teacherPassword;
                return teacherDTO;
            }
            else
                return null; 
                    //throw new Exception("teacher not exist");
        }

        public void PutTeacherDTO(string Name, string password)
        {
            TeacherDAL td = new TeacherDAL();
            Teacher t = td.GetTeacher(Name, password);
            if (t != null)
            {
                Console.WriteLine("the teachet exist");
            }
            throw new Exception("teacher not exist");
        }

        public List<StatusesStudentHomeWork> StatusPupilBL(string proffesion)
        {
            TeacherDAL t = new TeacherDAL();
            return t.StatusPupil(proffesion);
        }
        public List<StatusStudentByClass> StatusByClassBL(string studyGroupClass)
        {
            TeacherDAL t = new TeacherDAL();
            return t.StatusByClass(studyGroupClass);
        }

        public void AddHWBL(HwToStydyClassOnDateDTO hwDTO)
        {
            HwToStydyClassOnDate h = new HwToStydyClassOnDate();
            h.deadline = hwDTO.deadline;
            h.durationOfPreparation = hwDTO.durationOfPreparation;
            h.hwDescription = hwDTO.hwDescription;
            h.hwToStydyClassOnDate_Date = hwDTO.hwToStydyClassOnDate_Date;
            h.studyClassId = hwDTO.studyClassId;
            h.verificationQuestion = hwDTO.verificationQuestion;
            h.verificationAnswer = hwDTO.verificationAnswer;
            TeacherDAL t = new TeacherDAL();
            t.AddHW(h);
        }


         
    }
}
