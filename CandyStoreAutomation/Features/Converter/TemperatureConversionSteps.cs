using atf.toolbox.configuration;
using CandyStore.ScreenObjects;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using FluentAssertions;
using atf.toolbox;


namespace CandyStoreAutomation.Features.Converter
{
    [Binding]
    public class TemperatureConversionSteps
    {
        private static TemperatureScreen _temperaturePage;

        [AfterFeature("Converter")]
        public static void AfterFeatureTeardown()
        {
            ATFHandler.Instance.TearDown();
        }

        [Given(@"I have entered temperature conversion")]
        public void GivenIHaveEnteredTemperatureConversion()
        {
            _temperaturePage = (TemperatureScreen)ScreenObjectFactory.Instance(ScreenObjectFactory.TEMPERATURE);
        }

        [Given(@"I have entered (.*) into the converter")]
        public void GivenIHaveEnteredIntoTheConverter(decimal celsius)
        {
            _temperaturePage.EnterCelsius(celsius);
        }

        [When(@"I press equals")]
        public void WhenIPressEquals()
        {
            _temperaturePage.ClickEqual1();
        }

        [Then(@"the (.*) conversion should be displayed")]
        public void ThenTheConversionShouldBeDisplayed(decimal fahrenheit)
        {
            _temperaturePage.FahrenheitText1().Should().Be(fahrenheit, "because we expected the conversion to be "+fahrenheit);
        }
    }
}
