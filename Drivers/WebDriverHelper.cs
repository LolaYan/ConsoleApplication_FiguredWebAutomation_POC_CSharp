using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace ConsoleApplication_FiguredWebAutomation.Drivers
{
    public class WebDriverHelper
    {
        public IWebDriver driver;
        int timeWaitInSeconds = Int32.Parse(Properties.Settings.Default.timeWaitInSeconds.ToUpper());

        public WebDriverHelper()
        {
        }

        public IWebDriver InitDriver(string browser)
        {
            //open browser
            switch (browser)
            {
                case "CHROME":
                    this.driver = new ChromeDriver();
                    break;
                case "IE":
                    this.driver = new InternetExplorerDriver();
                    break;
                case "FIREFOX":
                    this.driver = new FirefoxDriver();
                    break;
            }

            //Implicitly Wait
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeWaitInSeconds));

            return driver;
        }

        public void DestroyDriver()
        {
            this.driver.Quit();
        }
    }
}
