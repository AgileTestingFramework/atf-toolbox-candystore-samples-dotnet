using atf.toolbox;
using CandyStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Configuration;
using System.Drawing.Imaging;
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

        [AfterScenario]
        public void TakeScreenshotOnFailure()
        {
            // Take screen shot on failure if the web test had a failure
            ITakesScreenshot screenShot = null;

            if (ATFHandler.Instance.IsWebAutomationActive) { screenShot = ATFHandler.Instance.WebAutomation.TakesScreenShot; }
            else if (ATFHandler.Instance.IsMobileAutomationActive) { screenShot = ATFHandler.Instance.MobileAutomation.TakesScreenShot;  }

            if (screenShot !=null && ScenarioContext.Current.TestError != null)
            {
                screenShot.GetScreenshot().SaveAsFile(
                    ATFHandler.Instance.ReportConfiguration.ScreenshotDirectory +
                    ScenarioContext.Current.ScenarioInfo.Title + ".png", ImageFormat.Png);
            }
        }

        [AfterTestRun]
        public static void AfterTestRunTeardown()
        {
            ATFHandler.Instance.TearDown();
        }
    }
}
