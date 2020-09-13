using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using TestProject.SDK.PageObjects;


namespace Ofakim360Final_1.Pages
{
    class PageDashboard : Program
    {
        
       
        public WebDriverWait wait = new WebDriverWait(Program.driver, TimeSpan.FromSeconds(35));

        public PageDashboard()
        {
            PageFactory.InitElements(Program.driver, this);
        }

        [FindsBy(How = How.Id, Using = "addBeneficiaryModal")]
        public  IWebElement AddBeneficiaryButton;

        [FindsBy(How = How.ClassName, Using = "btn-1 padding-custom deposit-btn-class")]
        public IWebElement DepositButton1;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[1]/app-side-menu/nav/ul/li[2]/a")]
        public IWebElement PayButton;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[1]/app-side-menu/nav/div[2]/div[2]/div/div/button/i")]
        public IWebElement ProfileButton;

        [FindsBy(How = How.XPath, Using = "/html/body/ngb-modal-window/div/div/div/div/div/p[1]")]
        public IWebElement PopupP1;


        [FindsBy(How = How.XPath, Using = "/html/body/ngb-modal-window/div/div/div/div/div/p[7]/a")]
        public IWebElement PopUpGoToHedgeButton;

        [FindsBy(How = How.ClassName, Using = "d-block fade modal show special-modal")]
        public IWebElement EntirePopup;

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'×')]")]
        public IWebElement PopUpCloseButton;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[1]/app-side-menu/nav/div[2]/div[2]/div/div/div/div[1]/div/div[1]/ul/li[4]/a/span[2]")]
        public IWebElement WithdrawalButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Deposit ')]")]
        public IWebElement DasboardDepositButton;

        [FindsBy(How = How.LinkText, Using = "Got it")]
        public IWebElement GotItPopUpButton;

        public void NavigateToWithdrawal()
        {
            try 
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ProfileButton));
                ProfileButton.Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(WithdrawalButton));
                WithdrawalButton.Click();
            }
            catch
            {
                
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//i")));
                IWebElement PB1 = driver.FindElement(By.XPath("//i"));
                PB1.Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("Withdrawal")));
                IWebElement WB1 = driver.FindElement(By.LinkText("Withdrawal"));
                WB1.Click();




                // driver.Navigate().GoToUrl("https://stage.ofakim.ai/payment/withdrawal");
                Thread.Sleep(2000);
            }
        }

        public void NavigetToMassPay()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("Multi Pay")));
            IWebElement MPbutton = driver.FindElement(By.LinkText("Multi Pay"));
            MPbutton.Click();
            Thread.Sleep(5000);
        }

        public void NavigateToDeposit()
        {
            Thread.Sleep(10000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Deposit ')]")));
            IWebElement DasboardDepositButton1= driver.FindElement(By.XPath("//button[contains(.,'Deposit ')]"));
            DasboardDepositButton1.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(.,'Got it')]")));
            IWebElement GotItPopUpButton1 = driver.FindElement(By.XPath("//a[contains(.,'Got it')]"));
            Thread.Sleep(2000);
            GotItPopUpButton1.Click();

        }

        public void dissmisalert()
        {
            try
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(PopUpCloseButton));
                PopUpCloseButton.Click();

            }

            catch {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,'×')]")));
                // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(PopUpCloseButton));
                IWebElement modal = driver.FindElement(By.XPath("//span[contains(.,'×')]"));
                modal.Click();
                Console.WriteLine("this is done!");
            }
        }


        public void NavigateToNewBeneficiary()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AddBeneficiaryButton));
            AddBeneficiaryButton.Click();
            Thread.Sleep(8000);
        }






        public void NavigateToPay()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("Pay")));
            IWebElement Pbutton = driver.FindElement(By.LinkText("Pay"));
            Pbutton.Click(); 
        }


        public void NavigateToBenList()
        {  
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CenterLine));
            driver.Navigate().GoToUrl("https://stage.ofakim.ai/payment/beneficiary-list");
        }

    }
}
