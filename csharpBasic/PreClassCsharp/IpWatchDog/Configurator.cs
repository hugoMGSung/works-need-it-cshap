﻿using IpWatchDog.Install;
using IpWatchDog.Log;
using IpWatchDog.Runners;

namespace IpWatchDog
{
    internal class Configurator
    {
        private readonly ILog _log;
        private readonly bool _isConsole;

        public Configurator(bool isConsole)
        {
            _isConsole = isConsole;
            _log = 
                isConsole ?
                (ILog)new ConsoleLog() :
                new SystemLog(StringConstants.ServiceName);
        }

        public IRunner CreateRunner()
        {
            var service = CreateWatchDogService();
            return _isConsole ?
                (IRunner)new ConsoleRunner(service) :
                new ServiceRunner(service, StringConstants.ServiceName);
        }

        public InstallUtil CreateInstaller()
        {
            return new InstallUtil(_log);
        }

        public IService CreateServiceController()
        {
            return new ServiceController(_log);
        }

        private IService CreateWatchDogService()
        {
            var config = new AppConfig();
            var notifier = CreateNotifier(config);

            return new IpWatchDogService(
                _log, 
                config,
                new IpPersistor(_log), 
                new WebIpRetriever(_log, config), 
                notifier);
        }

        private IIpNotifier CreateNotifier(AppConfig config)
        {
            if (string.IsNullOrEmpty(config.Command))
            {
                return new MailIpNotifier(_log, config);
            }
            return new CommandIpNotifier(_log, config);
        }
    }
}
