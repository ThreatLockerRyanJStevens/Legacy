using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ThreatLocker.Shared.Converters
{
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                var stringValue = jsonDoc.RootElement.GetRawText().Trim('"').Trim('\'');
                if (!stringValue.ToLower().Contains("null"))
                {
                    try
                    {
                        var value = DateTime.Parse(stringValue, null, System.Globalization.DateTimeStyles.RoundtripKind);
                        return value;
                    }
                    catch
                    {
                        return DateTime.MinValue;
                    }
                    
                } else
                {
                    return DateTime.MinValue;
                }

            }
            //return DateTime.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            if (value == DateTime.MinValue)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ssZ"));
            }
        }
    }
}
