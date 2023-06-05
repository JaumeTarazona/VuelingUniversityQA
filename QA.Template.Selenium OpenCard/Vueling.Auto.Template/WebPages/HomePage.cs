using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vueling.Auto.Template.Common;
using Vueling.Auto.Template.SetUp;
using Vueling.Auto.Template.WebPages;
using Vueling.Auto.Template.WebPages.Base;

namespace Vueling.Auto.Template.WebPages
{
    public class HomePage : CommonPage
    {
        public HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {

        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement btnLaptops
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Desktops']"); }

        }
        private IWebElement btnMac
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Mac (1)']"); }

        }
        private IWebElement btniMac
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'iMac']"); }

        }
        private IWebElement btnSwiper
        {
            get { return WebDriver.FindElementByXPath("/html/body/div[2]/div/div/div[3]/div[3]/div[2]"); }
        }


        //FUNCTIONS

        public HomePage clickLaptop()
        {
            Thread.Sleep(1000);
            btnLaptops.Click();
            btnMac.Click();
            btniMac.Click();

            return this;
        }

        public HomePage clickSwiper()
        {
            btnSwiper.Click();
            return this;

        }
        public bool checkSwiper()
        {
            for (int x = 1; x <= 10; x++)
            {
                string elementText = WebDriver.FindElementByXPath($"//*[@id='carousel0']/div/div[{x}]").Text;

                if (elementText.Contains("nintendo"))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
