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
    class PagePay2
    {
        private IWebDriver driver;


        public PagePay2(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "am")]
        private IWebElement Amount;

        [FindsBy(How = How.Id, Using = "balance")]
        private IWebElement CurrencyToCharge;

        [FindsBy(How = How.Id, Using = "ba")]
        private IWebElement CurrencyToChargeAmount;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-payment/section/div/div[3]/div/app-step2/div/div/div/form/div[2]/button[2]")]
        private IWebElement Nextbtn;



        


        //*[@id="ba"]







        public void FillForm( )
        {
            Thread.Sleep(1500);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Amount));
            Amount.SendKeys("4500");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CurrencyToCharge));
            CurrencyToCharge.Click();
            CurrencyToCharge.SendKeys("ils");
            CurrencyToCharge.SendKeys(Keys.Tab);
            Thread.Sleep(4000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Nextbtn));
            Nextbtn.Click();

        }
    }
}



//*[@id="am"]