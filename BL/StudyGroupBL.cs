using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class StudyGroupBL
    {
        public List<string> GetStudyClassForTeacherBL(int teacherId)
        {
            StudyGroupDAL d = new StudyGroupDAL();
            return d.GetStudyClassForTeacher(teacherId);
        }
    }
}
