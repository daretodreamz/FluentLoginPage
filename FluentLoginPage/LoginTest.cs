using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentLoginPage
{    
    public class LoginTest
    {
        public LoginTest()
        {
            Driver.Initialize();
        }

        public void Admin_User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("admin").WithPassword("password").Login();
        }

        public void Admin_User_Can_Logout()
        {
            Pages.LogoutPage.Logout();
        }
    }
}
