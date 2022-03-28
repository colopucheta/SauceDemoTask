using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTask.Pages
{
    class InventoryPage : BasePage
    {
        public InventoryPage(IWebDriver driver) : base(driver) {}

        //Locators
        By idHeaderLogo = By.ClassName("app_logo");
        By idTitle = By.ClassName("title");

        //Methods
        public bool IsPageDisplayed()
        {
           if(WaitUntilElementExists(idHeaderLogo).Displayed && WaitUntilElementExists(idTitle).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
