// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class PagedRetrieveUserAcceptedAgreementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<RetrieveUserAcceptedAgreementResponse>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}