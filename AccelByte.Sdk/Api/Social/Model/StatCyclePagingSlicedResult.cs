// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatCyclePagingSlicedResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<StatCycleInfo>? Data { get; set; }

        [JsonPropertyName("paging")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Paging? Paging { get; set; }

    }


}