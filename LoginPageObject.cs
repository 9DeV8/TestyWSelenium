using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyWSelenium
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);


        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement btnLogin { get; set; }

        public LoginPageObject Login(string userName, string password)
        {
            txtUserName.EnterText(userName);
            txtPassword.EnterText(password);
            
            btnLogin.Submits();

            return new LoginPageObject();
        }
    }
}
