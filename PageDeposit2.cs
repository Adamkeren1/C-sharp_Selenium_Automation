using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProject.SDK.PageObjects;

namespace Ofakim360Final_1.Pages
{
    class PageDeposit2 : Program
    {

   

    public PageDeposit2()

         {

            PageFactory.InitElements(Program.driver, this);
          }



        [FindsBy(How = How.Id, Using = "currency")]
        private IWebElement txtCurrency;

        [FindsBy(How = How.Id, Using = "amount")]
        private IWebElement txtAmount;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step1/div/div/div/form/div[2]/div/ngb-datepicker/div[2]/div/ngb-datepicker-month-view/div[2]/div[4]/span")]
        private IWebElement DatePick1;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step1/div/div/div/form/div[3]/button")]
        private IWebElement NextBtn;

        [FindsBy(How = How.Id, Using = "deposit - datepicker - wrapper")]
        private IWebElement datepicker;


        //id="deposit-datepicker"





        public void NavigateThrowDeposit2()
        {
            WebDriverWait wait = new WebDriverWait(Program.driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("currency")));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("currency")));
            //Thread.Sleep(27000);
            IWebElement currency1 = driver.FindElement(By.Id("currency"));
            currency1.Click();
            currency1.SendKeys("ils");
            currency1.SendKeys(Keys.Tab);

            IWebElement amount1 = driver.FindElement(By.Id("amount"));
            amount1.SendKeys("4500");
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            ((IJavaScriptExecutor)driver).ExecuteScript("$('.ngb-dp-today')[0].click();");

            Thread.Sleep(2500);
            IWebElement nexb = driver.FindElement(By.XPath("//button[@type='submit']"));
            nexb.Click();
            Thread.Sleep(5000);
            
        }

    }


}

