using CandyStore.PageObjects;
using TechTalk.SpecFlow;
using FluentAssertions;
using atf.toolbox;
using OpenQA.Selenium;
using System.Drawing.Imaging;

namespace CandyStoreAutomation.Features.Website
{
    [Binding]
    public class ContactUsSteps
    {
        private static ContactUsPage _contactUsPage;

        [BeforeFeature("WebApplication")]
        public static void BeforeFeatureSetup()
        {
            _contactUsPage = (ContactUsPage)PageObjectFactory.WebPageInstance(PageObjectFactory.CONTACTUS);
        }

        [Given(@"I have entered to the Candy Store website and navigated to the Contact Us page")]
        public void GivenIHaveEnteredToTheCandyStoreWebsiteAndNavigatedToTheContactUsPage()
        {
            _contactUsPage.Load();
        }

        [Given(@"I have entered my first name ""(.*)""")]
        public void GivenIHaveEnteredMyFirstName(string firstName)
        {
            _contactUsPage.EnterFirstName(firstName);
        }

        [When(@"I complete my entry")]
        public void WhenICompleteMyEntry()
        {
            // nothing to perform here
        }

        [Then(@"I expect my first name not to have exceeded the maximum length of (.*)")]
        public void ThenIExpectMyFirstNameNotToHaveExceededTheMaximumLengthOf(int p0)
        {
            _contactUsPage.FirstNameText().Length.Should().Be(25, "we expected only 25 characters in the first name textbox which is the maximum allowed.");
        }
    }
}
