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
namespace Warewolf.UISpecs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UITesting.CodedUITestAttribute()]
    public partial class ExplorerFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Explorer.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Explorer", "\tIn order to manage services\r\n\tAs a Warewolf Studio user\r\n\tI want to perform a co" +
                    "mposition of recorded actions", ProgrammingLanguage.CSharp, new string[] {
                        "Explorer"});
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Explorer")))
            {
                Warewolf.UISpecs.ExplorerFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Drag on Remote Subworkflow from Explorer and Execute it")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void DragOnRemoteSubworkflowFromExplorerAndExecuteIt()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Drag on Remote Subworkflow from Explorer and Execute it", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("The Warewolf Studio is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I Click New Workflow Ribbon Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And("I Select \"Remote Connection Integration\" From Explorer Remote Server Dropdown Lis" +
                    "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I Wait For Explorer First Remote Server Spinner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("I Filter the Explorer with \"workflow1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("I Drag Explorer Remote workflow1 Onto Workflow Design Surface", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("I Save With Ribbon Button And Dialog As \"LocalWorkflowWithRemoteSubworkflow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("I Click Debug Ribbon Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("I Click DebugInput Debug Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("I Click Debug Output Workflow1 Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I Select Show Dependencies In Explorer Context Menu for service \"LocalWorkflowWit" +
                    "hRemoteSubworkflow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("I Click Close Dependecy Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("I Try Close Workflow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opening and Editing workflow from Explorer Remote")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void OpeningAndEditingWorkflowFromExplorerRemote()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opening and Editing workflow from Explorer Remote", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("The Warewolf Studio is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.When("I Select \"Remote Connection Integration\" From Explorer Remote Server Dropdown Lis" +
                    "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I Filter the Explorer with \"Hello World\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("I open \"Hello World\" in Remote Connection Integration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And("I Try Close Workflow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deleting a Resource localhost")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void DeletingAResourceLocalhost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting a Resource localhost", ((string[])(null)));
#line 33
 this.ScenarioSetup(scenarioInfo);
#line 34
   testRunner.Given("The Warewolf Studio is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
   testRunner.When("I Click New Workflow Ribbon Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
   testRunner.And("I Filter the Explorer with \"workflow1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
   testRunner.And("I Drag Explorer workflow Onto Workflow Design Surface", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
   testRunner.And("I Save With Ribbon Button And Dialog As \"LocalWorkflowWithRemoteSubworkflowToDele" +
                    "te\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
   testRunner.And("I Filter the Explorer with \"LocalWorkflowWithRemoteSubworkflowToDelete\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
   testRunner.And("I RightClick Explorer Localhost First Item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
   testRunner.And("I Select Delete FromExplorerContextMenu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
   testRunner.And("I Click MessageBox Yes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deleting a Folder in localhost")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void DeletingAFolderInLocalhost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting a Folder in localhost", ((string[])(null)));
#line 44
 this.ScenarioSetup(scenarioInfo);
#line 45
   testRunner.Given("The Warewolf Studio is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
   testRunner.When("I Filter the Explorer with \"FolderToDelete\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
   testRunner.And("I RightClick Explorer Localhost First Item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
   testRunner.And("I Select Delete FromExplorerContextMenu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
   testRunner.And("I Click MessageBox Yes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Filter Should Clear On Connection Of Remote Server")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void FilterShouldClearOnConnectionOfRemoteServer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filter Should Clear On Connection Of Remote Server", ((string[])(null)));
#line 51
 this.ScenarioSetup(scenarioInfo);
#line 52
   testRunner.Given("The Warewolf Studio is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
   testRunner.When("I Filter the Explorer with \"Hello World\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
   testRunner.When("I Select \"Remote Connection Integration\" From Explorer Remote Server Dropdown Lis" +
                    "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
   testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
   testRunner.Then("Filter Textbox is cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
   testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deleting a Resource Remote")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void DeletingAResourceRemote()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting a Resource Remote", ((string[])(null)));
#line 59
 this.ScenarioSetup(scenarioInfo);
#line 60
   testRunner.Given("The Warewolf Studio is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
   testRunner.When("I Select \"Remote Connection Integration\" From Explorer Remote Server Dropdown Lis" +
                    "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
   testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
   testRunner.And("I Wait For Explorer First Remote Server Spinner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
   testRunner.And("I Click New Workflow Ribbon Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
   testRunner.And("I Filter the Explorer with \"workflow1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
   testRunner.And("I Drag Explorer Remote workflow1 Onto Workflow Design Surface", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
   testRunner.And("I Save With Ribbon Button And Dialog As \"LocalWorkflowWithRemoteSubworkflowToDele" +
                    "te\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
   testRunner.And("I Filter the Explorer with \"LocalWorkflowWithRemoteSubworkflowToDelete\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
   testRunner.And("I RightClick Explorer First Remote Server First Item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
   testRunner.And("I Select Delete FromExplorerContextMenu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
   testRunner.And("I Click MessageBox Yes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
   testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deleting a Folder in Remote")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void DeletingAFolderInRemote()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting a Folder in Remote", ((string[])(null)));
#line 74
 this.ScenarioSetup(scenarioInfo);
#line 75
   testRunner.Given("The Warewolf Studio is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
   testRunner.When("I Select \"Remote Connection Integration\" From Explorer Remote Server Dropdown Lis" +
                    "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
   testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
   testRunner.And("I Wait For Explorer First Remote Server Spinner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
   testRunner.And("I Filter the Explorer with \"Examples\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
   testRunner.And("I RightClick Explorer First Remote Server First Item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
   testRunner.And("I Select Delete FromExplorerContextMenu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
   testRunner.And("I Click MessageBox Yes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
   testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Clear filter")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void ClearFilter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clear filter", ((string[])(null)));
#line 85
this.ScenarioSetup(scenarioInfo);
#line 86
   testRunner.Given("The Warewolf Studio is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 87
   testRunner.When("I Filter the Explorer with \"Hello World\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
   testRunner.Then("Filter Textbox has \"Hello World\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
   testRunner.And("I Click Explorer Filter Clear Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
   testRunner.Then("Filter Textbox is cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Renaming Folder And Workflow Service on a remote server")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Explorer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Explorer")]
        public virtual void RenamingFolderAndWorkflowServiceOnARemoteServer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Renaming Folder And Workflow Service on a remote server", ((string[])(null)));
#line 92
this.ScenarioSetup(scenarioInfo);
#line 93
 testRunner.Given("The Warewolf Studio is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 94
 testRunner.When("I Select \"Remote Connection Integration\" From Explorer Remote Server Dropdown Lis" +
                    "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
    testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
    testRunner.And("I Wait For Explorer First Remote Server Spinner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
    testRunner.And("I Filter the Explorer with \"Load Test Resources\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.When("I Rename First Remote Resource FromContextMenu to \"Renamed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.And("I Click Explorer Filter Clear Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.When("I Filter the Explorer with \"Renamed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.And("I Rename LocalFolder To SecondFolder", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("I Rename FolderItem ToNewFolderItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("I Wait For Explorer Localhost Spinner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("I Click Explorer Connect Remote Server Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
