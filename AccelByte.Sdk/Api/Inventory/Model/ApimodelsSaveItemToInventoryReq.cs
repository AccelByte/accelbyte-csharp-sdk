// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Inventory.Model
{
    public class ApimodelsSaveItemToInventoryReq : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("customAttributes")]
        public Dictionary<string, object>? CustomAttributes { get; set; }

        [JsonPropertyName("qty")]
        public int? Qty { get; set; }

        [JsonPropertyName("serverCustomAttributes")]
        public Dictionary<string, object>? ServerCustomAttributes { get; set; }

        [JsonPropertyName("slotId")]
        public string? SlotId { get; set; }

        [JsonPropertyName("slotUsed")]
        public int? SlotUsed { get; set; }

        [JsonPropertyName("source")]
        [JsonStringEnum]
        public ApimodelsSaveItemToInventoryReqSource? Source { get; set; }

        [JsonPropertyName("sourceItemId")]
        public string? SourceItemId { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }

    public class ApimodelsSaveItemToInventoryReq<T1, T2> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("customAttributes")]
        public T1? CustomAttributes { get; set; }

        [JsonPropertyName("qty")]
        public int? Qty { get; set; }

        [JsonPropertyName("serverCustomAttributes")]
        public T2? ServerCustomAttributes { get; set; }

        [JsonPropertyName("slotId")]
        public string? SlotId { get; set; }

        [JsonPropertyName("slotUsed")]
        public int? SlotUsed { get; set; }

        [JsonPropertyName("source")]
        [JsonStringEnum]
        public ApimodelsSaveItemToInventoryReqSource? Source { get; set; }

        [JsonPropertyName("sourceItemId")]
        public string? SourceItemId { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }


    public class ApimodelsSaveItemToInventoryReqSource : StringEnum<ApimodelsSaveItemToInventoryReqSource>
    {
        public static readonly ApimodelsSaveItemToInventoryReqSource ECOMMERCE
            = new ApimodelsSaveItemToInventoryReqSource("ECOMMERCE");

        public static readonly ApimodelsSaveItemToInventoryReqSource OTHER
            = new ApimodelsSaveItemToInventoryReqSource("OTHER");


        public static implicit operator ApimodelsSaveItemToInventoryReqSource(string value)
        {
            return NewValue(value);
        }

        public ApimodelsSaveItemToInventoryReqSource(string enumValue)
            : base(enumValue)
        {

        }
    }
}