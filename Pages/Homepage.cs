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
    public class Homepage : BasePage
    {
        string demoFarmName = "Lola Yan Demo Farm";

        //constructor
        public Homepage(IWebDriver driver)
            : base(driver)
        {
            WaitForPageElement(BySearchDemoFarmName());
        }
        //elements
        #region ByElements
        private By BySearchDemoFarmName()
        {
            return By.XPath("//a[.='" + demoFarmName + "']");
        }
 
        #endregion

        //functions
        #region methods


        public void clickDemoFarmName()
        {
            jsWindowsPopup("click Demo Farm Name");
            this.driver.FindElement(BySearchDemoFarmName()).Click();
        }

        #endregion
    }
}
