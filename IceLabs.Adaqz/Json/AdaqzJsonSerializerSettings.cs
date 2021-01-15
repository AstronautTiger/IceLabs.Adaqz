using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace IceLabs.Adaqz.Json
{
    public class AdaqzJsonSerializerSettings : JsonSerializerSettings
    {
        public AdaqzJsonSerializerSettings()
        {
            Formatting = Formatting.None;
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            NullValueHandling = NullValueHandling.Ignore;
            Converters = new List<JsonConverter>
            {
                new ControlStatusJsonConverter(),
                new DeviceTypeJsonConverter()
            };
        }

        public static readonly AdaqzJsonSerializerSettings Instance = new AdaqzJsonSerializerSettings();
    }
}
