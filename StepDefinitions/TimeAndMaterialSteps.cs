using Industry_Connect_Home.Helpers;
using Industry_Connect_Home.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Industry_Connect_Home.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialSteps
    {
        [Given(@"User can login with valid credentials")]
        public void GivenUserCanLoginWithValidCredentials()
        {
            CommonDriver.webDriver = new ChromeDriver();
            CommonDriver.webDriver.Manage().Window.Maximize();

            LoginPage LoginObject = new LoginPage();
            LoginObject.loginSteps(CommonDriver.webDriver);
        }
        
        [When(@"User click Administration and Time and Material from dropdown")]
        public void WhenUserClickAdministrationAndTimeAndMaterialFromDropdown()
        {
            HomePage HomeObject = new HomePage();
            HomeObject.naviagteToTM(CommonDriver.webDriver);
        }
        
        [Then(@"User should able to add new Time and Material item")]
        public void ThenUserShouldAbleToAddNewTimeAndMaterialItem()
        {
            TimeAndMaterial TimeMaterialObject = new TimeAndMaterial();
            TimeMaterialObject.addTM(CommonDriver.webDriver);
            TimeMaterialObject.deleteTM(CommonDriver.webDriver);
        }
    }
}
