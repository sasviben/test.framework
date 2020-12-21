using System.Collections.Generic;
using UI.Configuration;

namespace UI.AppSettings
{
    class ConfigOptions
    {
        public string HomepageUrl { get; set; }
        public string HomepageUrlFF { get; set; }
        public string Browser { get; set; }
        public string CustomerSessionAPI { get; set; }
        public string PlayerBalanceAPI { get; set; }
        public string Domain { get; set; }
        public string ClientSourceType { get; set; }
        public List<Credentials> CustomerCredentials { get; set; }
    }
}
