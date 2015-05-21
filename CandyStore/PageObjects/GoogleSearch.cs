
using atf.toolbox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
namespace CandyStore.PageObjects
{
    public class GoogleSearch : LoadableComponent<GoogleSearch>
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        protected IWebElement searchBox;

        public void NavigateTo(string location)
        {
            ATFHandler.Instance.MobileAutomation.MobileDriver.Navigate().GoToUrl(location);
        }
        
        public void EnterSearchText(string searchText)
        {
            searchBox.Clear();
            searchBox.SendKeys(searchText);
            searchBox.SendKeys(Keys.Enter);
        }

        public bool PageContainsResults(string results)
        {
            bool containsResults = false;

            ReadOnlyCollection<IWebElement> elements = ATFHandler.Instance.MobileAutomation.MobileDriver.FindElements(By.PartialLinkText(results));

            if (elements != null && elements.Count > 0) containsResults = true;

            return containsResults;
        }



        protected override bool EvaluateLoadedStatus()
        {
            throw new System.NotImplementedException();
        }

        protected override void ExecuteLoad()
        {
            throw new System.NotImplementedException();
        }
    }
}
