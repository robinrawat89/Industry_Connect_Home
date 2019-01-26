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
        public void loginSteps(string userName, string passWord)
        {
            
            //Locate username textbox
            IWebElement Username = Browser.webDriver.FindElement(By.Id("UserName"));
            Username.SendKeys(userName);

            //Locate password textbox
            IWebElement Password = Browser.webDriver.FindElement(By.Id("Password"));
            Password.SendKeys(passWord);

            //LOcate Login button
            IWebElement Login = Browser.webDriver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Login.Click();
        }

        public void verifyLogin()
        { 
            //Verify login
            IWebElement hello_hari = Browser.webDriver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
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
