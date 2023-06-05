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

        private IWebElement btnLog
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Log in']"); }

        }

        //HOME
        private IWebElement btnHome
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Home']"); }

        }

        //BUTTONS 
        //laptops
        private IWebElement btnLaptops
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Laptops']"); }

        }
        private IWebElement btnMacbook
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'MacBook air']"); }

        }

        //phones
        private IWebElement btnIPhone
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Phones']"); }

        }
        private IWebElement btnSamsungs6
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Samsung galaxy s6']"); }

        }

        //monitors 
        private IWebElement btnIMonitors
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Monitors']"); }

        }
        private IWebElement btnAsusMonitor
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'ASUS Full HD']"); }

        }



        //FUNCTIONS
        public HomePage goHome()
        {
            btnHome.Click();
            return this;
        }

        public HomePage clickbtnLog()
        {
            btnLog.Click();
            return this;
        }

        public HomePage clickLaptop()
        {
            Thread.Sleep(1000);
            btnLaptops.Click();
            btnMacbook.Click();
            return this;
        }
        public HomePage clickPhone()
        {
            Thread.Sleep(1000);
            btnIPhone.Click();
            btnSamsungs6.Click();
            return this;
        }
        public HomePage clickMonitor()
        {
            Thread.Sleep(1000);
            btnIMonitors.Click();
            btnAsusMonitor.Click();
            return this;
        }

        public HomePage clickMacbook()
        {
            Thread.Sleep(1000);
            btnLaptops.Click();
            btnMacbook.Click();
            return this;
        }

    }
}
