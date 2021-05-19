using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeacherDAL
    {
        HomeWorkProjectEntities1 db = new HomeWorkProjectEntities1();
        public List<Teacher> GetTeachers()
        {
            return db.Teacher.ToList();
        }
       
        public int AddTeacher(Teacher teacher)
        {
            try
            {
                db.Teacher.Add(teacher);
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        
    }
}
