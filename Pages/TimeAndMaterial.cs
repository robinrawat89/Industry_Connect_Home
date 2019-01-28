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

            Browser.webDriver.FindElement(By.XPath("//*[@id='container']//*[text()='Create New']")).Click();
        }

        public void addNewTM()

        {

            //Select Typecode
            Browser.webDriver.FindElement(By.XPath("//*[@class='form-group']//*[text()='select']")).Click();
            Thread.Sleep(1000);
            Browser.webDriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']//*[text()='Time']")).Click();

            //Enter a code
            Browser.webDriver.FindElement(By.Id("Code")).SendKeys("testCode");

            //Enter a description
            Browser.webDriver.FindElement(By.Id("Description")).SendKeys("testDescription");

            //Enter a price
            Browser.webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();
            Browser.webDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("2");

            //Click on Save button
            Browser.webDriver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(1000);

        }

        public void verifyAddTM()
        {

            //Check if Time and Material is created successfully
            Thread.Sleep(1000);
            Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']//*[text()='Go to the last page']")).Click();

            Browser.webDriver.FindElement(By.XPath(""));

            if (Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]")).Text == "testCode")

            {
                Console.WriteLine("Time and Material Created Successully");
            }

            else

            {
                Console.WriteLine("Test Failed");
            }



        }

        public void navigateToLastPage()
        {
            Browser.webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();

        }

        public void editTM()
        {

            if (Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[1]")).Text == "testCode")
            {
                Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[5]/a[1]")).Click();
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
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
        public void verifyEditTM()
        {
            //Last Page 
            Thread.Sleep(500);
            Browser.webDriver.FindElement(By.XPath(".//*[@title='Go to the last page']")).Click();

            //find edit element
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

            if (Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[1]")).Text == "testCode1")
            {
                Browser.webDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[5]/a[2]")).Click();
                Browser.webDriver.SwitchTo().Alert().Accept();
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }        
    }
}
