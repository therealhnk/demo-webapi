using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        private static List<Models.User> Users = new List<Models.User>
        {
            new Models.User{Id = Guid.NewGuid().ToString(), FirstName = "FirstName User 1" , LastName = "LastName User 1" },
            new Models.User{Id = Guid.NewGuid().ToString(), FirstName = "FirstName User 2" , LastName = "LastName User 2" },
            new Models.User{Id = Guid.NewGuid().ToString(), FirstName = "FirstName User 3" , LastName = "LastName User 3" },
            new Models.User{Id = Guid.NewGuid().ToString(), FirstName = "FirstName User 4" , LastName = "LastName User 4" }
        };

        // GET api/user
        public IEnumerable<Models.User> Get()
        {
            return Users;
        }

        // GET api/user/5
        public Models.User Get(string id)
        {
            return Users.FirstOrDefault(o => o.Id == id);
        }

        // POST api/user
        public void Post(Models.User user)
        {
            user.Id = Guid.NewGuid().ToString();
            Users.Add(user);
        }

        // PUT api/user/5
        public void Put(Models.User user)
        {
            Models.User currentUser = Users.FirstOrDefault(o => o.Id == user.Id);
            currentUser.LastName = user.LastName;
            currentUser.FirstName = user.FirstName;
        }

        // DELETE api/user/5
        public void Delete(string id)
        {
            Users.Remove(Users.FirstOrDefault(o => o.Id == id));
        }
    }
}
