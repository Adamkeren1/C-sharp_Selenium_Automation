using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProject.SDK.PageObjects;

namespace Ofakim360Final_1
{
    class PageRegistration1 : Program
    {
        public PageRegistration1()
        {
            PageFactory.InitElements(Program.driver, this);
        }

        WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(15));

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email;

        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement Mobile;

        [FindsBy(How = How.CssSelector, Using = ".wrapperWelcome")]
        private IWebElement LeadType;

        [FindsBy(How = How.CssSelector, Using = "nextBtn")]
        private IWebElement Next;


        public void NavigateThrowPage(String url, String email, String mobile, String type)
        {
           
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Email));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Mobile));
            Email.SendKeys(email);
            Mobile.SendKeys(mobile);
            LeadType.SendKeys("Private company");
            Next.Click();

            Thread.Sleep(4000);
        }

    }
}
