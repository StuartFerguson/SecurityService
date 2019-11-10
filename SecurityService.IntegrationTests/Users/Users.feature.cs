// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SecurityService.IntegrationTests.Users
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "base")]
    [Xunit.TraitAttribute("Category", "users")]
    public partial class UsersFeature : Xunit.IClassFixture<UsersFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "base",
                "users"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Users.feature"
#line hidden
        
        public UsersFeature(UsersFeature.FixtureData fixtureData, InternalSpecFlow.XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Users", null, ProgrammingLanguage.CSharp, new string[] {
                        "base",
                        "users"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create User")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Create User")]
        public virtual void CreateUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create User", null, ((string[])(null)));
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
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email Address",
                            "Password",
                            "Phone Number",
                            "Given Name",
                            "Middle Name",
                            "Family Name",
                            "Claims",
                            "Roles"});
                table1.AddRow(new string[] {
                            "testuser1@testing.co.uk",
                            "123456",
                            "123456789",
                            "Test",
                            "",
                            "User 1",
                            "Claim1:value1,Claim2:value2",
                            ""});
#line 5
 testRunner.Given("I create the following users", ((string)(null)), table1, "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Get User")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Get User")]
        public virtual void GetUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get User", null, ((string[])(null)));
#line 9
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
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email Address",
                            "Password",
                            "Phone Number",
                            "Given Name",
                            "Middle Name",
                            "Family Name",
                            "Claims",
                            "Roles"});
                table2.AddRow(new string[] {
                            "testuser1@testing.co.uk",
                            "123456",
                            "123456789",
                            "Test",
                            "",
                            "User 1",
                            "",
                            ""});
                table2.AddRow(new string[] {
                            "testuser2@testing.co.uk",
                            "123456",
                            "123456789",
                            "Test",
                            "",
                            "User 2",
                            "",
                            ""});
#line 10
 testRunner.Given("I create the following users", ((string)(null)), table2, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email Address",
                            "Phone Number",
                            "Given Name",
                            "Middle Name",
                            "Family Name",
                            "Claims",
                            "Roles"});
                table3.AddRow(new string[] {
                            "testuser1@testing.co.uk",
                            "123456789",
                            "Test",
                            "",
                            "User 1",
                            "email:testuser1@testing.co.uk, given_name:Test, family_name:User 1",
                            ""});
#line 14
 testRunner.When("I get the user with user name \'testuser1@testing.co.uk\' the user details are retu" +
                        "rned as follows", ((string)(null)), table3, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Get Users")]
        [Xunit.TraitAttribute("FeatureTitle", "Users")]
        [Xunit.TraitAttribute("Description", "Get Users")]
        [Xunit.TraitAttribute("Category", "PRTest")]
        public virtual void GetUsers()
        {
            string[] tagsOfScenario = new string[] {
                    "PRTest"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Users", null, new string[] {
                        "PRTest"});
#line 19
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
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email Address",
                            "Password",
                            "Phone Number",
                            "Given Name",
                            "Middle Name",
                            "Family Name",
                            "Claims",
                            "Roles"});
                table4.AddRow(new string[] {
                            "testuser1@testing.co.uk",
                            "123456",
                            "123456789",
                            "Test",
                            "",
                            "User 1",
                            "",
                            ""});
                table4.AddRow(new string[] {
                            "testuser2@testing.co.uk",
                            "123456",
                            "123456789",
                            "Test",
                            "",
                            "User 2",
                            "",
                            ""});
                table4.AddRow(new string[] {
                            "testuser3@testing.co.uk",
                            "123456",
                            "123456789",
                            "Test",
                            "",
                            "User 3",
                            "",
                            ""});
#line 20
 testRunner.Given("I create the following users", ((string)(null)), table4, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email Address",
                            "Phone Number",
                            "Given Name",
                            "Middle Name",
                            "Family Name",
                            "Claims",
                            "Roles"});
                table5.AddRow(new string[] {
                            "testuser1@testing.co.uk",
                            "123456789",
                            "Test",
                            "",
                            "User 1",
                            "email:testuser1@testing.co.uk, given_name:Test, family_name:User 1",
                            ""});
                table5.AddRow(new string[] {
                            "testuser2@testing.co.uk",
                            "123456789",
                            "Test",
                            "",
                            "User 2",
                            "email:testuser2@testing.co.uk, given_name:Test, family_name:User 2",
                            ""});
                table5.AddRow(new string[] {
                            "testuser3@testing.co.uk",
                            "123456789",
                            "Test",
                            "",
                            "User 3",
                            "email:testuser3@testing.co.uk, given_name:Test, family_name:User 3",
                            ""});
#line 25
 testRunner.When("I get the users 3 users details are returned as follows", ((string)(null)), table5, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UsersFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UsersFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion