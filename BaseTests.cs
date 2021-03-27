using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace TryfiretmsTests
{
    class BaseTests
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {

            ChromeOptions options = new ChromeOptions();
            options.AcceptInsecureCertificates = true;
            //driver = new ChromeDriver(options);
            driver = new ChromeDriver(@"C:\Tryfiretms Project\Tryfiretms\bin\Debug\netcoreapp3.1",options);
            driver.Manage().Window.Position = new System.Drawing.Point(8, 30);
            driver.Manage().Window.Size = new System.Drawing.Size(1290, 730);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(50);
           
        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}


