using IceLabs.Adaqz.Models;
using Newtonsoft.Json;
using System;

namespace IceLabs.Adaqz.Json
{
    class ControlStatusJsonConverter : JsonConverter<ControlStatus>
    {
        public override ControlStatus ReadJson(JsonReader reader, Type objectType, ControlStatus existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            string value = reader.Value.ToString().Trim();
            switch (value)
            {
                case ControlStatus.OkValue: return ControlStatus.Ok;
                case ControlStatus.NoAccessValue: return ControlStatus.NoAccess;
                case ControlStatus.InvalidParamsValue: return ControlStatus.InvalidParams;
                case ControlStatus.InternalErrorValue: return ControlStatus.InternalError;
                default: return null;
            }
        }

        public override void WriteJson(JsonWriter writer, ControlStatus value, JsonSerializer serializer)
        {
            writer.WriteValue(value.Value);
        }
    }
}
