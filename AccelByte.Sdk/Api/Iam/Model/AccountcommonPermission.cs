// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SchedAction { get; set; }

        [JsonPropertyName("SchedCron")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SchedCron { get; set; }

        [JsonPropertyName("SchedRange")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? SchedRange { get; set; }

    }


}