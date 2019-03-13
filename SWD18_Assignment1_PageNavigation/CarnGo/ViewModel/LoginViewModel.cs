using CarnGo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using CarnGo.Database;

namespace CarnGo.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        #region Constructors
        /// <summary>
        /// Dependency Injection
        /// <see cref="IUserDatabase"/>
        /// </summary>
        public LoginViewModel(IUserDatabase database)
        {
            Database = database;
        }    
        #endregion

        #region Properties
        public IUserDatabase Database { get; private set; }
        #endregion

        #region Commands
        public DelegateCommand<string> LoginCommand;
        #endregion

        #region CanExecute & Execute
        private void LoginExecute(string username, string password)
        {
            var user = Database.GetUserModel(username, password);
            if (user != null)
            {
                //Set CurrentPage to StartPage
            }
        }
        #endregion

    }
}
