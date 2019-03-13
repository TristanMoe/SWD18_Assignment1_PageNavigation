using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnGo.Model
{
    public class UserModel
    {
        #region Constructors
        public UserModel()
        {
            UserName = "";
            Password = ""; 
        }

        public UserModel(string username, string password)
        {
            UserName = username;
            Password = password; 
        }

        public UserModel(string username, string password, string email, string firstname, string lastname)
        {
            UserName = username;
            Password = password;
            Email = email;
            Firstname = firstname;
            Lastname = lastname;
        }
        #endregion

        #region DummyProperties
        private string _password; 
        private string _username;
        private string _email;
        private string _firstname;
        private string _lastname; 
        public string UserName { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }

        #endregion
    }
}
