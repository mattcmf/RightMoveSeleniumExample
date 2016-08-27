/*
 * Written by Matthew Frampton for validation purposes only.
Using fluent assertions to make checks more readable.
*/
using FluentAssertions;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace RightMove.PageModels
{
    class PropertySearchResults : PageModelBase
    {
        public void VerifyListingWithPropertyDisplayed(string listingProperty, string expectedValue)
        {
            SearchAllListingsForValue(listingProperty, expectedValue).Should().Be(expectedValue);
        }

        public void VerifyListingWithPropertyIsNotDisplayed(string listingProperty, string expectedValue)
        {
            string ExpectedOutputForNegativeScenario =  "Unable to find a listing with [ " + listingProperty + "] :  [" + expectedValue + "]";
            SearchAllListingsForValue(listingProperty, expectedValue).Should().Be(ExpectedOutputForNegativeScenario);
        }

        public string SearchAllListingsForValue(string ListingProperty, string expectedValue)
        {
            //Return a collection of all the search results.
            ReadOnlyCollection<IWebElement> ResultsSet = Driver.FindElements(By.CssSelector(".l-searchResult.is-list"));

            //Loop through each listing and check the desired property contains the expected value
            foreach (IWebElement eachResult in ResultsSet)
            {
                /*Allof the property card identifiers use the same format, so using concatenation to drive the identifiers
                from business logic. This means if the functionality changes, we can update the scripts from a feature level
                not from a programming level*/
                string actualValue = eachResult.FindElement(By.ClassName("propertyCard-" + ListingProperty)).Text;
                if (actualValue == expectedValue)
                {
                    return actualValue;
                }
            }

            //Verbose logging to speed up debugging.
            return "Unable to find a listing with [ " + ListingProperty + "] :  [" + expectedValue + "]";
        }
    }
}
