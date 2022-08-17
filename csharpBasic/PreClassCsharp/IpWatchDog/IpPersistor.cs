﻿using System;
using System.IO;
using IpWatchDog.Log;

namespace IpWatchDog
{
    internal class IpPersistor : IIpPersistor
    {
        private readonly string _path;
        private readonly ILog _log;

        public IpPersistor(ILog log)
        {
            _log = log;
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var folder = Path.Combine(appData, "IpWatchDog");
            Directory.CreateDirectory(folder);
            _path = Path.Combine(folder, "currentIp.txt");
        }

        public string GetIp()
        {
            if (!File.Exists(_path)) return null;
            try
            {
                using (var reader = new StreamReader(_path))
                {
                    return reader.ReadToEnd().Trim();
                }
            }
            catch (Exception ex)
            {
                _log.Write(LogLevel.Warning, "Error reading IP from storage. {0}", ex);
                return null;
            }
        }

        public void SaveIp(string ip)
        {
            try
            {
                using (var writer = new StreamWriter(_path))
                {
                    writer.Write(ip);
                }
            }
            catch (Exception ex)
            {
                _log.Write(LogLevel.Warning, "Error writing IP to storage. {0}", ex);
            }
        }
    }
}
