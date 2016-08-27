using OpenQA.Selenium;

namespace RightMove.PageModels
{
    //import from the page model base to re-use the driver component
    class HomePage : PageModelBase
    {
        //In a full framework identifiers will be defined centrally at the top here using a page factory approach

        public void NavigateToSearchPageForLocation(string Location)
        {
            Driver.FindElement(By.Id("searchLocation")).SendKeys(Location);
            Driver.FindElement(By.Id("buy")).Click();
        }
    }
}
