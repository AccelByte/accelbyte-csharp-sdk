// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Match2.Model
{
    public class ApiBackFillAcceptRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("acceptedTicketIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? AcceptedTicketIds { get; set; }

        [JsonPropertyName("proposalId")]
        public string? ProposalId { get; set; }

        [JsonPropertyName("stop")]
        public bool? Stop { get; set; }

    }


}