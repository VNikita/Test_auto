﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
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
    [NUnit.Framework.DescriptionAttribute("Login Test")]
    [NUnit.Framework.CategoryAttribute("Test")]
    public partial class LoginTestFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MailRu.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru-RU"), "Login Test", "", ProgrammingLanguage.CSharp, new string[] {
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
  testRunner.Given("I open \"http://www.mail.ru\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
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
  testRunner.Given("I don\'t see \"User eMail Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line 10
  testRunner.When("I type \"shaforost.olga\" into \"Login Part Field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Если ");
#line 11
  testRunner.And("I select \"@mail.ru\" into \"Domain\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 12
  testRunner.And("I type \"test_123\" into \"Password Field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 13
  testRunner.And("I click \"Login Button\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 14
  testRunner.Then("I see \"User eMail Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "То ");
#line 15
  testRunner.And("I exit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 16
  testRunner.And("I don\'t see \"User eMail Text\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
