using System.Collections.Generic;

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
        public string Cookie { get; set; }
        public List<Credentials> PlayerCredentials { get; set; }

    }
    public class Credentials
    {
        public string Username { get; set; }

    }
}
