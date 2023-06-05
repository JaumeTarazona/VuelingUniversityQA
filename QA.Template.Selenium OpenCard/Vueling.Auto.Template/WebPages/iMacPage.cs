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
    public class iMacPage : CommonPage
    {
        public iMacPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {

        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement btnaddToCart
        {
            get { return WebDriver.FindElementById("button-cart"); }

        }
        private IWebElement btnCheckout
        {
            get { return WebDriver.FindElementById("cart-total"); }

        }

        //FUNCTIONS

        public iMacPage clickLaptop()
        {
            Thread.Sleep(1000);
            btnaddToCart.Click();
            btnCheckout.Click();

            return this;
        }

    }
}
