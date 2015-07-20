using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ProofOfConcept.Pages;
using OpenQA.Selenium.Remote;

namespace ProofOfConcept.Tests
{
    [Binding]
    public class MailSteps : BaseFeature
    {
        private MailboxHomePage mailboxHomePage;


        [Then(@"I exit")]
        public void ThenIExit()
        {
            mailboxHomePage = CurrentPage.As<MailboxHomePage>();
            mailboxHomePage.ExitLink.Click();
        }

    }
}
