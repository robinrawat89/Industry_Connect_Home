using Industry_Connect_Home.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industry_Connect_Home.Pages
{
    class HomePage
    {
        public void naviagteToTM()

        {
            //Click on Administration
            Browser.webDriver.FindElement(By.XPath("//*[@class='dropdown']//*[text()='Administration ']")).Click();
            //Click time and material from dropdown
            Browser.webDriver.FindElement(By.XPath("//*[@class='menuitem']//*[text()='Time & Materials']")).Click();
        }
    }
}

