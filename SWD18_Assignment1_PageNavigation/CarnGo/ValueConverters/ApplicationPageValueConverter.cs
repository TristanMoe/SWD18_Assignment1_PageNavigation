using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using CarnGo.Model;
using CarnGo.View;

namespace CarnGo.ValueConverters
{
    class ApplicationPageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //TODO: Move this to a PageFactory
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.LoginPage:
                    return new LoginView();
                default:
                    throw new ArgumentException("The value to convert was not an ApplicationPage");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
