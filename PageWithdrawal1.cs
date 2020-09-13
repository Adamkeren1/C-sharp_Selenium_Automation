using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProject.SDK.PageObjects;

namespace Ofakim360Final_1.Pages
{
    class PageWithdrawal1
    {

        public IWebDriver driver;


        public PageWithdrawal1(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "currency")]
        private IWebElement txtCurrency;

        [FindsBy(How = How.Id, Using = "amount")]
        private IWebElement txtAmount;

        [FindsBy(How = How.Id, Using = "bankAccount")]
        private IWebElement BankAccountBtn;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-withdrawal/section/div/div[3]/div/app-withdrawal-step1/div/div/div/form/div[2]/div/div[2]/div[1]/div[2]/span")]
        private IWebElement FirstBankAccount;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-withdrawal/section/div/div[3]/div/app-withdrawal-step1/div/div/div/form/div[3]/button")]
        private IWebElement Nextbutton;

        

        public void NavigateThrewPage1()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(18));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(txtCurrency));
            Thread.Sleep(2000);
            txtCurrency.Click();
            txtCurrency.SendKeys("ils");
            txtCurrency.SendKeys(Keys.Tab);
            txtAmount.SendKeys("4500");
            BankAccountBtn.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(FirstBankAccount));
            FirstBankAccount.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Nextbutton));
            Thread.Sleep(2000);
            Nextbutton.Click();
            Thread.Sleep(2000);
        }



    }
}
