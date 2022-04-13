// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUpdatePermissionScheduleRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("SchedAction")]
        public int? SchedAction { get; set; }

        [JsonPropertyName("SchedCron")]
        public string? SchedCron { get; set; }

        [JsonPropertyName("SchedRange")]
        public List<string>? SchedRange { get; set; }

    }
}