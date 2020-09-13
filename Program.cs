using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using Ofakim360Final_1.Pages;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;

namespace Ofakim360Final_1
{

    class Program
    {
        static  public IWebDriver driver = new ChromeDriver();
        static Methods methods = new Methods();
        public static PageLogin pageLogin = new PageLogin();
        static PageRegistration1 pageRegistration1 = new PageRegistration1();
        static PageDashboard pagedashboard = new PageDashboard();
        static PageDeposit1 pagedeposit1 = new PageDeposit1();
        static PageDeposit2 pagedeposit2 = new PageDeposit2();
        static PageDeposit3 pagedeposit3 = new PageDeposit3();
        static PageDeposit4 pagedeposit4 = new PageDeposit4(driver);
        static PagePay1 pagepay1 = new PagePay1();
        static PagePay2 pagepay2 = new PagePay2(driver);
        static PagePay3 pagepay3 = new PagePay3(driver);
        static PagePay4 pagepay4 = new PagePay4(driver);
        static PagePay5 pagepay5 = new PagePay5(driver);
        static PageDeposit1_draft depdraft = new PageDeposit1_draft(driver);
        static PageWithdrawal1 withdrawalpage1 = new PageWithdrawal1(driver);
        static PageWithdrawal2 withdrawalpage2 = new PageWithdrawal2(driver);
        static PageWithdrawal3 withdrawalpage3 = new PageWithdrawal3(driver);
        static PageBenList pageBenList = new PageBenList(driver);
        static PageBackOfficeLogin pageloginbackoffice = new PageBackOfficeLogin();
        static PageBackOfiiceCatalog pageBackOfiiceCatalog = new PageBackOfiiceCatalog();
        static NewBen1 newben1 = new NewBen1();
        static NewBen2 newben2 = new NewBen2();
        static NewBen3 newben3 = new NewBen3();
        static NewBen4 newben4 = new NewBen4();
        static PageMassPay1 pagemasspay1 = new PageMassPay1();
        static Exersice1 Exersice1 = new Exersice1();
        


        public static  void  Main(string[] args)
        {
            // Exersice1.InteracWithModal();
            //try
            //{
            //    Console.WriteLine("started");
            //    //ProdLogin();
            //    //StageBOLoginAndCatalog();
            //}
            //catch (Exception)
            //{

            //    KycRegisterTest();
            Methods.SalesPerson("abC","abc");
                StageLogin();
                //   Masspay();
                PaymentAction();
                NewBenAction();
                WithdrawalAction();


                // pagedashboard.dissmisalert();
                DepositAction();

            //    driver.Quit();



        }

        static void Masspay()
        {
            pagedashboard.NavigetToMassPay();
            pagemasspay1.AddNewPayment();
        }

        static void KycRegisterTest()
        {
            pageRegistration1.NavigateThrowPage("https://www.feanex.com/welcome","kycautotest1@ofakim.com", "kycautotest1@ofakim.com", "Private");
        }

        static public void StageBOLoginAndCatalog()
        {

            pageloginbackoffice.PerformLoginAction("https://ofakim-g.com/", "adam@ofakim-group.com", "Ofakim1!", driver);
            pageloginbackoffice.GoToHedgeCatalog();
            pageBackOfiiceCatalog.RunCatalog100();

            Console.WriteLine("Back Office Catalog purchase succeeded");


        }
        static public void DepositAction()
        { 
            pagedashboard.NavigateToDeposit();
            pagedeposit1.NavigateThrowDeposit1();
            pagedeposit2.NavigateThrowDeposit2();
            pagedeposit3.NavigateThrowDeposit3();
            Console.WriteLine("Deposit action succeeded");
        }

        private static void PaymentAction()
        {
            pagedashboard.NavigateToPay();
            
            //pageBenList.ChooseBen();
            pagepay1.selectBeneficiaryToPay();
            pagepay1.selectnext();
            pagepay2.FillForm();
            pagepay3.FillForm();
            pagepay4.FillForm();
            pagepay5.FillForm();
            Thread.Sleep(1500);

            Console.WriteLine("Payment action succeeded");

        }

        private static void WithdrawalAction()
        {

            pagedashboard.NavigateToWithdrawal();
            withdrawalpage1.NavigateThrewPage1();
            withdrawalpage2.NavigateThrewPage2();
            withdrawalpage3.Navigatethrewpage3();

            Console.WriteLine("Withdrawal action succeeded");

        }



        static public void StageLogin()
        {
            pageLogin.PerformLoginAction("https://demo.ofakim.ai/login", "ofakimqa1@gmail.com", "Ofakim1!", driver);
          //  pagedashboard.dissmisalert();
            Thread.Sleep(4500);
            Console.WriteLine("Stage Login action succeeded");
        }


        static public void ProdLogin() 
        {
            pageloginbackoffice.PerformLoginAction("https://online.evenedge.com/", "adam@ofakim-group.com", "Ofakim1!", driver);
            //pagedashboard.dissmisalert();
            Thread.Sleep(1500);
            Console.WriteLine("BO Prod login succeeded");
        }

        private static void NewBenAction()
        {
            pagedashboard.NavigateToPay();
            pagepay1.SetNewBen();
            Thread.Sleep(5000);
            newben1.GoThrewPage();
            newben2.GoThrewPage();
            newben3.GoThrewPage();
            newben4.GoThrewPage();

            Console.WriteLine("New Ben action succeeded");


        }







    }


}

//Mybabynina1