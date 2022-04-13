// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Core.Converters
{
    public class JsonStringEnumAttribute : JsonConverterAttribute
    {
        public override JsonConverter? CreateConverter(Type typeToConvert)
        {
            if (typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(List<>))
            {
                Type genericType = typeToConvert.GetGenericArguments()[0];
                return (JsonConverter?)Activator.CreateInstance(
                    typeof(JsonStringEnumListConverter<>)
                    .MakeGenericType(new Type[] { genericType })
                );
            }
            else
                return new JsonStringEnumConverter();
        }
    }
}