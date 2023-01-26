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
    /// Interaction logic for PageLovedFood.xaml
    /// </summary>
    public partial class PageLovedFood : Page
    {
        public PageLovedFood()
        {
            InitializeComponent();
        }

        private void BtnClick11(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLovedFood.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void BtnClick8(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLovedFood.Navigate(new Uri("MyCart.xaml", UriKind.Relative));
        }

        private void BtnClick12(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLovedFood.Navigate(new Uri("DeskripsiPageFood.xaml", UriKind.Relative));
        }

        private void BtnClickDrink(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLovedFood.Navigate(new Uri("PageLoved.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLovedFood.Navigate(new Uri("DeskripsiPageFood.xaml", UriKind.Relative));
        }

        private void BtnCart(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLovedFood.Navigate(new Uri("MyCart.xaml", UriKind.Relative));
        }
    }
}
