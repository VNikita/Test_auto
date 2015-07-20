using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace ProofOfConcept.Browser
{

    public static class WebDriverSetup
    {
        private static RemoteWebDriver WebDriver;
        private static Boolean useNewBrowserForEachScenario = true;
        // Usually is specified as system property

        public static long WAIT_TIMEOUT = 30;

        public static void closeBrowser()
        {
            if (WebDriver != null)
            {
                WebDriver.Close();
                WebDriver.Quit();
                WebDriver = null;
                Console.WriteLine("CloseBrowser - the browser has been closed");
            }
        }

        public static RemoteWebDriver getWebDriver(string DriverName = "")
        {
            if (WebDriver == null)
            {
                switch (DriverName)
                {
                    case "IE":
                        var options = new InternetExplorerOptions();
                        options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                        WebDriver = new InternetExplorerDriver(/*Settings.CurrentSettings.BrowserPath,*/ options);
                        
                        //IeCapabilities.setCapability(InternetExplorerDriver.INTRODUCE_FLAKINESS_BY_IGNORING_SECURITY_DOMAINS, true);
                //WebDriver = new InternetExplorerDriver(ieCapabilities);
                        break;
                    case "CHROME":
                    default:
                        WebDriver = new ChromeDriver();
                        break;
                }
                /*System.setProperty("webdriver.ie.driver", "src\\test\\resources\\drivers\\IEDriverServer.exe");
                DesiredCapabilities ieCapabilities = DesiredCapabilities.internetExplorer();
                ieCapabilities.setCapability(InternetExplorerDriver.INTRODUCE_FLAKINESS_BY_IGNORING_SECURITY_DOMAINS, true);
                webDriver = new InternetExplorerDriver(ieCapabilities);
                webDriver.manage().timeouts()
                        .implicitlyWait(WAIT_TIMEOUT, TimeUnit.MILLISECONDS);
                maximizeBrowser();*/
                WebDriver.Manage().Timeouts()
                        .ImplicitlyWait(TimeSpan.FromSeconds(WAIT_TIMEOUT));
                MaximizeBrowser();
            }
            
            return WebDriver;
        }

        //@Before
        /*public static void beforeScenario()
        {
            getWebDriver();
        }
        */
        //@After
       /* public void afterScenario()
        {
            if (useNewBrowserForEachScenario == true)
            {
                closeBrowser();
            }
        }*/

        private static void MaximizeBrowser()
        {
            WebDriver.Manage().Window.Maximize();
        }

        public static bool getUseNewBrowserForEachScenario()
        {
            return useNewBrowserForEachScenario;
        }
    }
}
