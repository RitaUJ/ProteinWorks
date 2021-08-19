using OpenQA.Selenium;
using ProteinWorks.Hooks;
using ProteinWorks.PageObject;
using System;
using TechTalk.SpecFlow;

namespace ProteinWorks.Steps
{
    [Binding]
    public class ProteinWorksSteps
    {
        public IWebDriver driver = WebHook.driver;
        ProteinWorksPage _proteinWorksPage = new ProteinWorksPage();

        [Given(@"I fill in my details")]
        public void GivenIFillInMyDetails()
        {
            _proteinWorksPage.EnterFirstName();
            _proteinWorksPage.EnterLastName();
            _proteinWorksPage.EnterEmail();
            _proteinWorksPage.EnterPassword();
            _proteinWorksPage.EnterCPassword();
            _proteinWorksPage.SelectGender();
            _proteinWorksPage.EnterDob();
            _proteinWorksPage.EnterMobileNumber();
            _proteinWorksPage.SelectMainGoal();
            _proteinWorksPage.ClickSubscribeNo();
        }
        
        [When(@"I click sign up")]
        public void WhenIClickSignUp()
        {
            _proteinWorksPage.ClickJoinUp();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
