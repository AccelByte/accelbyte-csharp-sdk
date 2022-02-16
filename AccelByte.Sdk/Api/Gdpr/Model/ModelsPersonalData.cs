// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsPersonalData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DataExpirationDate")]
        public DateTime? DataExpirationDate { get; set; }
        
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("RequestDate")]
        public DateTime? RequestDate { get; set; }
        
        [JsonPropertyName("ServiceErrors")]
        public Dictionary<string, string>? ServiceErrors { get; set; }
        
        [JsonPropertyName("ServiceStatuses")]
        public Dictionary<string, string>? ServiceStatuses { get; set; }
        
        [JsonPropertyName("Status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("UserID")]
        public string? UserID { get; set; }
        
    }
}