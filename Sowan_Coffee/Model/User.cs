using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sowan_Coffee
{
    class User
    {
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NoHandphone { get; set; }
        public User() { }
        public User(string Nama, string Password, string Email, string NoHandphone)
        {
            this.Nama = Nama;
            this.Password = Password;
            this.Email = Email;
            this.NoHandphone = NoHandphone;

        }
        
    }
    
}
