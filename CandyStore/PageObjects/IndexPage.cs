using OpenQA.Selenium.Support.UI;
using atf.toolbox;

namespace CandyStore.PageObjects
{
    public class IndexPage : LoadableComponent<IndexPage>
    {
        protected override bool EvaluateLoadedStatus()
        {
            return true;
        }

        protected override void ExecuteLoad()
        {
            string websiteURL = ((WebSettings)ATFHandler.Instance.Configuration(CandyStoreConstants.CONFIG_WEBSETTINGS)).CandyStoreWebsiteURL;
            ATFHandler.Instance.WebAutomation.WebDriver.Navigate().GoToUrl(websiteURL);
            base.Load();
        }

        public override IndexPage Load()
        {
            this.ExecuteLoad();
            this.EvaluateLoadedStatus();

            return this;
        }
    }
}
