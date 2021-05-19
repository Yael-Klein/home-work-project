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
            teacher.teacherId = teacherDTO.teacherId;
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

        /// <summary>
        /// בודק אם מורה קיימת במאגר לפי הסיסמא שנכנסה
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public int RegisteredTeacher(string password)
        {
            var registered = GetTeachers().Where(t => t.teacherPassword == password).FirstOrDefault().ToString();
            if (registered != null)
            {
                Console.WriteLine("מורה קיימת");
                return 1;
            }
                Console.WriteLine("מורה לא קיימת!");
            return 0;
        }


    }
}
