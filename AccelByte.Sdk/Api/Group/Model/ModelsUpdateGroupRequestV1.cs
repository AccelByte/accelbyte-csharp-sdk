// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsUpdateGroupRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("customAttributes")]
        public ModelsUpdateGroupRequestV1CustomAttributes? CustomAttributes { get; set; }
        
        [JsonPropertyName("groupDescription")]
        public string? GroupDescription { get; set; }
        
        [JsonPropertyName("groupIcon")]
        public string? GroupIcon { get; set; }
        
        [JsonPropertyName("groupName")]
        public string? GroupName { get; set; }
        
        [JsonPropertyName("groupRegion")]
        public string? GroupRegion { get; set; }
        
        [JsonPropertyName("groupType")]
        public string? GroupType { get; set; }
        
    }
}