﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RightMove.UITests.SearchForHouse
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SearchForHouse_Budget")]
    public partial class SearchForHouse_BudgetFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Search_Budget.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SearchForHouse_Budget", "\tIn order to buy a house\r\n\tAs a home buyer with a fixed budget\r\n\tI want to view t" +
                    "he houses for sale that I can afford ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify the budget can be used to filter property listings")]
        [NUnit.Framework.TestCaseAttribute("Milton Keynes", "0", "100,000", "2", "3", "address", "Harebell Close, Walnut Tree, Milton Keynes", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Milton Keynes", "0", "1,000,000", "2", "3", "address", "Dynasty Drive, Bletchley, Milton Keynes", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Milton Keynes", "0", "10,000,000", "2", "3", "address", "Oakgrove Village", new string[0])]
        public virtual void VerifyTheBudgetCanBeUsedToFilterPropertyListings(string location, string minBudget, string maxBudget, string minBeds, string maxBeds, string listingProperty, string propertyName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the budget can be used to filter property listings", exampleTags);
#line 7
 this.ScenarioSetup(scenarioInfo);
#line 8
  testRunner.Given(string.Format("I am on the search page for the area {0}", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.When(string.Format("I have searched for a house with a \'max\' budget of {0}", maxBudget), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
  testRunner.And("I select find property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.Then(string.Format("I verify a listing with the {0} : {1} is displayed", listingProperty, propertyName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Invalid Ratio Selections")]
        [NUnit.Framework.TestCaseAttribute("Milton Keynes", "1,000,000", "50,000", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Milton Keynes", "1,000,000", "100,000", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Milton Keynes", "5,000,000", "1,000,000", new string[0])]
        public virtual void InvalidRatioSelections(string location, string minBudget, string maxBudget, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invalid Ratio Selections", exampleTags);
#line 18
 this.ScenarioSetup(scenarioInfo);
#line 19
  testRunner.Given(string.Format("I am on the search page for the area {0}", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
  testRunner.When(string.Format("I have searched for a house with a \'max\' budget of {0}", maxBudget), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
  testRunner.And("I select find property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
