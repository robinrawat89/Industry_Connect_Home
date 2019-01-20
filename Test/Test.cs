using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Industry_Connect_Home.Pages;
using Industry_Connect_Home.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Industry_Connect_Home
{
    [TestFixture]
    public class Test
    {
        
        [SetUp]
        public void Initiate()
        {
            CommonDriver.webDriver = new ChromeDriver();
            CommonDriver.webDriver.Manage().Window.Maximize();

            LoginPage  LoginObject = new LoginPage();
            LoginObject.loginSteps(CommonDriver.webDriver);

            HomePage HomeObject = new HomePage();
            HomeObject.naviagteToTM(CommonDriver.webDriver);
        }
        [Test]
        public void AddTM()
        {
            TimeAndMaterial TimeMaterialObject = new TimeAndMaterial();
            TimeMaterialObject.addTM(CommonDriver.webDriver);
            TimeMaterialObject.deleteTM(CommonDriver.webDriver);
            
        }

        [Test]
        public void DelTM()
        {
            TimeAndMaterial TimeMaterialObject = new TimeAndMaterial();
            TimeMaterialObject.addTM(CommonDriver.webDriver);
            TimeMaterialObject.deleteTM(CommonDriver.webDriver);
        }
        [Test]
        public void EditTM()
        {
            TimeAndMaterial TimeMaterialObject = new TimeAndMaterial();
            TimeMaterialObject.addTM(CommonDriver.webDriver);
            TimeMaterialObject.editTM(CommonDriver.webDriver);
            
        }
        [TearDown]
        public void closeBrowser()
        {
            CommonDriver.webDriver.Close();
        }




    }
}
