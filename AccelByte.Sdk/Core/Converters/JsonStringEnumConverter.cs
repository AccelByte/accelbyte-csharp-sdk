// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Globalization;

namespace AccelByte.Sdk.Core.Converters
{
    public class JsonStringEnumConverter : JsonConverter<StringEnum>
    {
        public JsonStringEnumConverter()
        {

        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(StringEnum).IsAssignableFrom(typeToConvert);
        }

        public override StringEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string dValue = reader.GetString()!;

            StringEnum? obj = (StringEnum?)StringEnum.Create(typeToConvert, dValue);
            if (obj is null)
                throw new InvalidCastException("Could not create string enum object.");

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, StringEnum value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value);
        }
    }
}