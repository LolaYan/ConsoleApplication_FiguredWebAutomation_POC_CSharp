using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication_FiguredWebAutomation.Drivers;

namespace ConsoleApplication_FiguredWebAutomation.Tests
{

    public class BaseTest
    {
        public WebDriverHelper wds;
        public IWebDriver driver;

        public BaseTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void Setup()
        {
            string browser = Properties.Settings.Default.Browser.ToUpper();
            string LoginURL = Properties.Settings.Default.LoginURL;

            this.wds = new WebDriverHelper();
            this.driver = wds.InitDriver(browser);

            //Example URL - To be removed/modified based on testing requirement
            this.driver.Navigate().GoToUrl(LoginURL);

        }

        public void Cleanup()
        {
            wds.DestroyDriver();
        }


    }
}
