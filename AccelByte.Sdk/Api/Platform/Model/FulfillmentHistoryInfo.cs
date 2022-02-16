// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("creditSummaries")]
        public List<CreditSummary>? CreditSummaries { get; set; }
        
        [JsonPropertyName("entitlementSummaries")]
        public List<EntitlementSummary>? EntitlementSummaries { get; set; }
        
        [JsonPropertyName("fulfillItems")]
        public List<FulfillmentItem>? FulfillItems { get; set; }
        
        [JsonPropertyName("fulfillmentError")]
        public FulfillmentError? FulfillmentError { get; set; }
        
        [JsonPropertyName("grantedItemIds")]
        public List<string>? GrantedItemIds { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("orderNo")]
        public string? OrderNo { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}