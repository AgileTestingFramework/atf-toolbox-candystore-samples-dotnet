using atf.toolbox;
using CandyStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using TechTalk.SpecFlow;

namespace CandyStoreAutomation.Features
{
    [Binding]
    [TestClass]
    public class FeatureInitializer
    {
        public static TestContext TestContext { get; set; }

        [BeforeTestRun]
        public static void BeforeTestRunSetup()
        {
            ATFHandler.Instance.AddConfiguration(CandyStoreConstants.CONFIG_WEBSETTINGS, ConfigurationManager.GetSection(CandyStoreConstants.CONFIG_WEBSETTINGS) as ConfigurationSection);
        }

        [AssemblyInitialize]
        public static void AssemblySetup(TestContext context)
        {
            // Used so that a feature steps class can get an instance of the MSTest Context
            TestContext = context;
        }

        [AfterTestRun]
        public static void AfterTestRunTeardown()
        {
            ATFHandler.Instance.TearDown();
        }
    }
}
