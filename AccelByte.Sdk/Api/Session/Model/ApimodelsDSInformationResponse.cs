// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsDSInformationResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("CreatedAt")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("RequestedAt")]
        public string? RequestedAt { get; set; }

        [JsonPropertyName("Server")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsGameServer? Server { get; set; }

        [JsonPropertyName("Status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Status { get; set; }

        [JsonPropertyName("StatusV2")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusV2 { get; set; }

    }


}