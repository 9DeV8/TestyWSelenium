using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyWSelenium
{
    class ContactPage
    {

        [Obsolete]
        public ContactPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "id_contact")]
        public IWebElement ddlContactId { get; set; }


        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement enterYourMessage { get; set; }


        [FindsBy(How = How.Id, Using = "submitMessage")]
        public IWebElement btnSubmit { get; set; }

        [Obsolete]
        public ContactPage SendMessage(string message)
        {
            enterYourMessage.EnterText(message);
            btnSubmit.Submit();
            return new ContactPage();
        }
        [Obsolete]
        public ContactPage SelectFrom(string text)
        {
            var dropdown = new SelectElement(this.ddlContactId);
            dropdown.SelectByText(text);
            return new ContactPage();
        }
    }


}

