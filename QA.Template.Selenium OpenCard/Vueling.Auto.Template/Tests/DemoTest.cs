using AventStack.ExtentReports;
using Microsoft.SqlServer.Server;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;
using Vueling.Auto.Template.Webpages;
using Vueling.Auto.Template.WebPages;

namespace Vueling.Auto.Template.Tests
{
    [TestFixture]
    class DemoTest : TestSetCleanBase
    {
        [TestCase]
        public void TestLaptop()
        {
            //Trace.WriteLine("Hola");
            homePage = new HomePage(setUpWebDriver);
            homePage.clickLaptop();

            imacPage = new iMacPage(setUpWebDriver);
            imacPage.clickLaptop();

        }

        [TestCase]
        public void TestSwiper()
        {
            homePage = new HomePage(setUpWebDriver);
            homePage.checkSwiper();
        }
    }
}
