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
using System.Data.SqlClient;
using System.IO; 

namespace Sowan_Coffee
{
    /// <summary>
    /// Interaction logic for DeskripsiPage.xaml
    /// </summary>
    public partial class DeskripsiPage : Page
    {
        public DeskripsiPage()
        {
            InitializeComponent();
            
        }
        
        SqlConnection db = new SqlConnection(@"Data Source=FARLLS\SQLEXPRESS;Initial Catalog=sowan_coffee_backup;Integrated Security=True");
        
        private void BtnClickAtc(object sender, RoutedEventArgs e)
        {
            db.Open();
            SqlCommand command = new SqlCommand("SELECT nama,harga,Img FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0001'", db);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AddMenu addmenu = new AddMenu
                {
                    Nama = reader["nama"].ToString(),
                    Harga = Convert.ToString(reader["harga"]),
                    Image = (byte[])reader["Img"]
                };
                
            }
            this.NavigationDeskripsiDrink.Navigate(new Uri("MyCart.xaml", UriKind.Relative));
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            this.NavigationDeskripsiDrink.Navigate(new Uri("PageLoved.xaml", UriKind.Relative));
        }
    }
}
