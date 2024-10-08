// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CampaignBatchNameInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("batchName")]
        public string? BatchName { get; set; }

        [JsonPropertyName("batchNos")]
        public List<int>? BatchNos { get; set; }

    }


}