// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Inventory.Model
{
    public class ApimodelsUpdateItemReq : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("customAttributes")]
        public Dictionary<string, object>? CustomAttributes { get; set; }

        [JsonPropertyName("slotId")]
        public string? SlotId { get; set; }

        [JsonPropertyName("sourceItemId")]
        public string? SourceItemId { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

    }

    public class ApimodelsUpdateItemReq<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("customAttributes")]
        public T1? CustomAttributes { get; set; }

        [JsonPropertyName("slotId")]
        public string? SlotId { get; set; }

        [JsonPropertyName("sourceItemId")]
        public string? SourceItemId { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

    }

}