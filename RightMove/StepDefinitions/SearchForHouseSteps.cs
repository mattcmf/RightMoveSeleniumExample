using RightMove.Desktop.PO_Automation.WebAutomation.StepDefinitions;
using RightMove.PageModels;
using System;
using TechTalk.SpecFlow;

namespace RightMove.StepDefinitions
{
    [Binding]
    public class SearchForHouseSteps
    {
        HomePage homePage = new HomePage();
        SearchPage searchPage = new SearchPage();
        PropertySearchResults propertySearchResults = new PropertySearchResults();

        [Given(@"I am on the search page for the area (.*)")]
        public void GivenIAmOnTheSearchPageForTheArea(string address)
        {
            homePage.NavigateToSearchPageForLocation(address);
        }

        [When(@"I have searched for a house with a '(.*)' budget of (.*)")]
        public void WhenIHaveSearchedForAHouseWithABudgetOf(string minOrMax, string budget)
        {
            searchPage.SetPriceBracket(minOrMax, budget);
        }
        
        [When(@"a min (.*) bedrooms and max (.*) bedrooms")]
        public void WhenAMinBedroomsAndMaxBedrooms(string minBeds, string maxBeds)
        {
            searchPage.SetRequiredBedrooms(minBeds, maxBeds);
        }
        
        [When(@"I select find property")]
        public void WhenISelectFindProperty()
        {
            searchPage.SearchForPropety();
        }
        
        [Then(@"I should be able to view property (.*)")]
        public void ThenIShouldBeAbleToViewProperty(string listingProperty)
        {
            propertySearchResults.VerifyListingWithPropertyDisplayed("address", listingProperty);
        }

        [Then(@"I verify a listing with the (.*) : (.*) is displayed")]
        public void ThenIShouldBeAbleToViewProperty(string listingProperty, string expectedValue)
        {
            propertySearchResults.VerifyListingWithPropertyDisplayed(listingProperty, expectedValue);
        }

        [Then(@"I verify a listing with the (.*) : (.*) is NOT displayed")]
        public void ThenIVerifyAListingWithTheIsNotDisplayed(string listingProperty, string expectedValue)
        {
            propertySearchResults.VerifyListingWithPropertyIsNotDisplayed(listingProperty, expectedValue);
        }
    }
}
