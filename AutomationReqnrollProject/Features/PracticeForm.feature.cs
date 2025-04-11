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
    [NUnit.Framework.DescriptionAttribute("PracticeForm")]
    public partial class PracticeFormFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "PracticeForm", "To test Practice Form", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "PracticeForm.feature"
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC:123459 Verify Practice Form submission")]
        public async System.Threading.Tasks.Task TC123459VerifyPracticeFormSubmission()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC:123459 Verify Practice Form submission", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
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
 await testRunner.WhenAsync("user navigates to the practice form page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "Field",
                            "Value"});
                table1.AddRow(new string[] {
                            "First Name",
                            "Kishan"});
                table1.AddRow(new string[] {
                            "Last Name",
                            "Patel"});
                table1.AddRow(new string[] {
                            "Email",
                            "kcpatel07150715@gmail.com"});
                table1.AddRow(new string[] {
                            "Gender",
                            "Female"});
                table1.AddRow(new string[] {
                            "Mobile",
                            "5879735451"});
                table1.AddRow(new string[] {
                            "Subjects",
                            "Automation"});
                table1.AddRow(new string[] {
                            "Hobbies",
                            "Reading"});
                table1.AddRow(new string[] {
                            "Picture",
                            "C:\\Users\\kisha\\Pictures\\Screenshots\\Kohli.png"});
                table1.AddRow(new string[] {
                            "Current Address",
                            "25 red sky"});
                table1.AddRow(new string[] {
                            "State",
                            "Haryana"});
                table1.AddRow(new string[] {
                            "City",
                            "Panipat"});
#line 6
 await testRunner.AndAsync("user enters following details:", ((string)(null)), table1, "And ");
#line hidden
#line 19
 await testRunner.AndAsync("user submits the form", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 20
 await testRunner.ThenAsync("form is submitted successfully", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table2 = new global::Reqnroll.Table(new string[] {
                            "Field",
                            "Value"});
                table2.AddRow(new string[] {
                            "First Name",
                            "Kishan"});
                table2.AddRow(new string[] {
                            "Last Name",
                            "Patel"});
                table2.AddRow(new string[] {
                            "Email",
                            "kcpatel07150715@gmail.com"});
                table2.AddRow(new string[] {
                            "Gender",
                            "Female"});
                table2.AddRow(new string[] {
                            "Mobile",
                            "5879735451"});
                table2.AddRow(new string[] {
                            "Subjects",
                            "Automation"});
                table2.AddRow(new string[] {
                            "Hobbies",
                            "Reading"});
                table2.AddRow(new string[] {
                            "Picture",
                            "Kohli.png"});
                table2.AddRow(new string[] {
                            "Current Address",
                            "25 red sky"});
                table2.AddRow(new string[] {
                            "State",
                            "Haryana"});
                table2.AddRow(new string[] {
                            "City",
                            "Panipat"});
#line 21
 await testRunner.AndAsync("following details are displayed", ((string)(null)), table2, "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC:223459 Verify button gets visible after 5 seconds")]
        public async System.Threading.Tasks.Task TC223459VerifyButtonGetsVisibleAfter5Seconds()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC:223459 Verify button gets visible after 5 seconds", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 36
  await testRunner.WhenAsync("user navigates to the Dynamic Properties page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 37
     await testRunner.ThenAsync("after 5 seconds, button is visible", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC:323459 Verify button gets enabled after 5 seconds")]
        public async System.Threading.Tasks.Task TC323459VerifyButtonGetsEnabledAfter5Seconds()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC:323459 Verify button gets enabled after 5 seconds", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 40
  await testRunner.WhenAsync("user navigates to the Dynamic Properties page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 41
     await testRunner.ThenAsync("after 5 seconds, button is enabled", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC:423459 Verify alert")]
        public async System.Threading.Tasks.Task TC423459VerifyAlert()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC:423459 Verify alert", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 44
  await testRunner.WhenAsync("user navigates to the Alerts, Frame & Windows page page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 45
  await testRunner.AndAsync("user clicks on button to see alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 46
     await testRunner.ThenAsync("alert is displayed with text \"You clicked a button\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 47
  await testRunner.WhenAsync("user accepts the alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 48
  await testRunner.ThenAsync("alert is disappeared", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC:523459 Verify alert appeares after 5 seconds")]
        public async System.Threading.Tasks.Task TC523459VerifyAlertAppearesAfter5Seconds()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC:523459 Verify alert appeares after 5 seconds", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 50
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 51
  await testRunner.WhenAsync("user navigates to the Alerts, Frame & Windows page page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 52
  await testRunner.AndAsync("user clicks on button to see delayed alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 53
     await testRunner.ThenAsync("delayed alert is displayed with text \"This alert appeared after 5 seconds\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 54
  await testRunner.WhenAsync("user accepts the alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 55
  await testRunner.ThenAsync("alert is disappeared", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC:623459 Verify cancel action for confirm box")]
        public async System.Threading.Tasks.Task TC623459VerifyCancelActionForConfirmBox()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC:623459 Verify cancel action for confirm box", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 57
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 58
  await testRunner.WhenAsync("user navigates to the Alerts, Frame & Windows page page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 59
  await testRunner.AndAsync("user clicks on button to see confirm box", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 60
  await testRunner.ThenAsync("alert is displayed with text \"Do you confirm action?\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 61
  await testRunner.WhenAsync("user cancels the alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 62
  await testRunner.ThenAsync("alert is disappeared", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 63
  await testRunner.AndAsync("\"You selected Cancel\" message is displayed", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC:723459 Verify prompt alert")]
        public async System.Threading.Tasks.Task TC723459VerifyPromptAlert()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TC:723459 Verify prompt alert", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 65
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 66
  await testRunner.WhenAsync("user navigates to the Alerts, Frame & Windows page page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 67
  await testRunner.AndAsync("user clicks on button to see prompt box", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 68
  await testRunner.ThenAsync("alert is displayed with text \"Please enter your name\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 69
  await testRunner.WhenAsync("user enters the name \"Kishan Patel\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 70
  await testRunner.AndAsync("user accepts the alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 71
  await testRunner.ThenAsync("\"You entered Kishan Patel\" message is displayed", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
