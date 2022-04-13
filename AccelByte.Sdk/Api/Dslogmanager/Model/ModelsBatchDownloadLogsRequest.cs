// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsBatchDownloadLogsRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Downloads")]
        public List<ModelsDownloadLogsRequest>? Downloads { get; set; }

    }
}