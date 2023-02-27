using System.Configuration;

namespace Selenium_Web_Testing_Sauce_Demo.Configuration
{
    public static class ConfigReader
    {
        public static readonly string baseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string inventoryUrl = ConfigurationManager.AppSettings["inventory_url"];
        public static readonly string yourcartUrl = ConfigurationManager.AppSettings["yourcart_url"];

        public static readonly string checkoutInformationUrl = ConfigurationManager.AppSettings["checkoutinformation_url"];
        public static readonly string checkoutOverviewUrl = ConfigurationManager.AppSettings["checkoutoverview_url"];
        public static readonly string checkoutCompleteUrl = ConfigurationManager.AppSettings["checkoutcomplete_url"];

        public static readonly string sauceLabsUrl = ConfigurationManager.AppSettings["saucelabs_url"];
        public static readonly string twitterUrl = ConfigurationManager.AppSettings["twitter_url"];
        public static readonly string facebookUrl = ConfigurationManager.AppSettings["facebook_url"];
        public static readonly string linkedinUrl = ConfigurationManager.AppSettings["linkedin_url"];

        public static readonly string termsOfServiceUrl = ConfigurationManager.AppSettings["termsofservice_url"];
        public static readonly string privacyPolicyUrl = ConfigurationManager.AppSettings["privacypolicy_url"];
    }
}
