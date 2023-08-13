// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiPagingInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currentPage")]
        public int? CurrentPage { get; set; }

        [JsonPropertyName("hasNext")]
        public bool? HasNext { get; set; }

        [JsonPropertyName("hasPages")]
        public bool? HasPages { get; set; }

        [JsonPropertyName("hasPrev")]
        public bool? HasPrev { get; set; }

        [JsonPropertyName("next")]
        public string? Next { get; set; }

        [JsonPropertyName("pageNums")]
        public List<int>? PageNums { get; set; }

        [JsonPropertyName("previous")]
        public string? Previous { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }

    }


}