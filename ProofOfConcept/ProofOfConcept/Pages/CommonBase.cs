using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using HtmlElements.Elements;
using OpenQA.Selenium;

namespace ProofOfConcept.Pages
{
    public abstract class CommonBase
    {
        public RemoteWebDriver Driver { get; set; }

        public static void AssertIsEqual(string expectedValue, string actualValue, string elementDescription)
        {
            if (expectedValue != actualValue)
            {
                throw new AssertionException(String.Format("AssertIsEqual Failed: '{0}' didn't match expectations. Expected [{1}], Actual [{2}]", elementDescription, expectedValue, actualValue));
            }
        }

        [FindsBy(How = How.Id, Using = "PH_user-email")]
        private IWebElement userMailText;

        public Boolean isMailTextPresent()
        {
            try
            {
                return userMailText.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /*public static void AssertElementPresent(IWebElement element, string elementDescription)
        {
            try
            {
                bool b = element.Displayed;
            }
            catch
            {
                throw new AssertionException(String.Format("AssertElementPresent Failed: Could not find '{0}'", elementDescription));
            }
        }

        public static void AssertElementPresent(ISearchContext context, By searchBy, string elementDescription)
        {
            try
            {
                bool b = context.FindElement(searchBy).Displayed;
            }
            catch
            {
                throw new AssertionException(String.Format("AssertElementPresent Failed: Could not find '{0}'", elementDescription));
            }
        }

        public static void AssertElementsPresent(IWebElement[] elements, string elementDescription)
        {
            if (elements.Length == 0)
                throw new AssertionException(String.Format("AssertElementsPresent Failed: Could not find '{0}'", elementDescription));
        }

        public static void AssertElementText(IWebElement element, string expectedValue, string elementDescription)
        {
            AssertElementPresent(element, elementDescription);
            string actualtext = element.Text;
            if (actualtext != expectedValue)
            {
                throw new AssertionException(String.Format("AssertElementText Failed: Value for '{0}' did not match expectations. Expected: [{1}], Actual: [{2}]", elementDescription, expectedValue, actualtext));
            }
        }*/
    }
}
