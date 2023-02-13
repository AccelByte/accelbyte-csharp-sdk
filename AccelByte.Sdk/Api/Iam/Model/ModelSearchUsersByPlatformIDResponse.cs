// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelSearchUsersByPlatformIDResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Data")]
        public List<AccountcommonUserSearchByPlatformIDResult>? Data { get; set; }

        [JsonPropertyName("Paging")]
        public AccountcommonPagination? Paging { get; set; }

    }


}