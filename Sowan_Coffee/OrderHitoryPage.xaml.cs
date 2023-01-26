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

namespace Sowan_Coffee
{
    /// <summary>
    /// Interaction logic for OrderHitoryPage.xaml
    /// </summary>
    public partial class OrderHitoryPage : Page
    {
        public OrderHitoryPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigateHistory.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }
    }
}
