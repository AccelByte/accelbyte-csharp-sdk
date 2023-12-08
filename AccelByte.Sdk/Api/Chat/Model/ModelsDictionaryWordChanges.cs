// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Chat.Model
{
    public class ModelsDictionaryWordChanges : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("added")]
        public List<string>? Added { get; set; }

        [JsonPropertyName("failed")]
        public List<string>? Failed { get; set; }

        [JsonPropertyName("ignored")]
        public List<string>? Ignored { get; set; }

        [JsonPropertyName("replaced")]
        public List<string>? Replaced { get; set; }

        [JsonPropertyName("unchanged")]
        public List<string>? Unchanged { get; set; }

    }


}