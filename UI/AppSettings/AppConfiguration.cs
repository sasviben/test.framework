using System;

namespace UI.Configuration
{
    class AppConfiguration
    {
        public string Hostname { get; set; }
        public string Port { get; set; }
        public string Browser { get; set; }
        public string ExecutionEnvironment { get; set; }
        public string SeleniumHubUri { get; set; }

        public void Initialize()
        {
            Hostname = Environment.GetEnvironmentVariable("seleniumHubHost");
            if (string.IsNullOrEmpty(Hostname))
                throw new ArgumentException("Environment variable 'hostname' is null or empty! You should enter Selenium hub hostname when running a tests.");

            Port = Environment.GetEnvironmentVariable("seleniumHubPort");
            if (string.IsNullOrEmpty(Port))
                throw new ArgumentException("Environment variable 'port' is null or empty! You should enter Selenium hub port when running a tests.");

            SeleniumHubUri = $"http://{Hostname}:{Port}/wd/hub";

            ExecutionEnvironment = Environment.GetEnvironmentVariable("environment");

            Browser = Environment.GetEnvironmentVariable("browser");
            if (string.IsNullOrEmpty(Browser))
                throw new ArgumentException("Environment variable 'browser' is null or empty! You should enter browser type when running a tests. For example: Chrome");
        }

    }
}
