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
    class PageDeposit1 : Program
    {
        


        public PageDeposit1 ()
        {
            PageFactory.InitElements(Program.driver, this);
        }

        WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(10));

        [FindsBy(How = How.XPath, Using = "//form/div/div/label")]
        private IWebElement GoldTransferBtn;

        [FindsBy(How = How.Id, Using = "bankAccount")]
        private IWebElement BankAccountBtn;
                                            
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step2/div/div/div/form/div[2]/div/div[2]/div[1]/div[1]/span[1]")]
        private IWebElement FirstBankAccountOption;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step2/div/div/div/form/div[3]/button")]
        private IWebElement NextBtn;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step1/div/div/div/form/div[2]/div/ngb-datepicker/div[2]/div/ngb-datepicker-month-view/div[2]/div[4]/span")]
        private IWebElement DatePick1;




        public void NavigateThrowDeposit1()
        {

            
            try
            {
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step2/div/div/div/form/div[1]/div[1]/label/span[1]")));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(GoldTransferBtn));
                GoldTransferBtn.Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BankAccountBtn));
                BankAccountBtn.Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(FirstBankAccountOption));
                FirstBankAccountOption.Click();
                Thread.Sleep(1500);
                NextBtn.Click();
                Thread.Sleep(5000);
            }
            catch
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//form/div/div/label")));
                IWebElement Goldt = driver.FindElement(By.XPath("//form/div/div/label"));
                Goldt.Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("bankAccount")));
                IWebElement Bankacc = driver.FindElement(By.Id("bankAccount"));
                Bankacc.Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step2/div/div/div/form/div[2]/div/div[2]/div[1]/div[1]/span[1]")));
                IWebElement FirstOpt = driver.FindElement(By.XPath("/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step2/div/div/div/form/div[2]/div/div[2]/div[1]/div[1]/span[1]"));
                FirstOpt.Click();
                Thread.Sleep(1500);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step2/div/div/div/form/div[3]/button")));
                IWebElement Nbtn = driver.FindElement(By.XPath("/html/body/app-root/div[1]/div[2]/div[2]/app-deposit/section/div/div[3]/div/app-deposit-step2/div/div/div/form/div[3]/button"));
                Nbtn.Click();
                Thread.Sleep(1500);
            }
        }
        




    }


}