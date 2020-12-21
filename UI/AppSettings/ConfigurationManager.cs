using System.IO;
using Microsoft.Extensions.Configuration;
using UI.AppSettings;

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

        public void LoadConfiguration(BoDi.IObjectContainer _objectContainer)
        {
#if DEBUG
            _configurationName = "appsettings.Production.PL.json";
#endif

#if RELEASE
            _appConfig.Initialize();
            _configurationName = Settings.GetConfiguration(_appConfig.ExecutionEnvironment);
#endif
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + configPath).AddJsonFile(_configurationName);
            var config = builder.Build();

            _configOptions = config.GetSection("ConfigOptions").Get<ConfigOptions>();

            if (_appConfig.Browser != null)
                _configOptions.Browser = _appConfig.Browser;

            new Settings(_configOptions);

            _objectContainer.RegisterInstanceAs(_configOptions);
        }
    }
}
