using System.Windows.Controls;
using System.Windows.Input;
using Prism.Commands;

namespace CarnGo
{
    public class SendRequestViewModel : BaseViewModel
    {
        private ICommand _logoutCommand;
        public UserModel User { get; set; }

        public SendRequestViewModel()
        {
            User = ViewModelLocator.ApplicationViewModel.CurrentUser;
        }

        #region Commands
        public ICommand LogoutCommand
        {
            get => _logoutCommand ?? new DelegateCommand(LogoutExecute);
            private set => _logoutCommand = value;
        }
        #endregion

        #region CanExecute & Execute
        private void LogoutExecute()
        {
            ViewModelLocator.ApplicationViewModel.GoToPage(ApplicationPage.LoginPage);
            ViewModelLocator.ApplicationViewModel.CurrentUser = null;
        }
        #endregion

    }
}