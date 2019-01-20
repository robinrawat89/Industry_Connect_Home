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
        private const int V = 5;

        public void addTM(IWebDriver webDriver)

            {
                //Click on Create New button

                webDriver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
                
                //Select Typecode
                webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span")).Click();
                Thread.Sleep(1000);
                webDriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();

                //Enter a code
                webDriver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("testCode");

                //Enter a description
                webDriver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("testDescription");



                //Enter a price
                webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();
                webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("2");



                //Click on Save button
                webDriver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

                

                //Check if Time and Material is created successfully
                Thread.Sleep(1000);
                webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();



                if (webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]")).Text == "testCode")

                {
                    Console.WriteLine("Time and Material Created Successully");
                }

                else

                {
                    Console.WriteLine("Test Failed");
                }



            }

       public void editTM(IWebDriver webDriver)

            {
            webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();

            webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[1]"));
            webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[5]/a[1]")).Click();
            //webDriver.SwitchTo().Alert().Accept();

            //Edit a code
            webDriver.FindElement(By.XPath("//*[@id='Code']")).Clear(); 
            webDriver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("testCode1");

            //Edit a description
            webDriver.FindElement(By.XPath("//*[@id='Description']")).Clear();
            webDriver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("testDescription2");

            //Edit a price
            IWebElement PriceTextbox = webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PriceTextbox.Click();
           // PriceTextbox.Clear();
            IWebElement Price = webDriver.FindElement(By.XPath("//*[@id='Price']"));
            Price.SendKeys("5");
            //Price1.SendKeys(ExcelLibraryHelpers.ReadData(2, "Price1"));

            //Click on Save button
            webDriver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();


            Thread.Sleep(1000);
            webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();



            if (webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]")).Text == "testCode1")

            {
                Console.WriteLine("Time and Material Edit Successully");
            }

            else

            {
                Console.WriteLine("Test Failed");
            }


        }

        public void deleteTM(IWebDriver webDriver)

        {
            webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();

            webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[1]"));
            webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[5]/a[2]")).Click();
            webDriver.SwitchTo().Alert().Accept();

        }        
    }
}
