using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
//using HtmlElementsDotNet.HtmlElements.Loaders.Decorators;
//using HtmlElementsDotNet.HtmlElements.PageFactories.Selenium;

namespace ProofOfConcept.Pages
{
    public abstract partial class BasePage 
    {      
        public string BaseURL { get; set; }
        public RemoteWebDriver Driver { get; set; }
        public virtual string DefaultTitle { get { return ""; } }

        protected TPage GetInstance<TPage>(RemoteWebDriver driver = null) where TPage : BasePage, new()
        {
            return GetInstance<TPage>(driver ?? Driver, BaseURL);
        }

        protected static TPage GetInstance<TPage>(RemoteWebDriver driver, string baseUrl) where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                Driver = driver,
                BaseURL = baseUrl
            };
            //PageFactory.InitElements(new HtmlElementDecorator(driver), pageInstance);
            PageFactory.InitElements(driver, pageInstance);
            /*new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(5))
                                            .Until<OpenQA.Selenium.IWebElement>((d) =>
                                            {
                                                return d.FindElement(By.TagName("body"));
                                            });*/
            return pageInstance;
        }

        /// <summary>
        /// Asserts that the current page is of the given type
        /// </summary>
        public void Is<TPage>() where TPage : BasePage, new()
        {
            if (!(this is TPage))
            {
                throw new AssertionException(String.Format("Page Type Mismatch: Current page is not a '{0}'", typeof(TPage).Name));
            }
        }

        /// <summary>
        /// Inline cast to the given page type
        /// </summary>
        public TPage As<TPage>() where TPage : BasePage, new()
        {
            return GetInstance<TPage>(Driver);
        }
    }
}
