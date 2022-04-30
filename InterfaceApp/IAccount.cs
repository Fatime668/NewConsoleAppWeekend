using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp
{
    interface IAccount
    {
        bool PasswordChecker(string pass);
        void ShowInfo();
    }
}
