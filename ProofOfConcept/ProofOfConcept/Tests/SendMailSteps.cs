using System;
using TechTalk.SpecFlow;
using ProofOfConcept.Pages;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace ProofOfConcept.Tests
{
    [Binding]
    public class SendMailSteps : BaseFeature
    {
        private LoginPage loginPage;

        [Given(@"Пользователь открывает ""(.*)""")]
        public void ДопустимПользовательОткрывает(string URL)
        {
            loginPage = BasePage.NavigateToMailRUPage(CurrentDriver, URL);
            CurrentPage = loginPage;
        }
        
        [Given(@"Пользователь не видит сообщение ""(.*)""")]
        [Then(@"Пользователь не видит сообщение ""(.*)""")]
        public void ДопустимПользовательНеВидитСообщение(string WebElementName)
        {
            if ("User eMail Text".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                Assert.IsFalse(CurrentPage.isMailTextPresent(), "Element with locator " + WebElementName
                        + " found, but should not be present!");
            }
        }
        

        [When(@"Пользователь заполняет ""(.*)"" в поле ""(.*)""")]
        public void ЕслиПользовательЗаполняетВПоле(string Text, string WebElementName)
        {
            if ("Password Field".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                loginPage.loginPart.Clear();
                loginPage.password.SendKeys(Text);
            }
            else if ("Login Part Field".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                loginPage.loginPart.Clear();
                loginPage.loginPart.SendKeys(Text);
            }
        }
        
        [When(@"Пользователь нажимает ""(.*)""")]
        [Then(@"Пользователь нажимает ""(.*)""")]
        public void ЕслиПользовательНажимает(string WebElementName)
        {
            if ("Login Button".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                loginPage.loginButton.Click();
                //System.Diagnostics.Debugger.Launch();
                System.Threading.Thread.Sleep(5000);
                NextPage = CurrentPage.As<MailboxHomePageNikita>();
            }
            else if ("Написать письмо (N)".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                
            }
        }

        [Then(@"Пользователь видит сообщение ""(.*)""")]
        [Given(@"Пользователь видит сообщение ""(.*)""")]
        public void ТоПользовательВидитСообщение(string WebElementName)
        {
            if ("User eMail Text".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                Assert.IsTrue(CurrentPage.isMailTextPresent(), "Element with locator " + WebElementName
                        + "was NOT found, but should be present!");
            }
        }

        [When(@"Пользователь выбирает ""(.*)"" в поле ""(.*)""")]
        public void ЕслиПользовательВыбираетВПоле(string Text, string WebElementName)
        {
            if ("Domain Part Select".Equals(WebElementName, StringComparison.InvariantCultureIgnoreCase))
            {
                //new Select(loginScreen.domainPart).selectByVisibleText(text);
                SelectElement selector = new SelectElement(loginPage.domainPart);
                selector.SelectByText(Text);
                //CurrentPage.As<LoginPage>().domainPart.SelectByText(Text);
            }
        }
    }
}
