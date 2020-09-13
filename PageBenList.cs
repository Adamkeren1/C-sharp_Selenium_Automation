using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.SDK.PageObjects;

namespace Ofakim360Final_1.Pages
{
    class PageBenList
    {
        public IWebDriver driver;


        public PageBenList(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "select2 - 2qn6 - container")]
        private IWebElement arrow;
                                          




        public void ChooseBen()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(45));
           
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(arrow));


           


            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("select2 - 2qn6 - container"));
            

            //    click on arrow

            //    click to text field

            //    inset text

            //    press one key down

            //    press  enter
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Greenformben));
            //Greenformben.Click();
        }



        


    }
}
