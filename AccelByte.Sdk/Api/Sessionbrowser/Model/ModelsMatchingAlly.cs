// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsMatchingAlly : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("matching_parties")]
        public List<ModelsMatchingParty>? MatchingParties { get; set; }

    }
}