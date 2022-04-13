// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsEventResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Data")]
        public List<ModelsEvent>? Data { get; set; }

        [JsonPropertyName("Pagination")]
        public ModelsPagination? Pagination { get; set; }

    }
}