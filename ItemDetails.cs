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
    class ItemDetails
    {
        [Obsolete]
        public ItemDetails()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);


        }

        [FindsBy(How = How.Id, Using ="group_1")]
        public IWebElement DDLSize { get; set; }

        [FindsBy(How = How.Name, Using = "Submit")]
        public IWebElement btn { get; set; }

        [Obsolete]
        public ItemDetails SelectSizeFromDDL(string text)
        {

            var dropdown = new SelectElement(this.DDLSize);
            dropdown.SelectByText(text);
            

            return new ItemDetails();
        }
        [Obsolete]
        public ItemDetails ClickAddToCart()
        {

            btn.Submit();


            return new ItemDetails();
        }

    }
}
