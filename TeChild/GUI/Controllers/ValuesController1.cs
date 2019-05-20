using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BLL;
using DAL;
using System.Collections.Generic;
using System.Web.Http.Controllers;
using System.Web.Http.Description;

namespace GUI.Controllers
{
    [RoutePrefix("api/val")]
    public class ValuesController1 : ApiController
    {
      //private  TechildDBEntities t = new TechildDBEntities();
        // GET api/<controller>

        [Route("getListSubjects")]
        [ResponseType(typeof(List<DAL.Subjects>))]
        public List<DAL.Subjects> GetListSubjects()
        {
            return t.Subjects.ToList();
            //List<DAL.Subjects> gg = new List<Subjects>();
            //foreach (DAL.Subjects item in gg)
            //{
            //    gg.Add(t.Subjects.FirstOrDefault());
            //}
            //if (gg == null)
            //{
            //    return NotFound();
            //}
            //return Ok(Class2.compareToTest2(gg));
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}