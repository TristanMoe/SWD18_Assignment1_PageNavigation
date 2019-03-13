using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarnGo.UserControls
{
    /// <summary>
    /// Interaction logic for PageNavigation.xaml
    /// </summary>
    public partial class PageNavigation : UserControl
    {
        public PageNavigation()
        {
            InitializeComponent();
        }

        public Page CurrentPage { get=>(Page)GetValue(CurrentPageProperty); set=>SetValue(CurrentPageProperty,value); }

        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(Page), typeof(PageNavigation), new PropertyMetadata());

        private void OnCurrentPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UpdatePage(e);
        }

        private void UpdatePage(DependencyPropertyChangedEventArgs e)
        {
            CurrentPageFrame.Content = e.NewValue;
        }

    }
}
