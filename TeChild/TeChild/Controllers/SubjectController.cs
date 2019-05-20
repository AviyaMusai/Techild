using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TeChild.Controllers
{
    [RoutePrefix("api/subject")]
    public class SubjectController : ApiController
    {
        [Route("getAllSubjects")]
        public List<Dto.SubjectDto> GetSubjects()
        {
            return BLL.SubjectLogic.GetAllSubject();
        }
    }
}
