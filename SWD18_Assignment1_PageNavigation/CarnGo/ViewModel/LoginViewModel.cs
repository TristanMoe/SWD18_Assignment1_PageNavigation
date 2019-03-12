using CarnGo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;

namespace CarnGo.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        #region Constructors
        public LoginViewModel()
        {
            UserProfiles = new List<UserProfileModel>
            {
                new UserProfileModel("Mathias Hansen", "1234"),
                new UserProfileModel("Tristan Møller", "1234"),
                new UserProfileModel("Edward Brunton", "1234"),
                new UserProfileModel("Marcus Gasberg", "1234"),
                new UserProfileModel("Martin Gildberg", "1234")
            };        
        }    
        #endregion

        #region Properties
        private List<UserProfileModel> _userProfiles; 
        public List<UserProfileModel> UserProfiles
        {
            get { return _userProfiles; }
            set
            {
                _userProfiles = value;
                NotifyPropertyChanged(); 
            }
        }
        #endregion

        #region Commands
        public DelegateCommand<string> LoginCommand;
        #endregion

        #region CanExecute & Execute
        private void LoginExecute()
        {
            //Set CurrentPage to StartPage
        }
        #endregion

    }
}
