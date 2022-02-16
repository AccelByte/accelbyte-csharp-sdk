// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsRequestMatchParty : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("party_attributes")]
        public Dictionary<string, object>? PartyAttributes { get; set; }
        
        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }
        
        [JsonPropertyName("party_members")]
        public List<ModelsRequestMatchMember>? PartyMembers { get; set; }
        
    }
}