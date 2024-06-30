using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Demo.Project.Pages
{
    public class IxigoHomePage
         {
        private readonly IWebDriver _driver;
        private const string PageUrl = "https://www.ixigo.com/";

        // Element selectors
       // private IWebElement DepartureCityInput => _driver.FindElement(By.Id("departure-city-input-id")); // Update the ID as per the actual element
        private IWebElement DepartureCityInput => _driver.FindElement(By.XPath("//input[@value='Hyderabad']"));
        public IxigoHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo()
        {
            _driver.Navigate().GoToUrl(PageUrl);
        }

       public void EnterDepartureCity(string cityName)
        {
            DepartureCityInput.Click();
            DepartureCityInput.Clear();
            DepartureCityInput.SendKeys(cityName);
        }

       /* public bool IsAutocompleteVisible()
        {
            // Implement a check to see if autocomplete suggestions are visible
            //return _driver.FindElement(By.CssSelector("autocomplete-selector")).Displayed; // Update the selector as per the actual element
        }

        public void SelectFirstAutocompleteSuggestion()
        {
            //_driver.FindElement(By.CssSelector("first-autocomplete-suggestion-selector")).Click(); // Update the selector as per the actual element
        }

        public string GetDepartureCityValue()
        {
           // return DepartureCityInput.GetAttribute("value");
        }*/
    }
}

