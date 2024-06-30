using Automation.Demo.Project.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Automation.Demo.Project.StepDefinitions
{
    [Binding]
    public class IxigoFeatureStepDefinitions
    {
       // private readonly IWebDriver _driver;
        private readonly IxigoHomePage _ixigoHomePage;

        public IxigoFeatureStepDefinitions(DriverManager driverManager)
        {
            _ixigoHomePage = new IxigoHomePage(driverManager.GetDriver());
        }



        [Given(@"I am on the ixigo homepage")]
        public void GivenIAmOnTheIxigoHomepage()
        {
            _ixigoHomePage.NavigateTo();
            Thread.Sleep(9000);
        }

        [When(@"I type ""([^""]*)"" in the departure city input field")]
        public void WhenITypeInTheDepartureCityInputField(string delhi)
        {
            _ixigoHomePage.EnterDepartureCity(delhi);
            Thread.Sleep(9000);

        }

        [Then(@"I should see autocomplete suggestions")]
        public void ThenIShouldSeeAutocompleteSuggestions()
        {
       
        }

        [When(@"I select a suggestion from the autocomplete")]
        public void WhenISelectASuggestionFromTheAutocomplete()
        {
           
        }

        [Then(@"the departure city input field should be populated correctly")]
        public void ThenTheDepartureCityInputFieldShouldBePopulatedCorrectly()
        {
           
        }
    }
}
