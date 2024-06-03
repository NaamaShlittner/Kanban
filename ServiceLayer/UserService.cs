using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    internal class UserService
    {
        private UserFacade uf;

        public Response SignUp(string email, string password);

        public Response SignIn(string email, string password);
    }
}
