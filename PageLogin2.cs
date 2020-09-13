using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.SDK.PageObjects;

namespace Ofakim360Final_1.Pages
{
    class PageLogin2

    {
        private IWebDriver driver;

        public PageLogin2 (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);

        }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        public void makeloginaction(string emailtxt, string passtxt , string url)
        {
            driver.Navigate().GoToUrl(url);
            email.SendKeys(emailtxt);
            password.SendKeys(passtxt);

        }

    }


}
