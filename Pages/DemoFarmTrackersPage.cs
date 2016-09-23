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
    public class DemoFarmTrackersPage: BasePage
    {

        //constructor
        public DemoFarmTrackersPage(IWebDriver driver)
            : base(driver)
        {
            WaitForPageElement(BySearchShed());
        }

        //elements
        #region ByElements
        private By BySearchShed()
        {
            return By.XPath("//*[contains(text(),'Shed 1')]");
        }
 
        #endregion

        //functions
        #region methods


        public void clickShed()
        {
            jsWindowsPopup("click Track Shed");
            this.driver.FindElement(BySearchShed()).Click();
        }

        #endregion
    }
}
