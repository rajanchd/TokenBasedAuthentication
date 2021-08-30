﻿using System.Collections.Generic;
using System.Web.Http;
using TokenBasedAuthentication.Models;

namespace TokenBasedAuthentication.Controllers
{
    [Authorize]
    public class DefaultController : ApiController
    {
        // GET: api/Default
        public IEnumerable<string> Get()
        {

            //UserService usr = new UserService();
            //return  usr.GetUserList();
            return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
