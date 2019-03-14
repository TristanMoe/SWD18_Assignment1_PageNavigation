using Prism.Commands;
using System.Windows.Controls;

namespace CarnGo
{
    public class LoginViewModel : BaseViewModel
    {
        private string _email;
        private DelegateCommand<object> _loginCommand;
        #region Constructors
        public LoginViewModel()
        {
            Database = new UserDatabaseStub();
            Email = "";
        }

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

        public string Email
        {
            get => _email;
            private set
            {
                if (_email == value)
                    return;
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
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
            var user = Database.GetUserModel(Email, (obj as PasswordBox)?.Password);
            if (user != null)
            {
                //Set UserModel for ApplicationViewModel
                ViewModelLocator.ApplicationViewModel.CurrentUser = user;
                //Set CurrentPage to StartPage
                ViewModelLocator.ApplicationViewModel.GoToPage(ApplicationPage.DummyPage); 
            }
        }
        #endregion

    }
}
