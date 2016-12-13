﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Warewolf.UIBindingTests.Deploy
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DeployTabFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DeployTab.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DeployTab", "\tIn order to Deploy resource.\r\n\tAs a warewolf user\r\n\tI want to Deploy aresource f" +
                    "rom one server to another server.", ProgrammingLanguage.CSharp, new string[] {
                        "DeployTab"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "DeployTab")))
            {
                Warewolf.UIBindingTests.Deploy.DeployTabFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy Tab", new string[] {
                        "DeployTab"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
  testRunner.Then("I select Destination Server as \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
  testRunner.And("destination \"localhost\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
  testRunner.Then("\"Deploy\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
  testRunner.And("the validation message is \"Source and Destination cannot be the same.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy is successfull")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployIsSuccessfull()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy is successfull", new string[] {
                        "DeployTab"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
  testRunner.Then("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
  testRunner.When("I select \"Utility - Date and Time\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
  testRunner.And("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
  testRunner.And("the Deploy validation message is \"1 Resource Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conflicting resources on Source and Destination server")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void ConflictingResourcesOnSourceAndDestinationServer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conflicting resources on Source and Destination server", new string[] {
                        "DeployTab"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
  testRunner.Then("I select Destination Server as \"DestinationServer\" with SameName confilcts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
  testRunner.And("I select \"Control Flow - Sequence\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
  testRunner.When("I click Cancel on Resource exists in the destination server popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
  testRunner.And("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Source Resource",
                        "Destination Resource"});
            table1.AddRow(new string[] {
                        "1",
                        "Control Flow - Sequence",
                        "DifferentNameSameID"});
#line 57
  testRunner.Then("Resource exists in the destination server popup is shown", ((string)(null)), table1, "Then ");
#line 60
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
  testRunner.And("the Deploy validation message is \"1 Resource Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conflicting resources on Source and Destination server deploy is not successful")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void ConflictingResourcesOnSourceAndDestinationServerDeployIsNotSuccessful()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conflicting resources on Source and Destination server deploy is not successful", new string[] {
                        "DeployTab"});
#line 64
this.ScenarioSetup(scenarioInfo);
#line 65
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 66
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
  testRunner.When("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
  testRunner.Then("selected Destination Server is \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
  testRunner.And("I select \"bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
  testRunner.When("I click Cancel on Resource exists in the destination server popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
  testRunner.Then("deploy is not successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploying a connector with a source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployingAConnectorWithASource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploying a connector with a source", new string[] {
                        "DeployTab"});
#line 76
this.ScenarioSetup(scenarioInfo);
#line 77
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
  testRunner.When("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
  testRunner.Then("selected Destination Server is \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
  testRunner.And("Calculation is invoked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
  testRunner.Then("New Resource is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
  testRunner.When("I select \"FetchPlayers\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
  testRunner.Then("\"Deploy\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
  testRunner.And("Select All Dependencies is \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
  testRunner.When("I Select All Dependecies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
  testRunner.Then("I select \"DemoDB\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
  testRunner.And("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
  testRunner.And("the Deploy validation message is \"2 Resources Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Selected for deploy items type is showing on deploy tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void SelectedForDeployItemsTypeIsShowingOnDeployTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Selected for deploy items type is showing on deploy tab", new string[] {
                        "DeployTab"});
#line 95
this.ScenarioSetup(scenarioInfo);
#line 96
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
  testRunner.Then("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
  testRunner.When("selected Destination Server is \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
  testRunner.When("I select \"Utility - Date and Time\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
  testRunner.And("I select \"FetchPlayers\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
  testRunner.And("I select \"DemoDB\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
  testRunner.And("Calculation is invoked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
  testRunner.Then("Services is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
  testRunner.And("Sources is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy Summary is showing new and overiding resources")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeploySummaryIsShowingNewAndOveridingResources()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy Summary is showing new and overiding resources", new string[] {
                        "DeployTab"});
#line 110
this.ScenarioSetup(scenarioInfo);
#line 111
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 112
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
  testRunner.Then("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
  testRunner.When("selected Destination Server is \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
  testRunner.And("I select \"bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
  testRunner.And("Calculation is invoked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
  testRunner.Then("New Resource is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
  testRunner.And("Override is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
  testRunner.When("I select \"FetchPlayers\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
  testRunner.Then("New Resource is \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
  testRunner.And("Override is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
  testRunner.When("I Unselect \"bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
  testRunner.Then("Override is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploying items from one server to the next with the same name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployingItemsFromOneServerToTheNextWithTheSameName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploying items from one server to the next with the same name", new string[] {
                        "DeployTab"});
#line 129
this.ScenarioSetup(scenarioInfo);
#line 130
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 131
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
  testRunner.Then("I select Destination Server as \"DestinationServer\" with SameName confilcts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
  testRunner.When("selected Destination Server is \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
  testRunner.And("I select \"bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
  testRunner.When("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
  testRunner.Then("the User is prompted to \"Rename or Delete\" one of the resources", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Warning message no longer appears")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void WarningMessageNoLongerAppears()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Warning message no longer appears", new string[] {
                        "DeployTab"});
#line 142
this.ScenarioSetup(scenarioInfo);
#line 143
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 144
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
  testRunner.Then("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
  testRunner.When("selected Destination Server is \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 148
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
  testRunner.And("I select \"bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
  testRunner.When("I click OK on Resource exists in the destination server popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
  testRunner.And("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
  testRunner.And("the Deploy validation message is \"1 Resource Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploying to an Older server version")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployingToAnOlderServerVersion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploying to an Older server version", new string[] {
                        "DeployTab"});
#line 157
this.ScenarioSetup(scenarioInfo);
#line 158
 testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 159
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
  testRunner.Then("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
  testRunner.When("selected Destination Server is \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
  testRunner.And("destination Server Version is \"0.0.0.1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
  testRunner.And("I select \"Utility - Date and Time\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
  testRunner.When("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 167
  testRunner.Then("a warning message appears \"Deploying to an older server version could result in r" +
                    "esources not working on destination server\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 168
  testRunner.And("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy Based on permission Deploy To")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployBasedOnPermissionDeployTo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy Based on permission Deploy To", new string[] {
                        "DeployTab"});
#line 171
this.ScenarioSetup(scenarioInfo);
#line 172
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 173
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
  testRunner.And("I select \"bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
  testRunner.And("I cannot deploy to destination", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
  testRunner.Then("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 178
  testRunner.When("selected Destination Server is \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 179
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 180
  testRunner.Then("\"Deploy\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 181
  testRunner.And("the validation message is \"Destination server permission Deploy To not allowed.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy Based on permission Deploy From")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployBasedOnPermissionDeployFrom()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy Based on permission Deploy From", new string[] {
                        "DeployTab"});
#line 184
this.ScenarioSetup(scenarioInfo);
#line 185
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 186
  testRunner.And("I cannot deploy from source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 189
  testRunner.And("I select \"bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 190
   testRunner.Then("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 191
  testRunner.When("selected Destination Server is \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 192
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy resource Tests message")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployResourceTestsMessage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy resource Tests message", new string[] {
                        "DeployTab"});
#line 195
this.ScenarioSetup(scenarioInfo);
#line 196
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 197
  testRunner.When("I select Destination Server as \"DestinationServer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 198
  testRunner.Then("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
  testRunner.And("destination \"DestinationServer\" is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
  testRunner.And("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 202
  testRunner.And("the Deploy validation message is \"1 Resource Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
