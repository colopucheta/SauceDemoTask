using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTask.Pages
{
    class LoginPage : BasePage
    {
        string url = "https://www.saucedemo.com/";

        public LoginPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl(url);
        }

        //Locators
        By idUsername = By.Id("user-name");
        By idPassword = By.Id("password");
        By idLogin = By.Id("login-button");

        //Methods

        public InventoryPage Login(string username, string password)
        {
            WaitUntilElementExists(idUsername).SendKeys(username);
            WaitUntilElementExists(idPassword).SendKeys(password);

            WaitUntilElementExists(idLogin).Click();

            return new InventoryPage(driver);
        }
    }
}
