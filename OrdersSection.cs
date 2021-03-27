using OpenQA.Selenium;
using System;

namespace TryfiretmsTests
{
    internal class OrdersSection
    {
        IWebDriver driver;
        public string startDate = "01.05.2019";
        public string endDate = "30.05.2019";
        

        public OrdersSection(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void GoToOrders()
        {
            driver.FindElement(By.XPath(".//span[text() = 'Zlecenia']")).Click();
        }

        internal void SelectAllOrders()
        {
            driver.FindElement(By.XPath(".//span[text() = 'Wszystkie zlecenia']")).Click();
        }

        internal void GoToFilter()
        {
            driver.FindElement(By.CssSelector("#gwt-uid-5 div[class='v-filterselect-button']")).Click();
        }

        internal void SelectDateCreate()
        {
            driver.FindElement(By.XPath(".//span[text()='Data utworzenia']")).Click();
        }

        internal void WriteStartDate()
        {
            driver.FindElement(By.CssSelector("div.v-horizontallayout-e-date-time-filter-component div:nth-child(2) div input")).SendKeys(startDate);
        }

        internal void WriteEndDate()
        {
            driver.FindElement(By.CssSelector("div.v-horizontallayout-e-date-time-filter-component div:nth-child(4) div input")).SendKeys(endDate);
        }

        internal void SubmitChange()
        {
            driver.FindElement(By.CssSelector(".v-horizontallayout-e-form-buttons-component>div:nth-child(3)")).Click();
        }
    }
}   