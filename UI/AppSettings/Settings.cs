using System;
using static UI.Helpers.Enums;

namespace UI.Configuration
{
    class Settings
    {
        public Settings(JSONConfigurationMapper configOptions)
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
        public static JSONConfigurationMapper Configuration { get; set; }

        // Summary:
        //     Gets the configuration depending on the passed parameters.
        //     This method is used only in Release configuration mode.
        //
        // Parameters:
        //   executionEnvironment:
        //     name of the desired execution environment
        //
        // Returns:
        //     Returns the configuration name (string) on which tests will be executed.
        public static string GetConfiguration(string executionEnvironment)
        {
            if (executionEnvironment == null)
                throw new Exception("Environment variable 'environment' is null! You should enter execution environment when running a tests. For example: Stage");

            var configuration = "";

            if (!Enum.TryParse(executionEnvironment.ToUpper(), out ExecutionEnvironmentType executionEnvironmentParsed))
                throw new Exception($"Object {executionEnvironment} can't be parsed to enum!");

            switch (executionEnvironmentParsed)
            {
                case ExecutionEnvironmentType.SILENT:
                    configuration = "appsettings.Silent.json";
                    break;
                case ExecutionEnvironmentType.STAGE:
                    configuration = "appsettings.Stage.json";
                    break;
                case ExecutionEnvironmentType.QA:
                    configuration = "appsettings.QA.json";
                    break;
            }

            return configuration;
        }

        // Summary:
        //     Sets desirable user depending on the passed parameters.
        //
        // Parameters:
        //   userType:
        //     desired user who needs to be set.
        public static void SetUserCredentials(UserType userType)
        {
            foreach (var customer in Configuration.CustomerCredentials)
            {
                if (customer.Username.ToUpper().Contains(userType.ToString()))
                {
                    PlayerUsername = customer.Username;
                    PlayerPassword = PlayerUsername + "123";
                }
            }

            if (PlayerUsername == null)
                throw new NotSupportedException($"Configuration doesn't contains user {userType}! Please check configuration.");
        }
    }
}

