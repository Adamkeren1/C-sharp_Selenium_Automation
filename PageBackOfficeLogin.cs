using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestProject.SDK.PageObjects;
using System;
using System.Threading;


namespace Ofakim360Final_1.Pages
{
    class PageBackOfficeLogin : Program
    {
        private IWebDriver driver;

        public PageBackOfficeLogin()
        {
            PageFactory.InitElements(Program.driver, this);
        }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement Email;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/div/div/div[1]/div/form/div[4]/input")]
        private IWebElement LoginButton;

        [FindsBy(How = How.CssSelector, Using = "li:nth-child(8) > .theme-color")]
        private IWebElement HedgeMenuButton;

        [FindsBy(How = How.XPath, Using = ".in:nth-child(3) .sidebar-text")]
        private IWebElement HedgeCatalogButton;


        WebDriverWait wait = new WebDriverWait(Program.driver, TimeSpan.FromSeconds(20));




        public void PerformLoginAction(string targeturl, string email, string password, IWebDriver driver)
        {
            //PageDashboard pagedashboard = new PageDashboard(driver);
            
            driver.Navigate().GoToUrl(targeturl);
            driver.Manage().Window.Maximize();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Email));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Password));
            Email.SendKeys(email);
            Password.SendKeys(password);
            LoginButton.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HedgeMenuButton));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(pagedashboard.DepositButton2));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(pagedashboard.AddBeneficiaryButton));
            System.Console.WriteLine("the back office  login test was successful! :)");
          //  driver.Close();
            Thread.Sleep(2050);
        }

        public void GoToHedgeCatalog()
        {
            HedgeMenuButton.Click();
            Thread.Sleep(1500);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HedgeCatalogButton));
            HedgeCatalogButton.Click();
            Thread.Sleep(3500);
        }


    }
}

