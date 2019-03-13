﻿namespace CarnGo
{
    public class ApplicationViewModel : BaseViewModel
    {
        private ApplicationPage _applicationPage = ApplicationPage.LoginPage;
        private UserModel _currentUser = null;

        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage
        {
            get => _applicationPage;
            private set
            {
                if (_applicationPage == value)
                    return;
                _applicationPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        /// <summary>
        /// The current user logged into the application
        /// </summary>
        public UserModel CurrentUser
        {
            get => _currentUser;
            set
            {
                if (_currentUser == value)
                    return;
                _currentUser = value;
                OnPropertyChanged(nameof(CurrentUser));
            }
        }

        /// <summary>
        /// Navigate to the specified page
        /// </summary>
        /// <param name="page">The page to go to</param>
        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;
        }
    }
}

