using Industry_Connect_Home.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Industry_Connect_Home.Pages
{
    class TimeAndMaterial
    {
        public void clickCreateNewButton()

        {
            //Click on Create New button

            Browser.webDriver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
        }

        public void addNewTM()

        {

            //Select Typecode
            Browser.webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span")).Click();
            Thread.Sleep(1000);
            Browser.webDriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();

            //Enter a code
            Browser.webDriver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("testCode");

            //Enter a description
            Browser.webDriver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("testDescription");

            //Enter a price
            Browser.webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();
            Browser.webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("2");

            //Click on Save button
            Browser.webDriver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(1000);

        }
        
        public void verifyAddTM()
        { 

                //Check if Time and Material is created successfully
                Thread.Sleep(1000);
                Browser.webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();
                       
                if (Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]")).Text == "testCode")

                {
                    Console.WriteLine("Time and Material Created Successully");
                }

                else

                {
                    Console.WriteLine("Test Failed");
                }



            }

       public void editTM()

            {
            Browser.webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();

            Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[1]"));
            Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[9]/td[5]/a[1]")).Click();
            //webDriver.SwitchTo().Alert().Accept();

            //Edit a code
            Browser.webDriver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            Browser.webDriver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("testCode1");

            //Edit a description
            Browser.webDriver.FindElement(By.XPath("//*[@id='Description']")).Clear();
            Browser.webDriver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("testDescription2");

            //Edit a price
            //IWebElement PriceTextbox = webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //PriceTextbox.Click();
            //Thread.Sleep(1000);
            //PriceTextbox.Clear();
            //IWebElement Price = webDriver.FindElement(By.XPath("//*[@id='Price']"));
            //Price.Clear();
            //Price.SendKeys("5");
            //Thread.Sleep(2000);
            ////Price1.SendKeys(ExcelLibraryHelpers.ReadData(2, "Price1"));

            Browser.webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            Browser.webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[2]")).Clear();
            Browser.webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("5");


            //Click on Save button
            Browser.webDriver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();



            Browser.webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();

            if (Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]")).Text == "testCode1")

            {
                Console.WriteLine("Time and Material Edit Successully");
            }

            else

            {
                Console.WriteLine("Test Failed");
            }


        }

        public void deleteTM()

        {
            Browser.webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();

            Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[1]"));
            Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[5]/a[2]")).Click();
            Browser.webDriver.SwitchTo().Alert().Accept();

        }        
    }
}
