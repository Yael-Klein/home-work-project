using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;

namespace WebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class StudyGroupController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        // GET api/<controller>/5
        //שליפת כיתות לפי id של מורה
        public List<string> Get(int password)
        {
            StudyGroupBL b = new StudyGroupBL();
            return b.GetStudyClassForTeacherBL(password);
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}