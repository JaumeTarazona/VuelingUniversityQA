using AventStack.ExtentReports;
using NUnit.Framework;
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
            homePage = new HomePage(setUpWebDriver);
            homePage.clickbtnLog();
            loginPage = new LoginPage(setUpWebDriver);
            loginPage.AddDoc();
            homePage.clickLaptop();
            buyPage = new BuyPage(setUpWebDriver);
            buyPage.addToCart();

        }

        [TestCase]
        public void TestPhone()
        {
            homePage = new HomePage(setUpWebDriver);
            homePage.clickbtnLog();
            loginPage = new LoginPage(setUpWebDriver);
            loginPage.AddDoc();
            homePage.clickPhone();
            buyPage = new BuyPage(setUpWebDriver);
            buyPage.addToCart();

        }
        
        [TestCase]
        public void TestMonitor()
        {
            homePage = new HomePage(setUpWebDriver);
            homePage.clickbtnLog();
            loginPage = new LoginPage(setUpWebDriver);
            loginPage.AddDoc();
            homePage.clickMonitor();
            buyPage = new BuyPage(setUpWebDriver);
            buyPage.addToCart();

        }

        [TestCase]
        public void MobileAndMonitor()
        {
            homePage = new HomePage(setUpWebDriver);
            homePage.clickbtnLog();
            loginPage = new LoginPage(setUpWebDriver);
            loginPage.AddDoc();
            homePage.clickMonitor();
            buyPage = new BuyPage(setUpWebDriver);
            buyPage.addToCart();
            homePage.goHome();
            homePage.clickPhone();
            buyPage.addToCart();

        }
    }
}
