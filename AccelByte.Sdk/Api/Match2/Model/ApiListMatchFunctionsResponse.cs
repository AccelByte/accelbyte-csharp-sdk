// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Match2.Model
{
    public class ApiListMatchFunctionsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("configs")]
        public List<ApiMatchFunctionConfig>? Configs { get; set; }

        [JsonPropertyName("functions")]
        public List<string>? Functions { get; set; }

        [JsonPropertyName("pagination")]
        public ModelsPagination? Pagination { get; set; }

    }
}