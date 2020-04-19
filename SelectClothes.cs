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
    class SelectClothes
    {
        public SelectClothes()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);


        }
        

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[2]/div[2]/a[1]")]
        public IWebElement FieldFirstShirt { get; set; }


        [FindsBy(How = How.LinkText, Using = "Blouse")]
        public IWebElement FieldSecondBlouse { get; set; }



        public SelectClothes SelectFirstShirt()
        {;

            FieldFirstShirt.Clicks();

            return new SelectClothes();
        }

        public SelectClothes SelectSecondBlouse()
        {
            ;

            FieldSecondBlouse.Clicks();

            return new SelectClothes();
        }

    }
}
