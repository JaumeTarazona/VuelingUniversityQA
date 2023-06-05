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
    public class LoginPage : CommonPage
    {
        public LoginPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {

        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement btnLog
        {
            get { return WebDriver.FindElementByXPath("//*[@id=\"logInModal\"]/div/div/div[3]/button[2]"); }

        }
        private IWebElement btnUserName
        {
            get { return WebDriver.FindElementById("loginusername"); }
        }
        private IWebElement btnPasword
        {
            get { return WebDriver.FindElementById("loginpassword"); }
        }

        public LoginPage AddDoc()
        {
            btnUserName.SendKeys("a");
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(1));
            wait.Until(CustomExpectedConditions.ElementIsVisible(By.Id("loginusername")));
            btnPasword.SendKeys("a");
            btnLog.Click();

            return this;
        }

    }
}
