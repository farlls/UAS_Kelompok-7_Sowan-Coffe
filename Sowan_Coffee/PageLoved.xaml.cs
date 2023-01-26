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
    /// Interaction logic for PageLoved.xaml
    /// </summary>
    public partial class PageLoved : Page
    {
        public PageLoved()
        {
            InitializeComponent();
            //koneksi ke data base
            SqlConnection db = new SqlConnection(@"Data Source=FARLLS\SQLEXPRESS;Initial Catalog=sowan_coffee_backup;Integrated Security=True");
            using (db)
            {
                db.Open();
                using (SqlCommand command = new SqlCommand("SELECT nama FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0001'", db))
                {

                    string LatteArt = (string)command.ExecuteScalar();
                    latteart.Text = LatteArt;
                }
                using (SqlCommand command = new SqlCommand("SELECT deskripsi FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0001'", db))
                {

                    string Deslatte = (string)command.ExecuteScalar();
                    deslatte.Text = Deslatte;
                }
                using (SqlCommand command = new SqlCommand("SELECT harga FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0001'", db))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal Harga = reader.GetDecimal(0);
                            string Hglatte = Harga.ToString();
                            hglatte.Text = Hglatte;
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand("SELECT Img FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0001'", db))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Img"];
                            BitmapImage image = new BitmapImage();
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                image.BeginInit();
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.StreamSource = ms;
                                image.EndInit();
                            }
                            latteImg.Source = image;
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand("SELECT nama FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0002'", db))
                {

                    string Cappucino = (string)command.ExecuteScalar();
                    cappuncino.Text = Cappucino;
                }
                using (SqlCommand command = new SqlCommand("SELECT deskripsi FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0002'", db))
                {
                    string Descpp = (string)command.ExecuteScalar();
                    descpp.Text = Descpp;
                }
                using (SqlCommand command = new SqlCommand("SELECT harga FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0002'", db))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal Harga = reader.GetDecimal(0);
                            string Hgcpp = Harga.ToString();
                            hgcpp.Text = Hgcpp;
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand("SELECT Img FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0002'", db))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Img"];
                            BitmapImage image = new BitmapImage();
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                image.BeginInit();
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.StreamSource = ms;
                                image.EndInit();
                            }
                            cppImg.Source = image;
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand("SELECT nama FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0003'", db))
                {

                    string Espresso = (string)command.ExecuteScalar();
                    espresso.Text = Espresso;
                }
                using (SqlCommand command = new SqlCommand("SELECT deskripsi FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0003'", db))
                {
                    string Desesp = (string)command.ExecuteScalar();
                    desesp.Text = Desesp;
                }
                using (SqlCommand command = new SqlCommand("SELECT harga FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0003'", db))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal Harga = reader.GetDecimal(0);
                            string Hgesp = Harga.ToString();
                            hgesp.Text = Hgesp;
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand("SELECT Img FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0003'", db))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Img"];
                            BitmapImage image = new BitmapImage();
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                image.BeginInit();
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.StreamSource = ms;
                                image.EndInit();
                            }
                            espImg.Source = image;
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand("SELECT nama FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0001'", db))
                {

                    string Latteart = (string)command.ExecuteScalar();
                    lattart.Text = Latteart;
                }
                using (SqlCommand command = new SqlCommand("SELECT deskripsi FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0001'", db))
                {
                    string Deslatte = (string)command.ExecuteScalar();
                    deslattart.Text = Deslatte;
                }
                using (SqlCommand command = new SqlCommand("SELECT harga FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0001'", db))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal Harga = reader.GetDecimal(0);
                            string Hglatte = Harga.ToString();
                            hglattart.Text = Hglatte;
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand("SELECT Img FROM [dbo].[MenuCoffee] WHERE ID_MenuCoffee = 'D0004'", db))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Img"];
                            BitmapImage image = new BitmapImage();
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                image.BeginInit();
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.StreamSource = ms;
                                image.EndInit();
                            }
                            lattartImg.Source = image;
                        }
                    }
                }
            }
        }
       

        private void BtnClick8(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("MyCart.xaml", UriKind.Relative));
        }

        private void BtnClick10(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void BtnClickDsk(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("DeskripsiPage.xaml", UriKind.Relative));
        }

        private void BtnClickFood(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("PageLovedFood.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("DeskripsiPage.xaml", UriKind.Relative));
        }

        private void BtnCart(object sender, RoutedEventArgs e)
        {
            this.NavigationPageLoved.Navigate(new Uri("MyCart.xaml", UriKind.Relative));
        }
    }
}
