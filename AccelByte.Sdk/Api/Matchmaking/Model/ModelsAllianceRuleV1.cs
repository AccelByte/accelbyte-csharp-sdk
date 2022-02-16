// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsAllianceRuleV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("maxNumber")]
        public int? MaxNumber { get; set; }
        
        [JsonPropertyName("minNumber")]
        public int? MinNumber { get; set; }
        
        [JsonPropertyName("playerMaxNumber")]
        public int? PlayerMaxNumber { get; set; }
        
        [JsonPropertyName("playerMinNumber")]
        public int? PlayerMinNumber { get; set; }
        
    }
}