using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeacherDTO
    {
        public int teacherId { get; set; }
        public string teacherTz { get; set; }
        public string teacherFirstName { get; set; }
        public string teacherLastName { get; set; }
        public string teacherPel { get; set; }
        public string teacherEmail { get; set; }
        public string teacherPassword { get; set; }
        public TeacherDTO()
        {

        }

        public TeacherDTO(int teacherId, string teacherTz, string teacherFirstName, string teacherLastName, string teacherPel, string teacherEmail, string teacherPassword)
        {
            this.teacherId = teacherId;
            this.teacherTz = teacherTz;
            this.teacherFirstName = teacherFirstName;
            this.teacherLastName = teacherLastName;
            this.teacherPel = teacherPel;
            this.teacherEmail = teacherEmail;
            this.teacherPassword = teacherPassword;
        }
    }
}
