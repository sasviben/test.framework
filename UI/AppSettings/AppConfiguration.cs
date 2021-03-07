using System;

namespace UI.Configuration
{
    class AppConfiguration
    {
        //public string Hostname { get; set; }
        //public string Port { get; set; }
        public string Browser { get; set; }
        public string ExecutionEnvironment { get; set; }
        //public string SeleniumHubUri { get; set; }

        public void Initialize()
        {

            //if (!string.IsNullOrEmpty(Hostname))
            //    Hostname = Environment.GetEnvironmentVariable("seleniumHubHost");

            //if (!string.IsNullOrEmpty(Port))
            //    Port = Environment.GetEnvironmentVariable("seleniumHubPort");

            //SeleniumHubUri = $"http://{Hostname}:{Port}/wd/hub";

            ExecutionEnvironment = Environment.GetEnvironmentVariable("environment");
            Console.WriteLine($"{ExecutionEnvironment}");

            if (!string.IsNullOrEmpty(Browser))
                Browser = Environment.GetEnvironmentVariable("browser");
        }

    }
}
