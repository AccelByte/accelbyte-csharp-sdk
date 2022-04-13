// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonPermission : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Action")]
        public int? Action { get; set; }

        [JsonPropertyName("Resource")]
        public string? Resource { get; set; }

        [JsonPropertyName("SchedAction")]
        public int? SchedAction { get; set; }

        [JsonPropertyName("SchedCron")]
        public string? SchedCron { get; set; }

        [JsonPropertyName("SchedRange")]
        public List<string>? SchedRange { get; set; }

    }
}