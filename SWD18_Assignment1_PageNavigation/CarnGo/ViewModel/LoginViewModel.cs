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
using CarnGo.ViewModelLocator;
using System.Windows.Controls;

namespace CarnGo.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            Database = new UserDatabaseStub(); 
            Email = "";
        }

        private DelegateCommand<object> _loginCommand;
        #region Constructors
        /// <summary>
        /// Dependency Injection
        /// <see cref="IUserDatabase"/>
        /// </summary>
        public LoginViewModel(IUserDatabase database)
        {
            Database = database;
            Email = ""; 
        }    
        #endregion

        #region Properties
        public IUserDatabase Database { get; private set; }
        public string Email { get; private set; }
        #endregion

        #region Commands
        public DelegateCommand<object> LoginCommand
        {
            get => _loginCommand ?? new DelegateCommand<object>(LoginExecute);
            private set => _loginCommand = value;
        }
        #endregion

        #region CanExecute & Execute
        private void LoginExecute(object obj)
        {
            var passwordBox = obj as PasswordBox;
            var user = Database.GetUserModel(Email, passwordBox.Password);
            if (user != null)
            {
                //Set UserModel for ApplicationViewModel
                //Set CurrentPage to StartPage
                ViewModelLocator.ViewModelLocator.ApplicationViewModel.GoToPage(ViewModel.ApplicationPage.DummyPage); 
            }
        }
        #endregion

    }
}
