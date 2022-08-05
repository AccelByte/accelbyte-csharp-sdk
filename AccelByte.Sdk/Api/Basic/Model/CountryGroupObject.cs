// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class CountryGroupObject : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("countries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<CountryObject>? Countries { get; set; }

        [JsonPropertyName("countryGroupCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryGroupCode { get; set; }

        [JsonPropertyName("countryGroupName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryGroupName { get; set; }

    }
}