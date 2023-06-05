using AventStack.ExtentReports;
using NUnit.Framework;
using System.Threading;
using Vueling.Auto.Template.Webpages;
using Vueling.Auto.Template.WebPages;

namespace Vueling.Auto.Template.Tests
{
    [TestFixture]
    class Exercise2 : TestSetCleanBase
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

    }
}
