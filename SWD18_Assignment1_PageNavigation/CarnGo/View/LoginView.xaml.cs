using System.Windows.Controls;

namespace CarnGo
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Page
    {
        public LoginView()
        {
            DataContext = new LoginViewModel(); 
            InitializeComponent();
        }
    }
}
