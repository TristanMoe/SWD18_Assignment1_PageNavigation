using CarnGo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnGo.Database
{
    public interface IUserDatabase
    {
        /// <summary>
        /// Interface for database
        /// </summary>
        /// <param name="usernameKey"></param>
        /// <param name="passwordKey"></param>
        /// <returns> UserModel if found in Database else NULL </returns>
        UserModel GetUserModel(string usernameKey, string passwordKey);

    }

    public class UserDatabaseStub
    {
        /// <summary>
        /// Creates a new UserModel with the given parameters 
        /// </summary>
        /// <param name="usernameKey"></param>
        /// <param name="passwordKey"></param>
        /// <returns></returns>
        public UserModel GetUserModel(string usernameKey, string passwordKey)
        {
            var user = new UserModel(usernameKey, passwordKey);
            return user; 
        }
    }





}
