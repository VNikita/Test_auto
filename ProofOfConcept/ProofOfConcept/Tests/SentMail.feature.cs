﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ProofOfConcept.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SendMail")]
    [NUnit.Framework.CategoryAttribute("Test")]
    public partial class SendMailFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SentMail.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru-RU"), "SendMail", "", ProgrammingLanguage.CSharp, new string[] {
                        "Test"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
 #line 6
  testRunner.Given("Пользователь открывает \"http://www.mail.ru\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login")]
        public virtual void Login()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login", ((string[])(null)));
#line 8
 this.ScenarioSetup(scenarioInfo);
#line 5
 this.FeatureBackground();
#line 9
  testRunner.Given("Пользователь не видит сообщение \"User eMail Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line 10
  testRunner.When("Пользователь заполняет \"nikita.varchenko\" в поле \"Login Part Field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Если ");
#line 11
  testRunner.And("Пользователь выбирает \"@inbox.ru\" в поле \"Domain\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 12
  testRunner.And("Пользователь заполняет \"NKapIM2015g\" в поле \"Password Field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 13
  testRunner.And("Пользователь нажимает \"Login Button\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 14
  testRunner.Then("Пользователь видит сообщение \"User eMail Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "То ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Send")]
        public virtual void Send()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send", ((string[])(null)));
#line 16
 this.ScenarioSetup(scenarioInfo);
#line 5
 this.FeatureBackground();
#line 17
  testRunner.Given("Пользователь видит сообщение \"User eMail Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line 18
  testRunner.When("Пользователь нажимает \"Написать письмо (N)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Если ");
#line 19
  testRunner.And("Пользователь заполняет \"vnvkap@gmail.co\" в поле \"To\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 20
  testRunner.And("Пользователь заполняет \"Test\" в поле \"Subject\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 21
  testRunner.And("Пользователь заполняет \"Test\" в поле \"Momo\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 22
  testRunner.And("Пользователь нажимает \"Sent Button\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 23
  testRunner.Then("Пользователь видит сообщение \"User sent Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "То ");
#line 24
  testRunner.And("Пользователь нажимает \"Inbox Button\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("check and Exit")]
        public virtual void CheckAndExit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("check and Exit", ((string[])(null)));
#line 26
 this.ScenarioSetup(scenarioInfo);
#line 5
 this.FeatureBackground();
#line 27
  testRunner.Given("Пользователь видит сообщение \"Text Subject mail\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line 28
  testRunner.When("Пользователь нажимает \"Exit Button\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Если ");
#line 29
  testRunner.Then("Пользователь не видит сообщение \"User eMail Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "То ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
