// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Inventory.Model
{
    public class ApimodelsListTagsResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ApimodelsCreateTagResp>? Data { get; set; }

        [JsonPropertyName("paging")]
        public ApimodelsPaging? Paging { get; set; }

    }


}