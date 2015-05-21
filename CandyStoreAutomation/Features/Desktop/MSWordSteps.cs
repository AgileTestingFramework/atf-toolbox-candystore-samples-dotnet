using CandyStore.ScreenObjects;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CandyStoreAutomation.Features.Desktop
{
    [Binding]
    public class MSWordSteps
    {
        /**
         * Sikuli Integrator FAQ
         * Can't load IA 32-bit .dll on a AMD 64-bit platform
         * - to resolve, install x86 jre7u79 http://www.oracle.com/technetwork/java/javase/downloads/jre7-downloads-1880261.html
         * 
         * Must have permission to write to C:\SikuliOutputLog.txt (create file and grant write access to all users)
         * 
         * Can't find dependent libraries (VisionProxy.dll etc)
         * Add environment variable for SIKULI_HOME = C:\Users\'replacemeWithUser'\AppData\Local\Temp\tmplib
         * Add %SIKULI_HOME% to your PATH variable(s)
         * 
         **/
        private static DesktopScreen _desktopScreen;

        [BeforeFeature("ImageAutomation")]
        public static void FeatureSetup()
        {
            _desktopScreen = (DesktopScreen)ScreenObjectFactory.Instance(ScreenObjectFactory.DESKTOP);
        }

        [AfterFeature("ImageAutomation")]
        public static void FeatureTeardown()
        {
            if (_desktopScreen.IsMSWordOpened())
                _desktopScreen.ClickClose();
        }
        
        [Given(@"I have referenced the ATFFramework")]
        public void GivenIHaveReferencedTheATFFramework()
        {
            // Nothing to do here
        }

        [Given(@"I have captured a screen shot of the image I will be locating")]
        public void GivenIHaveCapturedAScreenShotOfTheImageIWillBeLocating()
        {
            // This exists in the website\images\MSWord.png
        }

        [When(@"I click on the image")]
        public void WhenIClickOnTheImage()
        {
            _desktopScreen.ClickMSWord();
        }

        [Then(@"MSWord will open")]
        public void ThenMSWordWillOpen()
        {
            _desktopScreen.IsMSWordOpened().Should().BeTrue("we expexted MSWord to be opened to the start page.");
        }
    }
}
