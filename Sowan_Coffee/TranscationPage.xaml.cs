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
    /// Interaction logic for TranscationPage.xaml
    /// </summary>
    public partial class TranscationPage : Page
    {
        public TranscationPage()
        {
            InitializeComponent();
        }

        private void BtnClickHs(object sender, RoutedEventArgs e)
        {
            this.NavigationTransaction.Navigate(new Uri("OrderHitoryPage.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationTransaction.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }
    }
}
