using CandyStore.ScreenObjects;
using FluentAssertions;
using TechTalk.SpecFlow;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Configuration;
using atf.toolbox.configuration;
using atf.toolbox;

namespace CandyStoreAutomation.Features.CalculatorWPF
{
    [Binding]
    [TestClass]
    public class CalculateSteps
    {
        public static TestContext TestContext { get; set; }

        private static CalculatorScreen _calculatorScreen;

        [BeforeScenario("FormApplication")]
        public static void BeforeFeatureSetup()
        {
            _calculatorScreen = (CalculatorScreen)ScreenObjectFactory.Instance(ScreenObjectFactory.CALCULATOR);
            TestContext = FeatureInitializer.TestContext;           
        }

        [Given(@"I have entered fifty ""(.*)"" into the calculator")]
        public void GivenIHaveEnteredFiftyIntoTheCalculator(int p0)
        {
            _calculatorScreen.EnterNumberIntoCalculator(p0);
        }

        [Given(@"I have pressed the add sign")]
        public void GivenIHavePressedTheAddSign()
        {
            _calculatorScreen.PlusClick();
        }

        [Given(@"I have entered seventy ""(.*)"" into the calculator")]
        public void GivenIHaveEnteredSeventyIntoTheCalculator(int p0)
        {
            _calculatorScreen.EnterNumberIntoCalculator(p0);
        }

        [When(@"I press the equal sign")]
        public void WhenIPressTheEqualSign()
        {
            _calculatorScreen.EqualsClick();
        }

        [Then(@"the result should be one hundred twenty ""(.*)"" on the screen")]
        public void ThenTheResultShouldBeOneHundredTwentyOnTheScreen(int p0)
        {
            _calculatorScreen.TopDisplayWindowValue().Should().BeEquivalentTo(p0.ToString(), "we expected the total to match.");
        }

        [Then(@"the running paper should show the full calculation of ""(.*)""")]
        public void ThenTheRunningPaperShouldShowTheFullCalculationOf(string p0)
        {
            _calculatorScreen.RunningPaperDisplayWindowValue().Should().Contain(p0, "we expected the running paper to show the calculation just performed.");
        }

        //**********************************************//

        [Given(@"I have enetered a first number (.*)")]
        public void GivenIHaveEneteredAFirstNumber(int firstNumber)
        {
            _calculatorScreen.EnterNumberIntoCalculator(firstNumber);
        }

        [Given(@"I have entered a second number (.*)")]
        public void GivenIHaveEnteredASecondNumber(int secondNumber)
        {
            _calculatorScreen.EnterNumberIntoCalculator(secondNumber);
        }

        [Then(@"the sum should be (.*)")]
        public void ThenTheSumShouldBe(string p0)
        {
            _calculatorScreen.TopDisplayWindowValue().Should().BeEquivalentTo(p0, "we expected the sum to match.");
        }

        [Then(@"the running paper should show ""(.*)""")]
        public void ThenTheRunningPaperShouldShow(string p0)
        {
            _calculatorScreen.RunningPaperDisplayWindowValue().Should().Contain(p0, "we expected the running paper to show the calculation just performed.");
        }
    }
}
