using ConsoleApplication_FiguredWebAutomation.Pages;
using ConsoleApplication_FiguredWebAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication_FiguredWebAutomation.Tests
{
    public class ShedTrackerTest : BaseTest
    {
        //TestData
        #region TestData
        string email = Properties.Settings.Default.UserEmail;
        string password = Properties.Settings.Default.UserPassword;
        #endregion

        public void ShedTrackerEditTest()
        {
            Setup();
            LoginPage loginPage = new LoginPage(this.driver);
            loginPage.InputEmail(email);
            loginPage.InputPassword(password);
            Thread.Sleep(3000);
            loginPage.clickLoginButton();
            Thread.Sleep(2000);

            Homepage Homepage = new Homepage(this.driver);
            Homepage.clickDemoFarmName();

            DemoFarmDashboardPage DemoFarmDashboardPage = new DemoFarmDashboardPage(this.driver);
            DemoFarmDashboardPage.clickTrackers();

            DemoFarmTrackersPage DemoFarmTrackersPage = new DemoFarmTrackersPage(this.driver);
            DemoFarmTrackersPage.clickShed();
            Thread.Sleep(3000);
            int lineNo = 0;
            string productionActual = DataGenerator.RandomNumber(1000,3000).ToString();
            DemoFarmTrackers_Shed1Page DemoFarmTrackers_Shed1Page = new DemoFarmTrackers_Shed1Page(this.driver);
            DemoFarmTrackers_Shed1Page.editProductionActual(lineNo, productionActual);
            DemoFarmTrackers_Shed1Page.clickSaveChangesButton();
            DemoFarmTrackers_Shed1Page.getProductionActual(lineNo);

            Cleanup();
        }
    }
}
