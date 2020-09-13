using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.SDK.PageObjects;

namespace Ofakim360Final_1.Pages
{
    class PageWithdrawal2
    {
        public IWebDriver driver;


        public PageWithdrawal2(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-withdrawal/section/div/div[3]/div/app-withdrawal-step2/div/div/div/form/div/button[2]")]
        private IWebElement NxtButton;


        public void NavigateThrewPage2()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(45));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(NxtButton));
            NxtButton.Click();
        }
        }
}









