// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionhistory.Model
{
    public class ModelsSessionConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ClientVersion")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("Deployment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Deployment { get; set; }

        [JsonPropertyName("InactiveTimeout")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("InviteTimeout")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("Joinability")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Joinability { get; set; }

        [JsonPropertyName("MaxPlayers")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("MinPlayers")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("Name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("Persistent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Persistent { get; set; }

        [JsonPropertyName("RequestedRegions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("Type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }

    }


}