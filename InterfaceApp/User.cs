using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp
{
    class User:IAccount
    {
        private static int _id;
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password {
            get => _password;
                set
                 {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
                 }
        }
        public User(string fullname,string email)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Email = email;
        }

        public bool PasswordChecker(string pass)
        {
            if (pass.Length >= 8)
            {
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;
                foreach (var item in pass)
                {
                    if (char.IsDigit(item))
                    {
                        hasDigit = true;
                    }
                    if (char.IsUpper(item))
                    {
                        hasUpper = true;
                    }
                    if (char.IsLower(item))
                    {
                        hasLower = true;
                    }
                }
                bool result = hasDigit && hasUpper && hasLower;
                return result;
            }
            return false;
            
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} Fullname: {Fullname} Email: {Email}");
        }
    }
}
