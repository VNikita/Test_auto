using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using ProofOfConcept.Browser;
using TechTalk.SpecFlow;

namespace ProofOfConcept.Tests
{
    [Binding]
    public class TestFixtureBase
    {
        protected static RemoteWebDriver CurrentDriver { get; set; }

        [SetUp]
        public static void Test_Setup()
        {
            CurrentDriver = WebDriverSetup.getWebDriver(Settings.CurrentSettings.BrowserName);
        }

        [TearDown]
        public static void Test_Teardown()
        {
            try
            {
                CurrentDriver.Quit();
                System.Diagnostics.Process.GetProcessesByName("IEDriverServer.exe");
            }
            catch { }
        }
    }
}
