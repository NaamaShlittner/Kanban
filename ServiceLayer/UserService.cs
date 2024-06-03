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

        /// <summary>
        /// sign up as a new user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Response
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public Response SignUp(string email, string password)
        {
            throw new NotImplementedException("To Do");
        }

        /// <summary>
        /// sign in to user to exist user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Response
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public Response SignIn(string email, string password)
        {
            throw new NotImplementedException("To Do");
        }
    }
}
