// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonJWTBanV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ban")]
        public string? Ban { get; set; }
        
        [JsonPropertyName("disabledDate")]
        public DateTime? DisabledDate { get; set; }
        
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }
        
        [JsonPropertyName("targetedNamespace")]
        public string? TargetedNamespace { get; set; }
        
    }
}