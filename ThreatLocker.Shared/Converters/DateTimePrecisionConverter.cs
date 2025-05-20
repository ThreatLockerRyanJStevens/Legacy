using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ThreatLocker.Shared.Converters
{
    public class DateTimePrecisionConverter : DateTimeConverter
	{
        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            if (value == DateTime.MinValue)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffZ"));
            }
        }
    }
}
