﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomationReqnrollProject.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Alerts")]
    [NUnit.Framework.CategoryAttribute("Alerts")]
    public partial class AlertsFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "Alerts"};
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Alerts", "This feature file covers the Alert scenarios", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "Alerts.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 5
  #line hidden
#line 6
    await testRunner.GivenAsync("the user navigates to DemoQA home page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 7
    await testRunner.AndAsync("the user selects the Alerts, Frame & Windows from the menu", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 8
    await testRunner.AndAsync("the user selects Alerts from the sub-menu", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC423459 Verify alert text for \"Click Button to see alert\" alert")]
        public async System.Threading.Tasks.Task TC423459VerifyAlertTextForClickButtonToSeeAlertAlert()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC423459 Verify alert text for \"Click Button to see alert\" alert", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
  await this.FeatureBackgroundAsync();
#line hidden
#line 11
    await testRunner.WhenAsync("the user opens the regular alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 12
    await testRunner.ThenAsync("an alert is displayed with the text \"You clicked a button\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 13
    await testRunner.WhenAsync("the user accepts the alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 14
    await testRunner.ThenAsync("the alert is no longer visible", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC523459 Verify alert text when it appeares after 5 seconds")]
        public async System.Threading.Tasks.Task TC523459VerifyAlertTextWhenItAppearesAfter5Seconds()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC523459 Verify alert text when it appeares after 5 seconds", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 16
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
  await this.FeatureBackgroundAsync();
#line hidden
#line 17
    await testRunner.WhenAsync("the user opens the delayed alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 18
    await testRunner.ThenAsync("delayed alert is displayed with the text \"This alert appeared after 5 seconds\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 19
    await testRunner.WhenAsync("the user accepts the alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 20
    await testRunner.ThenAsync("the alert is no longer visible", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC623459 Verify cancel action for confirm box")]
        public async System.Threading.Tasks.Task TC623459VerifyCancelActionForConfirmBox()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC623459 Verify cancel action for confirm box", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
  await this.FeatureBackgroundAsync();
#line hidden
#line 23
    await testRunner.WhenAsync("the user opens the confirm box", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 24
    await testRunner.ThenAsync("an alert is displayed with the text \"Do you confirm action?\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 25
    await testRunner.WhenAsync("the user cancels the alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 26
    await testRunner.ThenAsync("the alert is no longer visible", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 27
    await testRunner.AndAsync("\"You selected Cancel\" message is displayed", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC723459 Verify prompt")]
        public async System.Threading.Tasks.Task TC723459VerifyPrompt()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC723459 Verify prompt", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 29
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
  await this.FeatureBackgroundAsync();
#line hidden
#line 30
    await testRunner.WhenAsync("the user opens the prompt box", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 31
    await testRunner.ThenAsync("an alert is displayed with the text \"Please enter your name\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 32
    await testRunner.WhenAsync("the user enters the name \"Kishan Patel\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 33
    await testRunner.AndAsync("the user accepts the alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 34
    await testRunner.ThenAsync("\"You entered Kishan Patel\" message is displayed", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
