using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyStore
{
    public class WebSettings : ConfigurationSection
    {
        public override bool IsReadOnly()
        {
            return false;
        }

        [ConfigurationProperty("candystore-website-url" , IsRequired = false)]
        public string CandyStoreWebsiteURL
        {
            get { return this["candystore-website-url"].ToString().Trim(); }
            set { this["candystore-website-url"] = value; }
        }

    }
}
