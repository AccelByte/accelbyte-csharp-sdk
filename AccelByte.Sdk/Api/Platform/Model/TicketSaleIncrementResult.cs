// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TicketSaleIncrementResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("maxSaleCount")]
        public int? MaxSaleCount { get; set; }

        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }


}