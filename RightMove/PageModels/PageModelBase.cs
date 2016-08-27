using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;

namespace RightMove.PageModels
{
    class PageModelBase
    {
        public static IWebDriver Driver;
        public static void InitialiseDriver()
        { 
            //Config files can also be used to specify different drivers for cross browser functionality
             Driver = new FirefoxDriver();
            //Assigning this to 10, but in a full framework, this will come from a config file that can be controlled remotely
            Driver.Manage().Window.Maximize();

            //Use multiple config files to split between environments
            int maxTimeout = int.Parse(ConfigurationSettings.AppSettings["MaxTimeout"]);
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(maxTimeout));
            Driver.Url = ConfigurationSettings.AppSettings["UrlEnvironment1"];

            Driver.Navigate();
        }

        internal static void ReturnHome()
        {
            Driver.Url = ConfigurationSettings.AppSettings["UrlEnvironment1"];
            Driver.Navigate();
        }

        public static void CloseDownDriver()
        {
            Driver.Quit();
        }
    }
}
