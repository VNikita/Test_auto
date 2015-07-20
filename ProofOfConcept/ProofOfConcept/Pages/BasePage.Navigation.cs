using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;

namespace ProofOfConcept.Pages
{
    public abstract partial class BasePage: CommonBase
    {
        public static LoginPage NavigateToMailRUPage(RemoteWebDriver driver, string baseURL)
        {
            driver.Navigate().GoToUrl(baseURL.TrimEnd(new char[] { '/' }) + LoginPage.URL);
            return GetInstance<LoginPage>(driver, baseURL);
        }

        public static LoginPage NavigateToMail(RemoteWebDriver driver, string baseURL)
        {
            driver.Navigate().GoToUrl(baseURL.TrimEnd(new char[] { '/' }) + LoginPage.URL);
            return GetInstance<LoginPage>(driver, baseURL);
        }
    }
}
