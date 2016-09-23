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
    public class DemoFarmTrackers_Shed1Page: BasePage
    {

        //constructor
        public DemoFarmTrackers_Shed1Page(IWebDriver driver)
            : base(driver)
        {
            WaitForPageElement(BySearchProductionActual(0));
        }

        //elements
        #region ByElements
        private By BySearchProductionActual(int no)
        {

            string id = "production_actuals_" + no;
            return By.Id(id);
            //return By.XPath("//*[contains(text(),'Save Changes')]");
        }
        private By BySearchSaveChanges()
        {
            string xpath = "//*[contains(text(),'Save Changes')]";
            return By.XPath(xpath);
        }
        #endregion

        //functions
        #region methods


        public void editProductionActual(int lineNo, string ProductionActual)
        {
            jsWindowsPopup("edit Production Actual in line " + lineNo + " with Value " + ProductionActual);
            this.driver.FindElement(BySearchProductionActual(lineNo)).Clear();
            this.driver.FindElement(BySearchProductionActual(lineNo)).SendKeys(ProductionActual);
        }

        public string getProductionActual(int lineNo)
        {
            string value =  this.driver.FindElement(BySearchProductionActual(lineNo)).GetAttribute("value");
            jsWindowsPopup("Verification: Get Production Actual in line " + lineNo + " with Value " + value);
            return value;
        }

        public void clickSaveChangesButton()
        {
            jsWindowsPopup("click Save Changes Button");
            this.driver.FindElement(BySearchSaveChanges()).Click();
        }
        #endregion
    }
}
