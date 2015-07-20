using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using ProofOfConcept.Pages;
using System;
using TechTalk.SpecFlow;

namespace ProofOfConcept.Tests
{
    [Binding]
    public class LoginTestSteps : BaseFeature
    {
        private LoginPage loginPage;

        [Given(@"I open ""(.*)""")]
        public void GivenIOpen(string URL)
        {
            loginPage = BasePage.NavigateToMailRUPage(CurrentDriver, URL);
            CurrentPage = loginPage;
        }

        [Given(@"I don't see ""(.*)""")]
        [Then(@"I don't see ""(.*)""")]
        public void GivenIDonTSee(string WebElementName)
        {
            if ("User eMail Text".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                Assert.IsFalse(CurrentPage.isMailTextPresent(), "Element with locator " + WebElementName
                        + " found, but should not be present!");
            }
        }

        [When(@"I type ""(.*)"" into ""(.*)""")]
        public void WhenITypeInto(string Text, string WebElementName)
        {
            if ("Password Field".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                loginPage.password.SendKeys(Text);
            }
            else if ("Login Part Field".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                loginPage.loginPart.Clear();
                loginPage.loginPart.SendKeys(Text);
            }
        }

        [When(@"I select ""(.*)"" into ""(.*)""")]
        public void WhenISelectInto(string Text, string WebElementName)
        {
            if ("Domain Part Select".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                //new Select(loginScreen.domainPart).selectByVisibleText(text);
                SelectElement selector = new SelectElement(loginPage.domainPart);
                selector.SelectByText(Text);
                //CurrentPage.As<LoginPage>().domainPart.SelectByText(Text);
            }
        }

        [When(@"I click ""(.*)""")]
        public void WhenIClick(string WebElementName)
        {
            if ("Login Button".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                loginPage.loginButton.Click();
                //System.Diagnostics.Debugger.Launch();
                System.Threading.Thread.Sleep(5000);
                NextPage = CurrentPage.As<MailboxHomePage>();                
            }
        }

        [Then(@"I see ""(.*)""")]
        public void ThenISee(string WebElementName)
        {

            if ("User eMail Text".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                Assert.IsTrue(CurrentPage.isMailTextPresent(), "Element with locator " + WebElementName
                        + "was NOT found, but should be present!");
            }
        }
    }
}
