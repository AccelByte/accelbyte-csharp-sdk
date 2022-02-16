// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsRegisterLocalServerRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("custom_attribute")]
        public string? CustomAttribute { get; set; }
        
        [JsonPropertyName("ip")]
        public string? Ip { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("port")]
        public int? Port { get; set; }
        
    }
}