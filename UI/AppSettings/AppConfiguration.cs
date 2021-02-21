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

        /// <summary>
        ///         Initializes all AppConfiguration properties.
        /// </summary>
        /// 
        /// <exception cref="ArgumentNullException">
        ///         Hostname, Port or Browser is null.
        /// </exception>
        public void Initialize()
        {
            Hostname = Environment.GetEnvironmentVariable("seleniumHubHost");
            if (Hostname == null)
                throw new ArgumentNullException("Environment variable 'hostname' is null! You should enter Selenium hub hostname when running a tests.");

            Port = Environment.GetEnvironmentVariable("seleniumHubPort");
            if (Port == null)
                throw new ArgumentNullException("Environment variable 'port' is null! You should enter Selenium hub port when running a tests.");

            SeleniumHubUri = $"http://{Hostname}:{Port}/wd/hub";

            ExecutionEnvironment = Environment.GetEnvironmentVariable("environment");

            Browser = Environment.GetEnvironmentVariable("browser");
            if (Browser == null)
                throw new ArgumentNullException("Environment variable 'browser' is null! You should enter browser type when running a tests. For example: Chrome");
        }
    }
}
