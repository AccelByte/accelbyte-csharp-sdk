// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsServerLogs : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("std_err_logs")]
        public string? StdErrLogs { get; set; }

        [JsonPropertyName("std_out_logs")]
        public string? StdOutLogs { get; set; }

    }


}