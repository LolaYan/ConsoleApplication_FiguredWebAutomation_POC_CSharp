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
    public class DemoFarmDashboardPage: BasePage
    {

        //constructor
        public DemoFarmDashboardPage(IWebDriver driver)
            : base(driver)
        {
            WaitForPageElement(BySearchTrackers());
        }
        //elements
        #region ByElements
        private By BySearchTrackers()
        {
            return By.XPath("//a[.='Trackers']");
        }
 
        #endregion

        //functions
        #region methods


        public void clickTrackers()
        {
            jsWindowsPopup("click Tracker tab!");
            this.driver.FindElement(BySearchTrackers()).Click();
        }

        #endregion
    }
}
