using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        TeacherBL t = new TeacherBL();
        // GET api/values
        [HttpGet]
        public IEnumerable<TeacherDTO> Get()
        {
            return t.GetTeachers();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
