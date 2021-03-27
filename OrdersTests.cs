using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TryfiretmsTests
{
    class OrdersTests : BaseTests
    {
        public string expectedNumberRecords = "128";
        [Test]
        public void OrdersFiltredByDateCreateTest()
        { 
            LoggingPage loginPage = new LoggingPage(driver);
            loginPage.GoToPage();
            loginPage.ClearUserName();
            loginPage.WriteUserName();
            loginPage.ClearPassword();
            loginPage.WritePassword();
            loginPage.LogIn();
            OrdersSection ordersSection = new OrdersSection(driver);
            ordersSection.GoToOrders();
            ordersSection.SelectAllOrders();
            ordersSection.GoToFilter();
            ordersSection.SelectDateCreate();
            ordersSection.WriteStartDate();
            ordersSection.WriteEndDate();
            ordersSection.SubmitChange();
            
            Assert.AreEqual(expectedNumberRecords, driver.FindElement(By.CssSelector("div[class='v-horizontallayout v-layout v-horizontal v-widget']>div:nth-child(11)>div[class='v-label v-widget v-label-undef-w h2 v-label-h2']")).Text);
     
        }
    }
}
