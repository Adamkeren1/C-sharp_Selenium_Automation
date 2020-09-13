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
    class NewBen2 : Program
    {
        static DateTime dateValue = DateTime.Now;
        public string dd1 = dateValue.ToString("dd/MM/yy");

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));


        public NewBen2()
        {

            PageFactory.InitElements(Program.driver, this);
        }

        [FindsBy(How = How.Id, Using = "accountType")]
        public IWebElement  accountType;

        [FindsBy(How = How.Id, Using = "iban")]
        public IWebElement iban;

        [FindsBy(How = How.ClassName, Using = "btn-1")]
        public IWebElement nextbtn;


        public void GoThrewPage()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(accountType));
            accountType.Click();
            accountType.SendKeys("iban");
            accountType.SendKeys(Keys.Enter);

            iban.Click();
            iban.SendKeys("IL160110100000139362314");
            iban.SendKeys(Keys.Tab);
            iban.SendKeys(Keys.Tab);
            Thread.Sleep(3000);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(nextbtn));
            ((IJavaScriptExecutor)driver).ExecuteScript("$('.btn-1').click();");







        }

        
    }
    
}
