# ConsoleApplication_FiguredWebAutomation_POC_CSharp

This is a C# Console Application project, which builds a simple web automaiton framework.


### Installing and Running the project.
```
Download the project, unzip the folder.
Run without complie: Go to bin/debug folder, and click the ConsoleApplication_FiguredWebAutomation.exe file.
A ShedTrackerEditTest will start.
```
## Screenshots:
```
            LoginPage loginPage = new LoginPage(this.driver);
            loginPage.InputEmail(email);
```         
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/1.JPG"/>
</p>
```
            loginPage.InputPassword(password);
```    
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/2.JPG"/>
</p>
```
            loginPage.clickLoginButton();
```   
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/3.JPG"/>
</p>
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/4.JPG"/>
</p>
```
            Homepage Homepage = new Homepage(this.driver);
            Homepage.clickDemoFarmName();
```
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/5.JPG"/>
</p>
```
            DemoFarmDashboardPage DemoFarmDashboardPage = new DemoFarmDashboardPage(this.driver);
            DemoFarmDashboardPage.clickTrackers();
```
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/6.JPG"/>
</p>

```
            DemoFarmTrackersPage DemoFarmTrackersPage = new DemoFarmTrackersPage(this.driver);
            DemoFarmTrackersPage.clickShed();
```
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/7.JPG"/>
</p>
```
            int lineNo = 0;
            string productionActual = DataGenerator.RandomNumber(1000,3000).ToString();
            DemoFarmTrackers_Shed1Page DemoFarmTrackers_Shed1Page = new DemoFarmTrackers_Shed1Page(this.driver);
            DemoFarmTrackers_Shed1Page.editProductionActual(lineNo, productionActual);
            DemoFarmTrackers_Shed1Page.clickSaveChangesButton();
            DemoFarmTrackers_Shed1Page.getProductionActual(lineNo);
```
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/8.JPG"/>
</p>
```
            DemoFarmTrackers_Shed1Page.editProductionActual(lineNo, productionActual);
            DemoFarmTrackers_Shed1Page.clickSaveChangesButton();
```
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/9.JPG"/>
</p>
```
            DemoFarmTrackers_Shed1Page.getProductionActual(lineNo);
```
<p align="left">
  <img src="https://github.com/LolaYan/img/blob/master/10.JPG"/>
</p>
## Built With

* WebDriver - 
* Appium - Optional

## Authors

* **Lola Yan** -- [LolaYan](https://github.com/LolaYan)

