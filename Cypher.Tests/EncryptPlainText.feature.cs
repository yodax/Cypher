﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Cypher.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Encrypt Plain Text")]
    public partial class EncryptPlainTextFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EncryptPlainText.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Encrypt Plain Text", @"
As a privacy nut I would like to encrypt text in the worst possible way by using a substitution cypher

The cypher will replace each letter with another letter. Each letter will be used exactly once.

My plain and text will be case insensitive and punctuation marks will not be encrypted", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A simple plain text using all letters from the alphabet")]
        public virtual void ASimplePlainTextUsingAllLettersFromTheAlphabet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A simple plain text using all letters from the alphabet", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 10
 testRunner.Given("the plain text", "the quick brown fox jumps over the lazy dog", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Plain text letter",
                        "Cypher text letter"});
            table1.AddRow(new string[] {
                        "A",
                        "B"});
            table1.AddRow(new string[] {
                        "B",
                        "C"});
            table1.AddRow(new string[] {
                        "C",
                        "D"});
            table1.AddRow(new string[] {
                        "D",
                        "E"});
            table1.AddRow(new string[] {
                        "E",
                        "F"});
            table1.AddRow(new string[] {
                        "F",
                        "G"});
            table1.AddRow(new string[] {
                        "G",
                        "H"});
            table1.AddRow(new string[] {
                        "H",
                        "I"});
            table1.AddRow(new string[] {
                        "I",
                        "J"});
            table1.AddRow(new string[] {
                        "J",
                        "K"});
            table1.AddRow(new string[] {
                        "K",
                        "L"});
            table1.AddRow(new string[] {
                        "L",
                        "M"});
            table1.AddRow(new string[] {
                        "M",
                        "N"});
            table1.AddRow(new string[] {
                        "N",
                        "O"});
            table1.AddRow(new string[] {
                        "O",
                        "P"});
            table1.AddRow(new string[] {
                        "P",
                        "Q"});
            table1.AddRow(new string[] {
                        "Q",
                        "R"});
            table1.AddRow(new string[] {
                        "R",
                        "S"});
            table1.AddRow(new string[] {
                        "S",
                        "T"});
            table1.AddRow(new string[] {
                        "T",
                        "U"});
            table1.AddRow(new string[] {
                        "U",
                        "V"});
            table1.AddRow(new string[] {
                        "V",
                        "W"});
            table1.AddRow(new string[] {
                        "W",
                        "X"});
            table1.AddRow(new string[] {
                        "X",
                        "Y"});
            table1.AddRow(new string[] {
                        "Y",
                        "Z"});
            table1.AddRow(new string[] {
                        "Z",
                        "A"});
#line 14
 testRunner.When("I encrypt the text using the following letter substitution", ((string)(null)), table1, "When ");
#line hidden
#line 42
 testRunner.Then("the cypher text should be", "UIF RVJDL CSPXO GPY KVNQT PWFS UIF MBAZ EPH", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
