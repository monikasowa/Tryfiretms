using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace TryfiretmsTests
{
    public class LoggingPage
    {
        IWebDriver driver;
        public string mail = "demo@firetms.com";
        public string password = "demo";
        public string baseUrl = "https://speditionpartner.tryfiretms.com/web/login";

        public LoggingPage(IWebDriver driver)
        {
            this.driver = driver;
        }    
        public void GoToPage()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }
        internal void ClearUserName()
        {
            driver.FindElement(By.CssSelector("input[name = 'username']")).Clear();
        }
        internal void WriteUserName()
        {
            driver.FindElement(By.CssSelector("input[name = 'username']")).SendKeys(mail);
        }
        internal void ClearPassword()
        {
            driver.FindElement(By.CssSelector("input[name = 'password']")).Clear(); 
        }
        internal void WritePassword()
        {
            driver.FindElement(By.CssSelector("input[name = 'password']")).SendKeys(password);
        }
        internal void LogIn()
        {
            driver.FindElement(By.CssSelector("input[name='login_submit']")).Click();
        }
    }
}