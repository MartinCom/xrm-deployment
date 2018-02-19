using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Xrm.Deployment.Core.Confg
{
    public class ConfigReader
    {
        private const string _defaultConfigFile = "xrm-deployment-config.json";
        private readonly string _jsonConfigPath;
        private readonly bool _validatePath = false;

        public ConfigReader()
        {
            _jsonConfigPath = _defaultConfigFile;
        }

        public ConfigReader(string filePath)
        {
            _validatePath = true;
            _jsonConfigPath = filePath;
        }

        public IDictionary<string, IConfigItem> Read()
        {
            if (!File.Exists(_jsonConfigPath))
            {
                if (_validatePath)
                    throw new ArgumentException("config missing path ", "_jsonConfigPath");
                else
                    return null;
            }

            if (string.IsNullOrWhiteSpace(_jsonConfigPath))
                throw new ArgumentException("json config missing content", "jsonConfig");
            return DeserializeDataContractJson<IDictionary<string, ConfigItem>>(File.ReadAllText(_jsonConfigPath))
                .ToDictionary(k => k.Key, v => (IConfigItem)v.Value);
        }

        private static T DeserializeDataContractJson<T>(string content)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true
            });

            return (T)ser.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(content)));
        }
    }
}