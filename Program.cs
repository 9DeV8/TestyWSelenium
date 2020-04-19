using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestyWSelenium
{
    class Program
    {
       

        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //otwarcie strony 
            PropertiesCollection.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");

            Console.WriteLine("Otwarcie strony");

        }
        [Test]
        public void ExexuteProperLogin()
        {
            //logowanie do aplikacji poprawnym loginem i hasłem

            LoginPageObject pageObject = new LoginPageObject();
            LoginPageObject pagelogin = pageObject.Login("arrakisbse@gmail.com", "Selenium1");

            var element = PropertiesCollection.driver.FindElement(By.ClassName("my-account"));

            Console.WriteLine("znaleziono element my-account");


            Console.WriteLine("Wykonanie testu");
        }
        [Test]
        public void ExexuteWrongLogin()
        {
            //logowanie do aplikacji złym loginem i dobrym hasłem
           
            LoginPageObject pageObject = new LoginPageObject();
            LoginPageObject pagelogin = pageObject.Login("arrakisbse@gmail.comm", "Selenium1");
            var element = PropertiesCollection.driver.FindElement(By.ClassName("alert"));
           
            Console.WriteLine("znaleziono element alert");

            Console.WriteLine("Wykonanie testu");
        }
        [Test]
        public void Add_To_Cart_From_Main_Page_Logged()
        {
            LoginPageObject pageObject = new LoginPageObject();
            LoginPageObject pagelogin = pageObject.Login("arrakisbse@gmail.com", "Selenium1");

            PropertiesCollection.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            SelectClothes pageClothes = new SelectClothes();

            SelectClothes FirstShirt = pageClothes.SelectFirstShirt();

        }
        [Obsolete]
        [Test]
        public void Add_To_Cart_After_Select_Item_Logged()
        {
            //logowanie
            LoginPageObject pageObject = new LoginPageObject();
            LoginPageObject pagelogin = pageObject.Login("arrakisbse@gmail.com", "Selenium1");
            //powrot do glownej strony
            PropertiesCollection.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            SelectClothes pageClothes = new SelectClothes();
            //wybranie podstrony z szczegółami
            SelectClothes Selectseconditem = pageClothes.SelectSecondBlouse();

            //refresh strony aby można było zczytać dobre ID i Name
            PropertiesCollection.driver.Navigate().Refresh();


            ItemDetails pageDetails = new ItemDetails();
            ItemDetails SelectSize = pageDetails.SelectSizeFromDDL("M");
            ItemDetails SelectAddToCart = pageDetails.ClickAddToCart();


        }
        [Test]
        [Obsolete]
        public void FillContactForm()
        {
            //logowanie
            LoginPageObject pageObject = new LoginPageObject();
            LoginPageObject pageEA = pageObject.Login("arrakisbse@gmail.com", "Selenium1");
            PropertiesCollection.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
            //przejscie do contact us
            ContactPage contactPage = new ContactPage();
            ContactPage conPa1 = contactPage.SelectFrom("Webmaster");
            //wyslanie message
            ContactPage conPa2 = contactPage.SendMessage("nie słysze cie, halo? lorem ipsum tu powinien być czy coś");
        }




        [TearDown]
        public void CleanUp()
        {
            //zamkniecie przegladarki
            PropertiesCollection.driver.Close();

            Console.WriteLine("Zamknięcie przeglądarki");
        }

    }
}
