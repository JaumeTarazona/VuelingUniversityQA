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
    public class BuyPage : CommonPage
    {
        public BuyPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {

        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement btnAddToCart
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Add to cart']"); }

        }
        public BuyPage addToCart()
        {
            btnAddToCart.Click();
            return this;
        }


    }
}
