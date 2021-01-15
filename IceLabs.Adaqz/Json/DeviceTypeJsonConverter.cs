using IceLabs.Adaqz.Models;
using Newtonsoft.Json;
using System;

namespace IceLabs.Adaqz.Json
{
    public class DeviceTypeJsonConverter : JsonConverter<DeviceType>
    {

        public override DeviceType ReadJson(JsonReader reader, Type objectType, DeviceType existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            string value = reader.Value.ToString().Trim();            
            switch (value)                
            {
                case DeviceType.HeaterValue: return DeviceType.Heater;
                default: return null;
            };
        }

        public override void WriteJson(JsonWriter writer, DeviceType value, JsonSerializer serializer)
        {
            writer.WriteValue(value.Value);
        }
    }
}
