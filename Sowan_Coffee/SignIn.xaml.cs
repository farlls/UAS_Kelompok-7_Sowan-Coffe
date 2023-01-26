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
using System.ComponentModel;

namespace Sowan_Coffee
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        public SignIn()
        {
            InitializeComponent();
        }
        //koneksi ke data base
        SqlConnection db = new SqlConnection(@"Data Source=FARLLS\SQLEXPRESS;Initial Catalog=sowan_coffee_backup;Integrated Security=True");
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public bool isValid()
        {
            if (txtemail.Text == string.Empty)
            {
                MessageBox.Show("Email Is Required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;

            }
            if (txtpassword.Password == string.Empty)
            {
                MessageBox.Show("Password Is Required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;

            }
            return true;
        }
        private void BtnSignIn(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid()) {
                    User user = new User();
                    db.Open();
                    string add_data = "SELECT * FROM [dbo].[User] where Email=@Email and Password=@Password";
                    SqlCommand ins = new SqlCommand(add_data, db);
                    ins.Parameters.AddWithValue("@Email", txtemail.Text);
                    ins.Parameters.AddWithValue("@Password", txtpassword.Password);
                    ins.ExecuteNonQuery();
                    int count = Convert.ToInt32(ins.ExecuteScalar());
                    db.Close();
                    txtemail.Text = "";
                    txtpassword.Password = "";
                    user.Email = txtemail.Text;
                    user.Password = txtpassword.Password;
                    if (count > 0)
                    {
                        this.NavigationSignIn.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
                    }
                    else
                    {
                        MessageBox.Show("Email And Password Is Wrong", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }       
            }
            catch
            {
            }
            
        }
        private void BtnSignUp(object sender, RoutedEventArgs e)
        {
            this.NavigationSignIn.Navigate(new Uri("SignUp.xaml", UriKind.Relative));
        }

       
    }
}
