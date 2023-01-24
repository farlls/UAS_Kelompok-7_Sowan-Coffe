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

namespace Sowan_Coffee
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {

        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(@"Data Source=FARLLS\SQLEXPRESS;Initial Catalog=sowan_coffee_backup;Integrated Security=True");

        private void BtnClick6(object sender, RoutedEventArgs e)
        {
            this.NavigationSignUp.Navigate(new Uri("SignIn.xaml", UriKind.Relative));
        }
        public void clearData()
        {
            txtnama.Clear();
            txtemail.Clear();
            txtnohp.Clear();
            txtpassword.Clear();
        }
        
        public bool isValid()
        {
            if (txtnama.Text == string.Empty)
            {
                MessageBox.Show("Nama Is Required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
                  
            }
            if (txtnohp.Text == string.Empty)
            {
                MessageBox.Show("No Handphone Is Required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;

            }
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
        private void BtnSignUp(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (isValid()) {
                    User user = new User();
                    
                    db.Open();
                    string add_data = "INSERT INTO [dbo].[User] VALUES(@Nama, @No_hp, @Email, @Password)";
                    SqlCommand ins = new SqlCommand(add_data, db);
                    ins.Parameters.AddWithValue("@Nama", txtnama.Text);
                    ins.Parameters.AddWithValue("@No_hp", txtnohp.Text);
                    ins.Parameters.AddWithValue("@Email", txtemail.Text);
                    ins.Parameters.AddWithValue("@Password", txtpassword.Password);
                    ins.ExecuteNonQuery();
                    db.Close();
                    txtnama.Text = "";
                    txtnohp.Text = "";
                    txtemail.Text = "";
                    txtpassword.Password = "";
                    user.Nama = txtnama.Text;
                    user.NoHandphone = txtnohp.Text;
                    user.Email = txtemail.Text;
                    user.Password = txtpassword.Password;
                    this.NavigationSignUp.Navigate(new Uri("SignIn.xaml", UriKind.Relative));
                    clearData();
                }
                
            } catch
            {
            }
        }
    }
}
