// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Challenge.Model
{
    public class ModelEvaluatePlayerProgressionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("userIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? UserIds { get; set; }

    }


}