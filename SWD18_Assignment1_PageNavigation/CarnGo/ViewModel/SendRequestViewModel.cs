namespace CarnGo
{
    public class SendRequestViewModel : BaseViewModel
    {
        public UserModel User { get; set; }

        public SendRequestViewModel()
        {
            User = ViewModelLocator.ApplicationViewModel.CurrentUser;
        }
    }
}