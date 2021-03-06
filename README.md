# RightMoveSeleniumExample


**High Level Overview**
Experiment with Selenium to create a BDD test solution that will automate the search for a property to buy in Milton Keynes, min 2 bed, max 3 bed, price below £300,000.

**Tools:**
* Visual Studio
* Nunit (Nuget package)
* Selenium (Nuget package) + extension Nuet
* FluentAssertions (Nuget package)
* NUnit Test Runner Extension for visual Studio

**Summary of tool selection:**
* Free to setup
* Easy import of external modules (nugets)
* Integration with NUnit and third party libraries
* Using common language C#

**Architecture Overview**
![Image of sample selenium framework](https://docs.google.com/drawings/d/1w0gb6SetfRhTtDKlYOMzC_JozLKDzNnxxvqOandfyNY/pub?w=960&h=720)

**Setup/Instructions for new starters:**
* Open Visual Studio
* Ensure all plugins are loaded correctly: Select File Open > Project.
* In the solution explorer, right click on the project and select "Manage Nuget packages"
    https://drive.google.com/open?id=0BwRZifnFSiMOcmVETFc1dVdVYTA
* Ensure the "Installed" tab is selected, then verify all Nugets in Tools are visible.
* Build project using (control + shift + B)
* Tests toolbar should be open on the left hand side
* Select Run All tests
    https://drive.google.com/open?id=0BwRZifnFSiMOU3Y2VE5VWEdaams
* Setup is a example test and does not perform any verifications
* All tests (apart from negative scenarios) should run and pass (assuming there are no changes to the available houses)

**Out of scope:**
* Unit and integration testing

**General Notes**

Spec reads, user can search for houses **under** "300,000", opposed to houses **less than or equal** to 300,000. The website only offers a max option of 300,000. Meaning it is not possible to enter less than 300,000 without also including 300,000. This may be a potential issue and should be queried with the subject matter expert.

**Expansion: Reporting**

This framework has been written to support the Allure plugin: http://allure.qatools.ru
Using Allure, it is possible to generate high level test summary reports using graphs etc. See following link for demo solution: http://ci.qatools.ru/job/allure-core_master-deploy/lastSuccessfulBuild/Allure_report/

**Allure Graphs:**
![Image of Allure Reports](http://allure.qatools.ru/img/graph.png)


**Allure Test Stats:**
![Image of Allure Stats](http://allure.qatools.ru/img/overview.png)
