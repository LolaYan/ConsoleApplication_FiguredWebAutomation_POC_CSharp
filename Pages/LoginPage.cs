using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace ConsoleApplication_FiguredWebAutomation.Pages
{
    public class LoginPage : BasePage
    {
        //constructor
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            WaitForPageElement(BySearchLoginButton());
        }
        //elements
        #region ByElements
        private By BySearchEmail()
        {
            return By.Id("email");
        }
        private By BySearchPassword()
        {
            return By.Id("password");
        }
        private By BySearchLoginButton()
        {
            return By.XPath("//*[@value='Login']");
        }
        #endregion

        //functions
        #region methods
        public void InputEmail(string email)
        {

            jsWindowsPopup("Input Email: " + email);
            this.driver.FindElement(BySearchEmail()).Clear();
            this.driver.FindElement(BySearchEmail()).SendKeys(email);
        }

        public void InputPassword(string password)
        {
            jsWindowsPopup("Input Password: " + password);
            this.driver.FindElement(BySearchPassword()).Clear();
            this.driver.FindElement(BySearchPassword()).SendKeys(password);
        }

        public void clickLoginButton()
        {
            jsWindowsPopup("click Login Button");
            this.driver.FindElement(BySearchLoginButton()).Click();
        }

        public void LoginWorkflow(string email, string password)
        {
            LoginPage loginPage = new LoginPage(this.driver);
            loginPage.InputEmail(email);
            loginPage.InputPassword(password);
            Thread.Sleep(3000);
            loginPage.clickLoginButton();
        }
        #endregion

    }
}
