// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Inventory.Model
{
    public class ApimodelsMoveItemsReq : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("items")]
        public List<ApimodelsTradeItem>? Items { get; set; }

        [JsonPropertyName("srcInventoryId")]
        public string? SrcInventoryId { get; set; }

    }


}