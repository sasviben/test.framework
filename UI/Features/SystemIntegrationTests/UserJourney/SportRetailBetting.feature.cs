﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UI.Features.SystemIntegrationTests.UserJourney
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Sport Retail Betting")]
    public partial class SportRetailBettingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "SportRetailBetting.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SystemIntegrationTests/UserJourney", "Sport Retail Betting", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the player should be able to purchase a Prematch simple ticket (uid:85527a0b-49ee" +
            "-4ec6-aa85-d4fe709980e3)")]
        [NUnit.Framework.CategoryAttribute("RULES_automation_todo")]
        [NUnit.Framework.CategoryAttribute("regression")]
        [NUnit.Framework.CategoryAttribute("acceptance")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void ThePlayerShouldBeAbleToPurchaseAPrematchSimpleTicketUid85527A0B_49Ee_4Ec6_Aa85_D4Fe709980E3()
        {
            string[] tagsOfScenario = new string[] {
                    "RULES_automation_todo",
                    "regression",
                    "acceptance",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the player should be able to purchase a Prematch simple ticket (uid:85527a0b-49ee" +
                    "-4ec6-aa85-d4fe709980e3)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
    testRunner.Given("the player has added \"3\" random \"PREMATCH\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
    testRunner.When("the player purchases an \"AGENCY\" sport \"SIMPLE\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
    testRunner.Then("the \"AGENCY\" sport \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the player should be able to purchase a Prematch system ticket (uid:ce19e99a-8ac9" +
            "-4754-b50f-a09d29929dd5)")]
        [NUnit.Framework.CategoryAttribute("RULES_automation_todo")]
        [NUnit.Framework.CategoryAttribute("regression")]
        [NUnit.Framework.CategoryAttribute("acceptance")]
        public virtual void ThePlayerShouldBeAbleToPurchaseAPrematchSystemTicketUidCe19E99A_8Ac9_4754_B50F_A09D29929Dd5()
        {
            string[] tagsOfScenario = new string[] {
                    "RULES_automation_todo",
                    "regression",
                    "acceptance"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the player should be able to purchase a Prematch system ticket (uid:ce19e99a-8ac9" +
                    "-4754-b50f-a09d29929dd5)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 11
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 12
    testRunner.Given("the player has added \"3\" random \"PREMATCH\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
    testRunner.When("the player selects \"1/3,3/3\" combinations on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
    testRunner.And("the player purchases an \"AGENCY\" sport \"SYSTEM\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
    testRunner.Then("the \"AGENCY\" sport \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the player should see the same data on the purchased mix simple ticket (Prematch " +
            "and Inplay) as on the Betslip (uid:75539c07-f40a-4dbb-aec1-04916528828d)")]
        [NUnit.Framework.CategoryAttribute("RULES_automation_todo")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void ThePlayerShouldSeeTheSameDataOnThePurchasedMixSimpleTicketPrematchAndInplayAsOnTheBetslipUid75539C07_F40A_4Dbb_Aec1_04916528828D()
        {
            string[] tagsOfScenario = new string[] {
                    "RULES_automation_todo",
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the player should see the same data on the purchased mix simple ticket (Prematch " +
                    "and Inplay) as on the Betslip (uid:75539c07-f40a-4dbb-aec1-04916528828d)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
    testRunner.Given("the player has added \"3\" random \"PREMATCH\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
    testRunner.And("the player has added \"1\" random \"SPECIAL\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
    testRunner.When("the player purchases an \"AGENCY\" sport \"SIMPLE\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
    testRunner.Then("the \"AGENCY\" sport \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
    testRunner.And("the data on the \"DETAILS\" is the same as data on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the player should see the same data on the purchased mix system ticket (Prematch " +
            "and Inplay) as on the Betslip (uid:f635f301-1b16-4797-bc0a-95488466e643)")]
        [NUnit.Framework.CategoryAttribute("RULES_automation_todo")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void ThePlayerShouldSeeTheSameDataOnThePurchasedMixSystemTicketPrematchAndInplayAsOnTheBetslipUidF635F301_1B16_4797_Bc0A_95488466E643()
        {
            string[] tagsOfScenario = new string[] {
                    "RULES_automation_todo",
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the player should see the same data on the purchased mix system ticket (Prematch " +
                    "and Inplay) as on the Betslip (uid:f635f301-1b16-4797-bc0a-95488466e643)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 26
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 27
    testRunner.Given("the player has added \"3\" random \"PREMATCH\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
    testRunner.And("the player has added \"1\" random \"SPECIAL\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
    testRunner.When("the player selects \"1/4,4/4\" combinations on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
    testRunner.And("the player purchases an \"AGENCY\" sport \"SYSTEM\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
    testRunner.Then("the \"AGENCY\" sport \"SYSTEM\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
    testRunner.And("the data on the \"DETAILS\" is the same as data on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the player should be able to purchase a mix Prematch and Special simple ticket (u" +
            "id:f6dea336-be0b-4bab-a8fb-f98d1806fce9)")]
        [NUnit.Framework.CategoryAttribute("RULES_automation_todo")]
        [NUnit.Framework.CategoryAttribute("regression")]
        [NUnit.Framework.CategoryAttribute("acceptance")]
        public virtual void ThePlayerShouldBeAbleToPurchaseAMixPrematchAndSpecialSimpleTicketUidF6Dea336_Be0B_4Bab_A8Fb_F98D1806Fce9()
        {
            string[] tagsOfScenario = new string[] {
                    "RULES_automation_todo",
                    "regression",
                    "acceptance"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the player should be able to purchase a mix Prematch and Special simple ticket (u" +
                    "id:f6dea336-be0b-4bab-a8fb-f98d1806fce9)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 35
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 36
    testRunner.Given("the player has added \"3\" random \"PREMATCH\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 37
    testRunner.And("the player has added \"1\" random \"SPECIAL\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
    testRunner.When("the player purchases an \"AGENCY\" sport \"SIMPLE\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
    testRunner.Then("the \"AGENCY\" sport \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the player should be able to purchase a mix Prematch and Special system ticket (u" +
            "id:9ae84377-0788-44b9-a71d-1a4f92946d3d)")]
        [NUnit.Framework.CategoryAttribute("RULES_automation_todo")]
        [NUnit.Framework.CategoryAttribute("regression")]
        [NUnit.Framework.CategoryAttribute("acceptance")]
        public virtual void ThePlayerShouldBeAbleToPurchaseAMixPrematchAndSpecialSystemTicketUid9Ae84377_0788_44B9_A71D_1A4F92946D3D()
        {
            string[] tagsOfScenario = new string[] {
                    "RULES_automation_todo",
                    "regression",
                    "acceptance"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the player should be able to purchase a mix Prematch and Special system ticket (u" +
                    "id:9ae84377-0788-44b9-a71d-1a4f92946d3d)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 43
    testRunner.Given("the player has added \"3\" random \"PREMATCH\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
    testRunner.And("the player has added \"1\" random \"SPECIAL\" \"FOOTBALL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
    testRunner.When("the player selects \"1/4,4/4\" combinations on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
    testRunner.And("the player purchases an \"AGENCY\" sport \"SYSTEM\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
    testRunner.Then("the \"AGENCY\" sport \"SYSTEM\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
