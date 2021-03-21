using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using UI.AppSettings;
using UI.Models;
using static UI.Helpers.Enums;

namespace UI.Configuration
{
    class ConfigurationManager
    {
        private readonly string _configPath = "/AppSettings";
        private readonly AppConfiguration _appConfig;
        private readonly PlayerDetailsModel _playerCredentials;
        private string _configurationName;
        private ConfigOptions _configOptions;

        public ConfigurationManager(PlayerDetailsModel playerDetails)
        {
            _appConfig = new AppConfiguration();
            _configOptions = new ConfigOptions();
            _playerCredentials = playerDetails;
        }

        public void LoadConfiguration(BoDi.IObjectContainer _objectContainer)
        {

            _appConfig.Initialize();

            if (string.IsNullOrEmpty(_appConfig.ExecutionEnvironment))
                _appConfig.ExecutionEnvironment = "Stage";
            _configurationName = GetConfiguration(_appConfig.ExecutionEnvironment);

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + _configPath).AddJsonFile(_configurationName);
            var config = builder.Build();

            _configOptions = config.GetSection("ConfigOptions").Get<ConfigOptions>();

            if (_appConfig.Browser != null)
                _configOptions.Browser = _appConfig.Browser;

            new Settings(_configOptions);

            _objectContainer.RegisterInstanceAs(_configOptions);
        }

        private static string GetConfiguration(string executionEnvironment)
        {
            if (executionEnvironment == null)
                throw new ArgumentException("Environment variable 'environment' is null! You should enter execution environment when running a tests. For example: Stage");

            var configuration = "";

            if (!Enum.TryParse(executionEnvironment, true, out ExecutionEnvironmentType executionEnvironmentParsed))
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

        public void SetUserCredentials(string userType)
        {
            foreach (var player in Settings.Configuration.PlayerCredentials)
            {
                if (userType.Equals("RETAIL_BETTING"))
                    userType = "NONBETTING";

                if (player.Username.ToUpper().Contains(userType.ToString()))
                {
                    _playerCredentials.PlayerUsername = player.Username;
                    _playerCredentials.PlayerPassword = player.Username + "123";
                }
            }

            if (_playerCredentials.PlayerUsername == null)
                throw new ArgumentException($"Configuration doesn't contains user {userType}! Please check configuration.");

        }
    }
}