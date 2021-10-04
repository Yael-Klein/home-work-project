using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;
using System.Web.Http.Cors;


namespace WebAPI.Controllers
{
   [EnableCors("*", "*", "*")]
    public class TeacherController : ApiController
    {
        TeacherBL teacherBL = new TeacherBL();
        // GET api/values
        [HttpGet]
        public IEnumerable<TeacherDTO> Get()
        {
            return teacherBL.GetTeachers();
        }
        //מורה לפי שם וסיסמא
        public TeacherDTO Get(string name, string password)
        {
             TeacherDTO t= teacherBL.GetTeacherDTO(name, password);
            return t;
        }

        //מחזיר נתוני סטטוס תלמידים לפי תאריך ומקצוע
        public List<StatusesStudentHomeWork> Get(string proffesional)
        {
          return  teacherBL.StatusPupilBL(proffesional);
        }
        //מחזיר נתוני סטטוס תלמידים לפי כיתה
        public List<StatusStudentByClass> GetClass(string StudyGroupClass)
        {
            return teacherBL.StatusByClassBL(StudyGroupClass);
        }

        // POST api/values
        //רישום מורה
        [HttpPost]
        public int Post([FromBody] TeacherDTO teacher)
        {
          return  teacherBL.AddTeacher(teacher);
        }
        public void PostHw([FromBody] HwToStydyClassOnDateDTO h)
        {
            teacherBL.AddHWBL(h);
        }

        // כניסה
        public void Put([FromUri]string name,string password)
        {
            teacherBL.PutTeacherDTO(name, password);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
