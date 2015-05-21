using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace CandyStore.PageObjects
{
    public class ContactUsPage : LoadableComponent<ContactUsPage>
    {
        [FindsBy(How = How.LinkText, Using = "Contact Us")]
        protected IWebElement ContactUsLink { get; set; }
        [FindsBy(How = How.Id, Using = "txtFirstName")]
        protected IWebElement FirstName { get; set; }

        public ContactUsPage() {}

        public void EnterFirstName(string firstName)
        {
            FirstName.Click();
            FirstName.Clear();
            FirstName.SendKeys(firstName);
        }

        public string FirstNameText()
        {
            return FirstName.GetAttribute("value").ToString();
        }

        protected override bool EvaluateLoadedStatus()
        {
            return true;
        }

        protected override void ExecuteLoad()
        {
            ((IndexPage)PageObjectFactory.WebPageInstance(PageObjectFactory.INDEX)).Load();
            ContactUsLink.Click();
            base.Load();
        }

        public override ContactUsPage Load()
        {
            this.ExecuteLoad();
            this.EvaluateLoadedStatus();

            return this;
        }
    }
}
