using CandyStore.PageObjects;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CandyStoreAutomation.Features.Website
{
    [Binding]
    public class GoogleSteps
    {
        private static GoogleSearch _googlePage;

        [BeforeFeature("MobileApplication")]
        public static void BeforeFeatureSetup()
        {
            _googlePage = (GoogleSearch)PageObjectFactory.MobilePageInstance(PageObjectFactory.GOOGLE);
        }

        [Given(@"I have opened a browser to ""(.*)""")]
        public void GivenIHaveOpenedABrowserTo(string startingURL)
        {
            _googlePage.NavigateTo(startingURL);
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchString)
        {
            _googlePage.EnterSearchText(searchString);
        }

        [Then(@"I expect my search results to contain ""(.*)""")]
        public void ThenIExpectMySearchResultsToContain(string expectedResults)
        {
            _googlePage.PageContainsResults(expectedResults).Should().BeTrue("we expected the results to be found on the page after searching.");
        }
    }
}
