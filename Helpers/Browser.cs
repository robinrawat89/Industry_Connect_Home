﻿//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.IE;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Configuration;

//namespace Industry_Connect_Home.Helpers
//{
//    class Browser
//    {
//        private static IWebDriver webDriver { get; set; }
//        public static string baseURL = ConfigurationManager.AppSettings["url"];
//        public static string browser = ConfigurationManager.AppSettings["browser"];



        
//        public static void Init()
//    {
//         switch (browser)
//         {
//             case "Chrome":
//                 webDriver = new ChromeDriver();
//              break;
//             case "IE":
//                 webDriver = new InternetExplorerDriver();
//             break;
//             case "Firefox":
//                 webDriver = new FirefoxDriver();
//             break;
//         }
//         webDriver.Manage().Window.Maximize();
//         Goto(baseURL);
//    }
//        public static void Goto(string url)
//        {
//            webDriver.Url = url;
//        }
//        public static void Close()
//        {
//            webDriver.Quit();
//        }
//    }
//}
