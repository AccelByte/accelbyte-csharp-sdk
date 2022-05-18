// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Core.Converters
{
    public class JsonStringEnumListConverter<T> : JsonConverter<List<T>> where T : StringEnum
    {
        public override bool CanConvert(Type typeToConvert)
        {
            if (typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(List<>))
            {
                Type itemType = typeToConvert.GetGenericArguments()[0];
                return typeof(StringEnum).IsAssignableFrom(itemType);
            }

            return false;
        }

        public override List<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException("Invalid start array token");

            var list = new List<T>();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    return list;

                string? value = reader.GetString();
                if (value is null)
                    throw new JsonException("value is null");

                list.Add(StringEnum<T>.NewValue(value));
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            foreach (T item in value)
                writer.WriteStringValue(item.Value);
            writer.WriteEndArray();
        }
    }
}