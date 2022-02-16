// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsAgentType : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AgentType")]
        public int? AgentType { get; set; }
        
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        
    }
}