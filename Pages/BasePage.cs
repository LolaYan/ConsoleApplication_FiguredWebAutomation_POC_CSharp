using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace ConsoleApplication_FiguredWebAutomation.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;


        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForPageElement(By id)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(id));
            }
            catch (WebDriverTimeoutException)
            {
                //add throw new exception message
            }
        }
        public void SwitchWindow(String windowTitle)
        {
            string mainWindowHandle = driver.CurrentWindowHandle;
            ReadOnlyCollection<string> windows = driver.WindowHandles;
            if (windows.Count > 1)
            {
                foreach (string window in windows)
                {
                    if (window != mainWindowHandle)
                    {
                        if (this.driver.SwitchTo().Window(window).Title.Contains(windowTitle))
                        {
                            break;
                        }
                    }
                }
            }
            this.driver.Manage().Window.Maximize();
        }
        public void jsWindowsPopup( string msg)
        {
            string script = "var el = document.createElement(\"div\"); el.setAttribute(\"style\",\"position:absolute;top:40%;left:20%;background-color:white;\"); el.innerHTML = "+msg+"; setTimeout(function(){  el.parentNode.removeChild(el); },3000); document.body.appendChild(el);";
            IJavaScriptExecutor js = this.driver as IJavaScriptExecutor;
            js.ExecuteScript("alert(\"" + msg + "\")");
            Thread.Sleep(2000);
            this.driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }
    }
}
