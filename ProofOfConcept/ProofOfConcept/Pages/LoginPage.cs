using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using HtmlElementsDotNet.HtmlElements.Elements;

namespace ProofOfConcept.Pages
{
    public class LoginPage : BasePage
    {
        public static string URL = "/";
        public override string DefaultTitle { get { return "Mail.Ru: почта, поиск в интернете, новости, игры"; } }

        [FindsBy(How = How.Id, Using = "mailbox__login")]
        public IWebElement loginPart { get; set; }

	    [FindsBy(How = How.Id, Using = "mailbox__login__domain")]
        public IWebElement domainPart { get; set; }

	    [FindsBy(How = How.Id, Using = "mailbox__password")]
        public IWebElement password { get; set; }

	    [FindsBy(How = How.Id, Using = "mailbox__auth__button")]
        public IWebElement loginButton { get; set; }

	    [FindsBy(How = How.Id, Using = "portal-menu__user-email")]
        public IWebElement userMailText { get; set; }
    }
}
