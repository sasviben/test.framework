using System;

namespace UI.Configuration
{
    class AppConfiguration
    {
        public string Browser { get; set; }
        public string ExecutionEnvironment { get; set; }

        public void Initialize()
        {
            ExecutionEnvironment = Environment.GetEnvironmentVariable("environment");
            
            if (!string.IsNullOrEmpty(Browser))
                Browser = Environment.GetEnvironmentVariable("browser");
        }

    }
}
