using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ProteinWorks.Hooks
{
    [Binding]
    public static class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://pensive-darwin.theproteinworks.com/customer/account/create/.");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


        [AfterScenario]
        public static void AfterScenario()
        {
            driver.Quit();
        }
    }
}
