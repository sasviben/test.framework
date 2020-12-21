using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Configuration
{
    class Configuration
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
