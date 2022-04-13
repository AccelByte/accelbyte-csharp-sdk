// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsGetGroupMemberListResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsGetUserGroupInformationResponseV1>? Data { get; set; }

        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }

    }
}