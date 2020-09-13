using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;
using Ofakim360Final_1.Pages;
using TestProject.SDK.PageObjects;

namespace Ofakim360Final_1.Pages
{
    class NewBen1 : Program
    {
        static DateTime dateValue = DateTime.Now;
        public  string  dd1 = dateValue.ToString("dddd/mm/yyyy hh/mm/ss");

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));


        public NewBen1()
        {

            PageFactory.InitElements(Program.driver, this);
        }

        [FindsBy(How = How.Id, Using = "bankAccountHolderName")]
        public IWebElement bankAccountHolderName;

        [FindsBy(How = How.Id, Using = "benType")]
        public IWebElement benType;

        [FindsBy(How = How.Id, Using = "currency")]
        public IWebElement currency;

        [FindsBy(How = How.Id, Using = "beneficiaryCountry")]
        public IWebElement beneficiaryCountry;

        [FindsBy(How = How.ClassName, Using = "btn-1")]
        public IWebElement nextbtn;








        public void GoThrewPage() 
        {
            
           
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(bankAccountHolderName));
            bankAccountHolderName.SendKeys("Autotest -- " + dd1);

            benType.Click();
            benType.SendKeys(Keys.ArrowDown);
            benType.SendKeys(Keys.Enter);

            currency.Click();
            currency.SendKeys(Keys.ArrowDown);
            currency.SendKeys(Keys.Enter);

            beneficiaryCountry.Click();
            beneficiaryCountry.SendKeys(Keys.ArrowDown);
            beneficiaryCountry.SendKeys(Keys.Enter);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(nextbtn));
            ((IJavaScriptExecutor)driver).ExecuteScript("$('.btn-1').click();");
            

            Thread.Sleep(3000);






        }
    

    }
}
