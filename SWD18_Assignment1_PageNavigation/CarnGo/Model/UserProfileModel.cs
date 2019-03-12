using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnGo.Model
{
    public class UserProfileModel
    {
        #region Constructors
        UserProfileModel()
        {
            UserName = "";
            Password = ""; 
        }

        UserProfileModel(string username, string password)
        {
            UserName = username;
            Password = password; 
        }
        #endregion

        #region DummyProperties
        private string _password; 
        private string _username; 
        public string UserName { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        #endregion
    }
}
