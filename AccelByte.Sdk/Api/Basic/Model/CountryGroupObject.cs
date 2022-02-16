// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class CountryGroupObject : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("countries")]
        public List<CountryObject>? Countries { get; set; }
        
        [JsonPropertyName("countryGroupCode")]
        public string? CountryGroupCode { get; set; }
        
        [JsonPropertyName("countryGroupName")]
        public string? CountryGroupName { get; set; }
        
    }
}