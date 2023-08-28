// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Inventory.Model
{
    public class ApimodelsInventoryResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("inventoryConfigurationCode")]
        public string? InventoryConfigurationCode { get; set; }

        [JsonPropertyName("inventoryConfigurationId")]
        public string? InventoryConfigurationId { get; set; }

        [JsonPropertyName("maxSlots")]
        public int? MaxSlots { get; set; }

        [JsonPropertyName("maxUpgradeSlots")]
        public int? MaxUpgradeSlots { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("usedCountSlots")]
        public int? UsedCountSlots { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }


}