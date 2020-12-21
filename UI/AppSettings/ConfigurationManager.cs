using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using UI.AppSettings;
using static UI.Helpers.Enums;

namespace UI.Configuration
{
    class ConfigurationManager
    {
        public ConfigurationManager()
        {
            _appConfig = new AppConfiguration();
            _configOptions = new ConfigOptions();
        }

        private readonly string configPath = "/AppSettings";
        private readonly AppConfiguration _appConfig;
        private string _configurationName;
        private ConfigOptions _configOptions;


        ///<summary>
        ///     Loads JSON configuration
        ///</summary>
        ///<param name="objectContainer">
        ///     IObjectContainer type used for configuration instance registration configuration
        /// </param>
        public void LoadConfiguration(BoDi.IObjectContainer objectContainer)
        {
#if DEBUG
            _configurationName = "appsettings.QA.json";
#endif

#if RELEASE
            _appConfig.Initialize();
            _configurationName = GetConfiguration(_appConfig.ExecutionEnvironment);
#endif
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + configPath).AddJsonFile(_configurationName);
            var config = builder.Build();

            _configOptions = config.GetSection("ConfigOptions").Get<ConfigOptions>();

            if (_appConfig.Browser != null)
                _configOptions.Browser = _appConfig.Browser;

            new Settings(_configOptions);

            objectContainer.RegisterInstanceAs(_configOptions);
        }

        /// <summary>
        ///     Gets the configuration depending on the passed parameters.
        ///     This method is used only in Release configuration mode.
        /// </summary>
        /// 
        /// <param name="executionEnvironment">
        ///     Name of the desired execution environment
        ///</param>
        ///
        /// <returns>
        ///     Returns the configuration name specified by executionEnvironment parameter.
        ///</returns>
        ///
        /// <exception cref="System.ArgumentNullException">
        ///         executionEnvironment is null.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        ///         executionEnvironment is a zero-length string, contains only white space, contains one or more
        ///         invalid characters, or is not the same as a comparing Enum.
        /// </exception>
        public static string GetConfiguration(string executionEnvironment)
        {
            if (executionEnvironment == null)
                throw new ArgumentNullException("Environment variable 'environment' is null! You should enter execution environment when running a tests. For example: Stage");

            var configuration = "";

            if (!Enum.TryParse(executionEnvironment.ToUpper(), out ExecutionEnvironmentType executionEnvironmentParsed))
                throw new ArgumentException($"Object {executionEnvironment} can't be parsed to enum!");

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
    }
}
