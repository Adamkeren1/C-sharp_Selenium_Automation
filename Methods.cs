using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.SDK.PageObjects;

namespace Ofakim360Final_1
{
    class Methods : Program
    {
        

        public Methods()
        {
            PageFactory.InitElements(Program.driver, this);
        }
        public static  bool SalesPerson(string fName, string lName)
        {
            if (fName.ToLower() == lName.ToLower())
                return true;
            else
                return false;

        }
        public static void SendKeys(IWebElement element, string TextValue)
        {
            if (element != null)
            {
                element.SendKeys(TextValue);
            }
        }
        public static void ClickOnElement(IWebElement element, IWebDriver driver)
        {
            element.Click();
        }

        internal void openbrowser(string v, IWebDriver driver)
        {
            throw new NotImplementedException();
        }

        public static void WaitForElement(IWebElement element , IWebDriver driver)
            {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            }



        public void openbrowser(string url ,IWebDriver driver, IWebElement EmailFieldElem, IWebElement PasswordFieldElem)
        {
            PageLogin pageLogin = new PageLogin();
            driver.Navigate().GoToUrl(url);
            EmailFieldElem.SendKeys("***");
            PasswordFieldElem.SendKeys("***!");
            
            IWebElement Login_Button = driver.FindElement(By.XPath("html/body/app-root/div[1]/div[1]/div/app-login/div/div[1]/div/form/div[4]/button"));
        }

        public void printelem(string teststring )
        {

            Console.WriteLine(teststring);
      

        }

  






    }
}

