// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class AcceptAgreementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("comply")]
        public bool? Comply { get; set; }
        
        [JsonPropertyName("ext")]
        public Dictionary<string, object>? Ext { get; set; }
        
        [JsonPropertyName("proceed")]
        public bool? Proceed { get; set; }
        
    }
}