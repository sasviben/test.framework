﻿using UI.AppSettings;

namespace UI.Configuration
{
    class Settings
    {
        public Settings(ConfigOptions configOptions)
        {
            HomePageUrl = configOptions.HomepageUrl;
            HomePageUrlFirefox = configOptions.HomepageUrlFF;
            Browser = configOptions.Browser;
            PlayerSessionAPI = configOptions.CustomerSessionAPI;
            PlayerBalanceAPI = configOptions.PlayerBalanceAPI;
            Domain = configOptions.Domain;
            ClientSourceType = configOptions.ClientSourceType;
            Configuration = configOptions;
        }

        public static string HomePageUrl { get; set; }
        public static string HomePageUrlFirefox { get; set; }
        public static string Browser { get; set; }
        public static string PlayerUsername { get; set; }
        public static string PlayerPassword { get; set; }
        public static string PlayerSessionAPI { get; set; }
        public static string PlayerBalanceAPI { get; set; }
        public static string Domain { get; set; }
        public static string ClientSourceType { get; set; }
        public static ConfigOptions Configuration { get; set; }
    }
}
