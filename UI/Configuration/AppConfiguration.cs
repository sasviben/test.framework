using System;

namespace UI.Configuration
{
    class AppConfiguration
    {
        public string Hostname { get; set; }
        public string Port { get; set; }
        public string Browser { get; set; }
        public string Country { get; set; }
        public string ExecutionEnvironment { get; set; }
        public string SeleniumHubUri { get; set; }

        public void Initialize()
        {
            Hostname = Environment.GetEnvironmentVariable("seleniumHubHost");
            if (Hostname == null)
                throw new Exception("Environment variable 'hostname' is null! You should enter Selenium hub hostname when running a tests.");

            Port = Environment.GetEnvironmentVariable("seleniumHubPort");
            if (Port == null)
                throw new Exception("Environment variable 'port' is null! You should enter Selenium hub port when running a tests.");

            SeleniumHubUri = $"http://{Hostname}:{Port}/wd/hub";

            ExecutionEnvironment = Environment.GetEnvironmentVariable("environment");

            Browser = Environment.GetEnvironmentVariable("browser");
            if (Browser == null)
                throw new Exception("Environment variable 'browser' is null! You should enter browser type when running a tests. For example: Chrome");

            Country = Environment.GetEnvironmentVariable("country");
        }
    }
}
