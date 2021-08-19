using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ProteinWorks.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProteinWorks.PageObject
{
    class ProteinWorksPage
    {
        public IWebDriver driver;
        private object linksCount;
        private string[] links;

        public ProteinWorksPage()
        {
            driver = WebHook.driver;
        }


        public void EnterFirstName()
        {
            driver.FindElement(By.Id("firstname")).SendKeys("sam");
        }

        public void EnterLastName()
        {
            driver.FindElement(By.Id("lastname")).SendKeys("smith");
        }

        public void EnterEmail()
        {
            driver.FindElement(By.Id("email_address")).SendKeys("sam.smith@mail.com");
        }

        public void EnterPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("Isofix123");
        }

        public void EnterCPassword()
        {
            driver.FindElement(By.Id("password-confirmation")).SendKeys("Isofix123");
        }

        public void SelectGender()
        {
            var selectElement = new SelectElement(driver.FindElement(By.XPath("//*[@id='gender']")));
            selectElement.SelectByIndex(1);
        }

        public void EnterDob()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebHook.driver;
            js.ExecuteScript("document.getElementById('dob').value='11/03/1980'");
        }

        public void EnterMobileNumber()
        {
            driver.FindElement(By.Id("mobile_number_input")).SendKeys("07590193310");
        }

        public void SelectMainGoal()
        {
            var selectElement = new SelectElement(driver.FindElement(By.Id("customer_goal")));
            selectElement.SelectByIndex(7);
        }

        public void ClickSubscribeNo()
        {
            IWebElement radio = driver.FindElement(By.Id("is_subscribed_no"));
            Thread.Sleep(5000);
            radio.Click();
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(radio);
            //actions.Perform();
        }

        public void ClickJoinUp()
        {
            driver.FindElement(By.XPath("//*[@id='form - validate']/div/div[1]/button")).Click();
        }






    }

}