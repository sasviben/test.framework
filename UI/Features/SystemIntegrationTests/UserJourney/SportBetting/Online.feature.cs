﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UI.Features.SystemIntegrationTests.UserJourney.SportBetting
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Online")]
    public partial class OnlineFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Online.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SystemIntegrationTests/UserJourney/SportBetting", "Online", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("the online player should see the same data on the purchased mix simple ticket (Pr" +
            "ematch and Inplay) as on the Betslip (uid:26191d71-2c14-41e6-9eaa-d9b4abaeda8d)")]
        public virtual void TheOnlinePlayerShouldSeeTheSameDataOnThePurchasedMixSimpleTicketPrematchAndInplayAsOnTheBetslipUid26191D71_2C14_41E6_9Eaa_D9B4Abaeda8D()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should see the same data on the purchased mix simple ticket (Pr" +
                    "ematch and Inplay) as on the Betslip (uid:26191d71-2c14-41e6-9eaa-d9b4abaeda8d)", null, tagsOfScenario, argumentsOfScenario);
#line 4
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
#line 5
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
    testRunner.And("the player has added \"1\" random \"INPLAY\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
    testRunner.When("the player purchases an \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 10
    testRunner.And("the data on the \"WIDGET\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
    testRunner.And("the data on the \"DETAILS\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should see the same data on the purchased mix system ticket (Pr" +
            "ematch and Inplay) as on the Betslip (uid:7904074b-2161-47ea-9c5a-d7b0c3b0b2b3)")]
        public virtual void TheOnlinePlayerShouldSeeTheSameDataOnThePurchasedMixSystemTicketPrematchAndInplayAsOnTheBetslipUid7904074B_2161_47Ea_9C5A_D7B0C3B0B2B3()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should see the same data on the purchased mix system ticket (Pr" +
                    "ematch and Inplay) as on the Betslip (uid:7904074b-2161-47ea-9c5a-d7b0c3b0b2b3)", null, tagsOfScenario, argumentsOfScenario);
#line 13
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
#line 14
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
    testRunner.And("the player has added \"1\" random \"INPLAY\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
    testRunner.When("the player selects \"1/4,4/4\" combinations on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
    testRunner.And("the player purchases an \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
    testRunner.And("the data on the \"WIDGET\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
    testRunner.And("the data on the \"DETAILS\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should see the same data on the purchased mix simple ticket (Pr" +
            "ematch and Special) as on the Betslip (uid:2d2f33dc-0fe3-4ad3-845a-6d287c12c739)" +
            "")]
        public virtual void TheOnlinePlayerShouldSeeTheSameDataOnThePurchasedMixSimpleTicketPrematchAndSpecialAsOnTheBetslipUid2D2F33Dc_0Fe3_4Ad3_845A_6D287C12C739()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should see the same data on the purchased mix simple ticket (Pr" +
                    "ematch and Special) as on the Betslip (uid:2d2f33dc-0fe3-4ad3-845a-6d287c12c739)" +
                    "", null, tagsOfScenario, argumentsOfScenario);
#line 23
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
#line 24
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 25
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
    testRunner.And("the player has added \"1\" random \"SPECIAL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
    testRunner.When("the player purchases an \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
    testRunner.And("the data on the \"WIDGET\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
    testRunner.And("the data on the \"DETAILS\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should see the same data on the purchased mix system ticket (Pr" +
            "ematch and Special) as on the Betslip (uid:baa3fd63-cbfb-46e3-8503-38d4c75d2b16)" +
            "")]
        public virtual void TheOnlinePlayerShouldSeeTheSameDataOnThePurchasedMixSystemTicketPrematchAndSpecialAsOnTheBetslipUidBaa3Fd63_Cbfb_46E3_8503_38D4C75D2B16()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should see the same data on the purchased mix system ticket (Pr" +
                    "ematch and Special) as on the Betslip (uid:baa3fd63-cbfb-46e3-8503-38d4c75d2b16)" +
                    "", null, tagsOfScenario, argumentsOfScenario);
#line 32
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
#line 33
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
    testRunner.And("the player has added \"1\" random \"SPECIAL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
    testRunner.When("the player selects \"1/4,4/4\" combinations on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
    testRunner.And("the player purchases an \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
    testRunner.And("the data on the \"WIDGET\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
    testRunner.And("the data on the \"DETAILS\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should see the same data on the purchased mix simple ticket (Pr" +
            "ematch, Inplay and Special) as on the Betslip (uid:ab7ea004-1e19-4926-9b82-76332" +
            "0f2585d)")]
        public virtual void TheOnlinePlayerShouldSeeTheSameDataOnThePurchasedMixSimpleTicketPrematchInplayAndSpecialAsOnTheBetslipUidAb7Ea004_1E19_4926_9B82_763320F2585D()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should see the same data on the purchased mix simple ticket (Pr" +
                    "ematch, Inplay and Special) as on the Betslip (uid:ab7ea004-1e19-4926-9b82-76332" +
                    "0f2585d)", null, tagsOfScenario, argumentsOfScenario);
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
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
    testRunner.And("the player has added \"1\" random \"SPECIAL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
    testRunner.And("the player has added \"1\" random \"INPLAY\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
    testRunner.When("the player purchases an \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
    testRunner.And("the data on the \"WIDGET\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
    testRunner.And("the data on the \"DETAILS\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
    testRunner.And("the player balance amount is subtracted by the \"SPORT\" ticket stake", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should see the same data on the purchased mix system ticket (Pr" +
            "ematch, Inplay and Special) as on the Betslip (uid:62b4880a-4ae2-46e1-a060-d53d4" +
            "e048bb2)")]
        public virtual void TheOnlinePlayerShouldSeeTheSameDataOnThePurchasedMixSystemTicketPrematchInplayAndSpecialAsOnTheBetslipUid62B4880A_4Ae2_46E1_A060_D53D4E048Bb2()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should see the same data on the purchased mix system ticket (Pr" +
                    "ematch, Inplay and Special) as on the Betslip (uid:62b4880a-4ae2-46e1-a060-d53d4" +
                    "e048bb2)", null, tagsOfScenario, argumentsOfScenario);
#line 53
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
#line 54
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 55
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
    testRunner.And("the player has added \"1\" random \"SPECIAL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
    testRunner.And("the player has added \"1\" random \"INPLAY\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
    testRunner.When("the player selects \"1/5,5/5\" combinations on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
    testRunner.And("the player purchases an \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
    testRunner.And("the data on the \"WIDGET\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
    testRunner.And("the data on the \"DETAILS\" is the same as data on the \"SPORT\" Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should be able to purchase a Prematch simple ticket (uid:702fa3" +
            "51-1eec-4f31-9462-6681ce503ec9)")]
        public virtual void TheOnlinePlayerShouldBeAbleToPurchaseAPrematchSimpleTicketUid702Fa351_1Eec_4F31_9462_6681Ce503Ec9()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should be able to purchase a Prematch simple ticket (uid:702fa3" +
                    "51-1eec-4f31-9462-6681ce503ec9)", null, tagsOfScenario, argumentsOfScenario);
#line 64
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
#line 65
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 66
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
    testRunner.When("the player purchases an \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
    testRunner.And("the player balance amount is subtracted by the \"SPORT\" ticket stake", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should be able to purchase a Prematch system ticket (uid:b209f1" +
            "82-aa48-4216-b94c-ba99938b3039)")]
        public virtual void TheOnlinePlayerShouldBeAbleToPurchaseAPrematchSystemTicketUidB209F182_Aa48_4216_B94C_Ba99938B3039()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should be able to purchase a Prematch system ticket (uid:b209f1" +
                    "82-aa48-4216-b94c-ba99938b3039)", null, tagsOfScenario, argumentsOfScenario);
#line 71
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
#line 72
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 73
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
    testRunner.When("the player selects \"1/3,3/3\" combinations on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
    testRunner.And("the player purchases an \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
    testRunner.And("the player balance amount is subtracted by the \"SPORT\" ticket stake", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should be able to purchase a Inplay simple ticket (uid:fd9acb02" +
            "-c293-4bdc-a815-ab39bebfe329)")]
        public virtual void TheOnlinePlayerShouldBeAbleToPurchaseAInplaySimpleTicketUidFd9Acb02_C293_4Bdc_A815_Ab39Bebfe329()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should be able to purchase a Inplay simple ticket (uid:fd9acb02" +
                    "-c293-4bdc-a815-ab39bebfe329)", null, tagsOfScenario, argumentsOfScenario);
#line 79
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
#line 80
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 81
    testRunner.And("the player has added \"1\" random \"INPLAY\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
    testRunner.When("the player purchases an \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
    testRunner.And("the player balance amount is subtracted by the \"SPORT\" ticket stake", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should be able to purchase a Inplay system ticket (uid:bfc8dcc2" +
            "-e047-4f67-9d66-3534edf38404)")]
        public virtual void TheOnlinePlayerShouldBeAbleToPurchaseAInplaySystemTicketUidBfc8Dcc2_E047_4F67_9D66_3534Edf38404()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should be able to purchase a Inplay system ticket (uid:bfc8dcc2" +
                    "-e047-4f67-9d66-3534edf38404)", null, tagsOfScenario, argumentsOfScenario);
#line 86
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
#line 87
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 88
    testRunner.And("the player has added \"3\" random \"INPLAY\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
    testRunner.When("the player selects \"1/3,3/3\" combinations on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
    testRunner.And("the player purchases an \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 92
    testRunner.And("the player balance amount is subtracted by the \"SPORT\" ticket stake", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should be able to purchase a mix Prematch, Inplay and Special s" +
            "imple ticket (uid:0d465d5b-0288-4161-afad-54fe9077b487)")]
        public virtual void TheOnlinePlayerShouldBeAbleToPurchaseAMixPrematchInplayAndSpecialSimpleTicketUid0D465D5B_0288_4161_Afad_54Fe9077B487()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should be able to purchase a mix Prematch, Inplay and Special s" +
                    "imple ticket (uid:0d465d5b-0288-4161-afad-54fe9077b487)", null, tagsOfScenario, argumentsOfScenario);
#line 94
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
#line 95
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 96
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
    testRunner.And("the player has added \"1\" random \"SPECIAL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
    testRunner.And("the player has added \"1\" random \"INPLAY\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
    testRunner.When("the player purchases an \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 100
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SIMPLE\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 101
    testRunner.And("the player balance amount is subtracted by the \"SPORT\" ticket stake", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("the online player should be able to purchase a mix Prematch, Inplay and Special s" +
            "ystem ticket (uid:515fbc3b-d92e-4e4e-8139-bf6f39911203)")]
        public virtual void TheOnlinePlayerShouldBeAbleToPurchaseAMixPrematchInplayAndSpecialSystemTicketUid515Fbc3B_D92E_4E4E_8139_Bf6F39911203()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("the online player should be able to purchase a mix Prematch, Inplay and Special s" +
                    "ystem ticket (uid:515fbc3b-d92e-4e4e-8139-bf6f39911203)", null, tagsOfScenario, argumentsOfScenario);
#line 103
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
#line 104
    testRunner.Given("the player is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 105
    testRunner.And("the player has added \"3\" random \"PREMATCH\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
    testRunner.And("the player has added \"1\" random \"SPECIAL\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
    testRunner.And("the player has added \"1\" random \"INPLAY\" events to the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 108
    testRunner.When("the player selects \"1/5,5/5\" combinations on the Betslip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
    testRunner.And("the player purchases an \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
    testRunner.Then("the \"ONLINE\" \"SPORT\" \"SYSTEM\" ticket is purchased", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 111
    testRunner.And("the player balance amount is subtracted by the \"SPORT\" ticket stake", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion