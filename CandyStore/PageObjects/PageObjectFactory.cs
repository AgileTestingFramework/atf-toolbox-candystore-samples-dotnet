using atf.toolbox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace CandyStore.PageObjects
{
    /// <summary>
    /// PageObjectFactory
    /// Add all page object creations here
    /// Its recommended you use the PageFactory.InitElements() for each of your page objects being returned
    /// </summary>
    public class PageObjectFactory
    {
        private static Dictionary<string, ILoadableComponent> instances = new Dictionary<string, ILoadableComponent>();
        
        /** Create all page object constants here for easy access **/
        public static string INDEX = "index";
        public static string CONTACTUS = "contactUs";
        public static string GOOGLE = "google";


        private PageObjectFactory() { }
        
        private static object _syncPageObjectCreator = new Object();

        public static ILoadableComponent WebPageInstance(string pageObjectType)
        {
            ILoadableComponent instance = null;

            if (instances.ContainsKey(pageObjectType))
            {
                // Our "per key" singleton
                instance = instances[pageObjectType];
            }
            else
            {
                lock (_syncPageObjectCreator)
                {
                    // Lazily create new instance of the page object
                    if (pageObjectType == INDEX) { instance = new IndexPage(); }
                    else if (pageObjectType == CONTACTUS) { instance = new ContactUsPage(); }

                    // Add it to map   
                    instances.Add(pageObjectType, instance);
                }
            }

            // Initialize the page object elements
            PageFactory.InitElements(ATFHandler.Instance.WebAutomation.WebDriver, instance);
        
            return instance;
        }

        public static ILoadableComponent MobilePageInstance(string pageObjectType)
        {
            ILoadableComponent instance = null;

            if (instances.ContainsKey(pageObjectType))
            {
                // Our "per key" singleton
                instance = instances[pageObjectType];
            }
            else
            {
                lock (_syncPageObjectCreator)
                {
                    // Lazily create new instance of the page object
                    if (pageObjectType == GOOGLE) { instance = new GoogleSearch(); }

                    // Add it to map   
                    instances.Add(pageObjectType, instance);
                }
            }

            // Initialize the page object elements
            PageFactory.InitElements(ATFHandler.Instance.MobileAutomation.MobileDriver, instance);

            return instance;
        }
    }
}
