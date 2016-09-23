using ConsoleApplication_FiguredWebAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication_FiguredWebAutomation.Tests
{
    public class LoginTest : BaseTest
    {
        //TestData
        #region TestData
        string email = Properties.Settings.Default.UserEmail;
        string password = Properties.Settings.Default.UserPassword;
        #endregion

        public void LoginWithValidCredentialTest()
        {
            Setup();
            LoginPage loginPage = new LoginPage(this.driver);
            loginPage.InputEmail(email);
            loginPage.InputPassword(password);
            Thread.Sleep(3000);
            loginPage.clickLoginButton();
            Thread.Sleep(2000);
        }
    }
}
