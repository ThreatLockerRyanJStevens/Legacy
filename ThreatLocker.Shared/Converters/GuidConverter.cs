using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Shared.Converters
{
    public class GuidConverter : JsonConverter<Guid>
    {
        public override Guid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                var stringValue = jsonDoc.RootElement.GetRawText().Trim('"').Trim('\'');
                if (stringValue.IsNullOrEmpty() || stringValue.ToLower() == "null")
                    return Guid.Empty;
                else
                    return Guid.Parse(stringValue);
            }
        }

        public override void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options)
        {
            if (value == Guid.Empty)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(value.ToString());
            }
        }
    }
}
