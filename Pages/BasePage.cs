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
    class BasePage
    {
        public IWebDriver driver = null;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Methods
        public IWebElement WaitUntilElementExists(By locator)
        {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                return wait.Until(e => driver.FindElement(locator));
        }
    }
}
