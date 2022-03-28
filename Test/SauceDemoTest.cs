using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SauceDemoTask.Pages;

namespace SauceDemoTask
{
    [TestClass]
    public class SauceDemoTest
    {
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void LoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            InventoryPage inventoryPage = loginPage.Login("standard_user", "secret_sauce");

            Assert.IsTrue(inventoryPage.IsPageDisplayed());
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
