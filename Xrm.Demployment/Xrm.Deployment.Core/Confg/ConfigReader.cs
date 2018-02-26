using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;
using Xrm.Deployment.Core.Utils;

namespace Xrm.Deployment.Core.Confg
{
    public class ConfigReader
    {
        private const string _defaultConfigFile = "xrm-deployment-config.json";
        private readonly string _jsonConfigPath;
        private readonly bool _validatePath = false;
        private readonly ILog _log;

        public ConfigReader(ILog log)
        {
            _log = log;
            _jsonConfigPath = _defaultConfigFile;
        }

        public ConfigReader(string basePath, ILog log)
        {
            _log = log;
            _validatePath = true;
            _jsonConfigPath = $"{basePath}\\{_defaultConfigFile}";
        }
        public IDictionary<string, IConfigItem> TryRead()
        {
            try
            {
                return Read();
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message);
                _log.Log(ex.ToString());
                return null;
            }
            
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

        public void Save(IDictionary<string, IConfigItem> config)
        {
            _log.Log($"[Start] Saving new config elements - file: {_jsonConfigPath}");
            SerializeDataContractJson(config);
            _log.Log("[End] Saving new config elements");
        }

        private static T DeserializeDataContractJson<T>(string content)
        {
            return JsonConvert.DeserializeObject<T>(content);
            //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings
            //{
            //    UseSimpleDictionaryFormat = true
            //});

            //return (T)ser.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(content)));
        }
        private void SerializeDataContractJson<T>(T @object)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
            using (StreamWriter streamWriter = new StreamWriter(_jsonConfigPath,false, Encoding.UTF8))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, @object);
            }
                //serializer.NullValueHandling = NullValueHandling.Ignore;

                //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings
                //{
                //    UseSimpleDictionaryFormat = true,
                //    KnownTypes = knownTypes,

                //});


                //using (FileStream file = File.OpenWrite(_jsonConfigPath))
                //using (XmlDictionaryWriter writer = JsonReaderWriterFactory.CreateJsonWriter(file, Encoding.UTF8, true, true, "  "))
                //{
                //    {
                //        ser.WriteObject(file, @object);

                //    }


                //}
            }
    }
}