// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionhistory.Model
{
    public class ApimodelsGameSessionDetailQueryResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ApimodelsGameSessionDetail>? Data { get; set; }

        [JsonPropertyName("paging")]
        public ApimodelsPagination? Paging { get; set; }

    }


}