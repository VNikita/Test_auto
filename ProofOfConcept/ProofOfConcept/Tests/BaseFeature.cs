using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;
using ProofOfConcept.Pages;

namespace ProofOfConcept.Tests
{
    public class BaseFeature : TestFixtureBase
    {
        protected string BrowserName { get { return Settings.CurrentSettings.BrowserName; } }

        protected BasePage NextPage { set { CurrentPage = value; } }

        protected BasePage CurrentPage
        {
            get { return (BasePage)ScenarioContext.Current["CurrentPage"]; }
            set { ScenarioContext.Current["CurrentPage"] = value; }
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            if (!ScenarioContext.Current.ContainsKey("CurrentDriver"))
            {
                Test_Setup();
                ScenarioContext.Current.Add("CurrentDriver", CurrentDriver);
            }
            else
            {
                CurrentDriver = (RemoteWebDriver)ScenarioContext.Current["CurrentDriver"];
            }
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            if (ScenarioContext.Current.ContainsKey("CurrentDriver"))
            {
                Test_Teardown();
                ScenarioContext.Current.Remove("CurrentDriver");
            }
        }
    }
}
