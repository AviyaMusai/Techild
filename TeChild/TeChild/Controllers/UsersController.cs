using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TeChild.Controllers
{
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        [Route("getAllUsers")]
        public List<Dto.UsersDto> GetAllUsers()
        {
            return BLL.UserLogic.GetAllUsers();
        }
        [Route("GetUserByPasAndName")]
        public Dto.UsersDto GetUserByPasAndName(string name, string pass)
        {
            return BLL.UserLogic.GetUserByPasAndName(name,pass);
        }
        [Route("AddNewUser")]
        public void AddNewUser(DAL.Users user)
        {
            BLL.UserLogic.AddNewUser(user);
        }
    }
}
