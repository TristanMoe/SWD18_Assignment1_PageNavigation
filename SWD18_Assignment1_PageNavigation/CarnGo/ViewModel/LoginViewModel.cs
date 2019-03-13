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
        }    
        #endregion

        #region Properties
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
