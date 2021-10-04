using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class StudentController : ApiController
    {
        StudentBL studentBL = new StudentBL();
        [HttpGet]
        // GET api/<controller>
        public IEnumerable<StudentDTO> Get()
        {
            return studentBL.GetStudents();
        }
       
        // GET api/<controller>/5
        public StudentDTO Get(string password)
        {
            return studentBL.GetStudentDTO(password);
        }
        public List<HwForStudentForToday> GetHw(int id)
        {
            return studentBL.HwForStudentForToday(id);
        }

        [HttpPost]
        // POST api/<controller>
        //הוספת תלמידה
        public void Post([FromBody] StudentDTO student)
        {
            studentBL.AddStudentBL(student);
        }
        
        [HttpPut]
        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }
        [HttpDelete]
        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}