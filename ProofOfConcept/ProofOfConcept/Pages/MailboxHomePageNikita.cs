using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;
using HtmlElementsDotNet.HtmlElements.Elements;

namespace ProofOfConcept.Pages
{
    [Binding]
    public class MailboxHomePageNikita : BasePage
    {
        public override string DefaultTitle { get { return "Входящие - nikita.varchenko@mail.ru - Почта Mail.Ru"; } }

        [FindsBy(How = How.PartialLinkText, Using = "выход")]
        public IWebElement ExitLink { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Написать письмо (N)")]
        public IWebElement SetLink { get; set; }

    }
}
