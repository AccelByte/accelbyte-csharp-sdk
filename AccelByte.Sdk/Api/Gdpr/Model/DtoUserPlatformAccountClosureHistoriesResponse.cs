// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class DtoUserPlatformAccountClosureHistoriesResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<DtoUserPlatformAccountClosureHistory>? Data { get; set; }

        [JsonPropertyName("pagination")]
        public ModelsPagination? Pagination { get; set; }

    }


}