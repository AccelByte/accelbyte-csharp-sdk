// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ClientmodelClientUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ClientName")]
        public string? ClientName { get; set; }
        
        [JsonPropertyName("RedirectUri")]
        public string? RedirectUri { get; set; }
        
    }
}