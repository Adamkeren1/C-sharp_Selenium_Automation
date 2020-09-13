using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;
using Ofakim360Final_1.Pages;
using TestProject.SDK.PageObjects;

namespace Ofakim360Final_1
{
    public  class PageLogin {


        public PageLogin()
        {
            
            PageFactory.InitElements(Program.driver, this);
        }


        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailfield;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordfield;

        [FindsBy(How = How.XPath,  Using = "/html/body/app-root/div[1]/div[1]/div/app-login/div/div[1]/div/form/div[4]/div/button")]
        private IWebElement LoginButton;


        


     

        public string ts = "adam";

   

        public void PerformLoginAction(string targeturl, string email, string password, IWebDriver driver)
        {
            //PageDashboard pagedashboard = new PageDashboard(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            driver.Navigate().GoToUrl(targeturl);
            driver.Manage().Window.Maximize();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(emailfield));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(passwordfield));

            emailfield.SendKeys(email);
            passwordfield.SendKeys(password);
            LoginButton.Click();
 

            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //((IJavaScriptExecutor)driver).ExecuteScript("$('.special-modal.close').click();");
           // ((IJavaScriptExecutor)driver).ExecuteScript("$('#special-modal').modal('hide');");

            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(pagedashboard.DepositButton2));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(pagedashboard.AddBeneficiaryButton));
        }
    

    }
}
