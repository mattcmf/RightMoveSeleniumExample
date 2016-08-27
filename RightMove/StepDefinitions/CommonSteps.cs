using RightMove.PageModels;
using TechTalk.SpecFlow;

namespace RightMove.Desktop.PO_Automation.WebAutomation.StepDefinitions
{
    [Binding]
    public static class CommonSteps
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            PageModelBase.InitialiseDriver();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            //Reset to initial URL
            PageModelBase.ReturnHome();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            PageModelBase.CloseDownDriver();
        }
    }
}
