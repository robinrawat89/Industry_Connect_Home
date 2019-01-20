using Industry_Connect_Home.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industry_Connect_Home.Pages
{
    class LoginPage 
    {
        public void loginSteps(IWebDriver webDriver)
        {
            // Enter the URL
            webDriver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Locate username textbox

            IWebElement Username = webDriver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");

            //Locate password textbox
            IWebElement Password = webDriver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //LOcate Login button
            IWebElement Login = webDriver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Login.Click();

            //Verify login
            IWebElement hello_hari = webDriver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (hello_hari.Text == "Hello hari")
            {
                Console.Write("test passed");
            }
            else;
            {
                Console.WriteLine("Test Failed");
            }
        }
    }
}
