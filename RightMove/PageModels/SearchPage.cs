using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace RightMove.PageModels
{
    class SearchPage : PageModelBase
    {
        internal static string minDropDown = "minBedrooms";
        internal static string maxDropDown = "maxBedrooms";
        internal static string findPropertyBtn = "submit";

        internal void SetPriceBracket(string minOrMax, string priceRestraint)
        {
            //Drop down will be extracted into a seperate re-usable class.
            string minMaxIdentifier = minOrMax.ToLower() + "Price";
            var rangeIdentifier = Driver.FindElement(By.Id(minMaxIdentifier));
            var selectElement = new SelectElement(rangeIdentifier);
            selectElement.SelectByText(priceRestraint);
        }

        internal void SetRequiredBedrooms(string min, string max)
        {
            //Set min bedrooms
            var minRangeIdentifier = Driver.FindElement(By.Id(minDropDown));
            var minSelectElement = new SelectElement(minRangeIdentifier);
            minSelectElement.SelectByText(min);

            //Set max bedrooms
            var maxRangeIdentifier = Driver.FindElement(By.Id(maxDropDown));
            var maxSelectElement = new SelectElement(maxRangeIdentifier);
            maxSelectElement.SelectByText(max);
        }

        internal void SearchForPropety()
        {
            Driver.FindElement(By.Id(findPropertyBtn)).Click();
        }
    }
}
