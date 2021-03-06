﻿using Industry_Connect_Home.Helpers;
using Industry_Connect_Home.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Industry_Connect_Home.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialSteps
    {
        //Run Background Steps
        [Given(@"Shopper is using ""(.*)"" browser")]
        public void GivenShopperIsUsingBrowser(string browser)
        {
            Browser.Driverinitialize(browser);
        }

        [When(@"User navigate to ""(.*)"" url")]
        public void WhenUserNavigateToUrl(string websiteUrl)
        {
            Browser.webDriver.Navigate().GoToUrl(websiteUrl);
        }
        
       
        [When(@"User enter valid credentials ""(.*)"" and ""(.*)""")]
        public void WhenUserEnterValidCredentialsAnd(string username, string password)
        {
            LoginPage LoginObject = new LoginPage();
            LoginObject.loginSteps(username, password);
        }


        [Then(@"User is able to Login")]
        public void ThenUserIsAbleToLogin()
        {
            LoginPage LoginObject = new LoginPage();
            LoginObject.verifyLogin();
        }

        // Add New Time and Material item
        [Given(@"User click Administration and Time and Material from dropdown")]
        public void GivenUserClickAdministrationAndTimeAndMaterialFromDropdown()
        {
            HomePage HomeObject = new HomePage();
            HomeObject.naviagteToTM();
        }

        [When(@"User click on Create New button")]
        public void WhenUserClickOnCreateNewButton()
        {
            TimeAndMaterial ObjectTM = new TimeAndMaterial();
            ObjectTM.clickCreateNewButton();
        }


        //[Then(@"User should able to add new Time and Material item")]
        //public void ThenUserShouldAbleToAddNewTimeAndMaterialItem()
        //{
        //    TimeAndMaterial ObjectTM = new TimeAndMaterial();
        //    ObjectTM.addNewTM();
        //}

        [Then(@"User should able to add (.*), (.*), (.*) and (.*)")]
        public void ThenUserShouldAbleToAddAnd(string typeCode, string code, string description, string pricePerunit)
        {           
                TimeAndMaterial ObjectTM = new TimeAndMaterial();
                ObjectTM.addNewTM(typeCode,code,description,pricePerunit);            
           
        }

        [Then(@"Verify new time and material is added")]
        public void ThenVerifyNewTimeAndMaterialIsAdded()
        {
            TimeAndMaterial ObjectTM = new TimeAndMaterial();
            ObjectTM.verifyAddTM();
        }

        // Edit the time and material item
        [When(@"User navigated to end page of the items")]
        public void WhenUserNavigatedToEndPageOfTheItems()
        {
            TimeAndMaterial ObjectTM = new TimeAndMaterial();
            ObjectTM.navigateToLastPage();
        }

        [Then(@"User should able to edit new Time and Material item")]
        public void ThenUserShouldAbleToEditNewTimeAndMaterialItem()
        {
            TimeAndMaterial ObjectTM = new TimeAndMaterial();
            ObjectTM.editTM();
        }

        [Then(@"Verify new time and material is edited")]
        public void ThenVerifyNewTimeAndMaterialIsEdited()
        {
            TimeAndMaterial ObjectTM = new TimeAndMaterial();
            ObjectTM.verifyEditTM();
        }

        //Delete the Timeand material
        [Then(@"User should able to delete edited Time and Material item")]
        public void ThenUserShouldAbleToDeleteEditedTimeAndMaterialItem()
        {
            TimeAndMaterial ObjectTM = new TimeAndMaterial();
            ObjectTM.deleteTM();
        }

        

    }
}
