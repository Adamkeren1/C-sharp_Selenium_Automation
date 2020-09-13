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
    class PagePay1 : Program
    {

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));


        public PagePay1()
        {

            PageFactory.InitElements(Program.driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = ".position-relative:nth-child(3) > .beneficiary-circle")]
        private IWebElement SelectBen;


        [FindsBy(How = How.ClassName, Using = "select2-search__field")]
        private IWebElement SelectBenTextInputField;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[1]/div[2]/div[2]/app-payment/section/div/div[2]/div/app-step1/div/div/div/form/div[3]/button")]
        private IWebElement nextButton;

        //*[@id="select2-agp6-container"]



        public void selectBeneficiaryToPay()
        {




            //  ((IJavaScriptExecutor)driver).ExecuteScript("$('#bselect2-cv5z-container').click();");
            Thread.Sleep(6500);
            //  ((IJavaScriptExecutor)driver).ExecuteScript("$('select').val('b2614d7e-2d1d-4f3d-9aa6-460796c1b6b8').change();");
            //   ((IJavaScriptExecutor)driver).ExecuteScript("$('select').val('eb40ea4d-9dd4-483e-bf3c-398c3676f9b3').change();");

            //    value >> eb40ea4d-9dd4-483e-bf3c-398c3676f9b3

            try
            { SelectBen.Click(); }
            catch
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("$('select').click();");
            }



            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".position-relative:nth-child(3) > .beneficiary-circle")));
            //IWebElement arr2 = driver.FindElement(By.CssSelector(".custom-1"));
            //arr2.Click();

            //arr2.SendKeys("gree");
            //arr2.SendKeys(Keys.ArrowDown);
            //arr2.SendKeys(Keys.Enter);

            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".custom - 1")));
            //IWebElement NB = driver.FindElement(By.CssSelector(".custom - 1"));
            //NB.Click();


        }

        public void selectnext()
        {

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(nextButton));
            nextButton.Click();
        }

        public void SetNewBen()
        {
            //try
            //{
            //      ((IJavaScriptExecutor)driver).ExecuteScript("$('.dropdown-toggle add-beneficiary-btn font-1 color-black modal-btn-1 bg-none border-0').click();");
            //    Thread.Sleep(2000);
            //    ((IJavaScriptExecutor)driver).ExecuteScript("$('.btn-1').click();");

            //}
            //catch
            //{
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("(//button[@type='button'])[7]")));
            //IWebElement ABB = driver.FindElement(By.XPath("(//button[@type='button'])[7]"));
            //ABB.Click();
            //Thread.Sleep(1000);
            //Thread.Sleep(9000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName("add-beneficiary-btn")));
            ((IJavaScriptExecutor)driver).ExecuteScript("$('.add-beneficiary-btn').click();");
            Thread.Sleep(2000);
            //  ((IJavaScriptExecutor)driver).ExecuteScript("$('.btn-1').click();");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("Got it")));
            IWebElement GotItPopUpButton2 = driver.FindElement(By.LinkText("Got it"));
            Thread.Sleep(2000);
            GotItPopUpButton2.Click();





        }
    }
}