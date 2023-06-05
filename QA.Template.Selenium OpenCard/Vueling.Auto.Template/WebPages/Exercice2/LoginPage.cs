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
    public class LoginPageEx2 : CommonPage
    {
        public LoginPageEx2(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {

        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement btnAcceptCookies
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Acepta todas las cookies']"); }

        }

            get { return WebDriver.FindElementByXPath("//a[text() = 'Desktops']"); }


    }
}
