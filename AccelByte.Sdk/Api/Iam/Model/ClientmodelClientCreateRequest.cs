// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ClientmodelClientCreateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ClientId")]
        public string? ClientId { get; set; }

        [JsonPropertyName("ClientName")]
        public string? ClientName { get; set; }

        [JsonPropertyName("ClientPermissions")]
        public List<AccountcommonPermission>? ClientPermissions { get; set; }

        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("RedirectUri")]
        public string? RedirectUri { get; set; }

        [JsonPropertyName("Secret")]
        public string? Secret { get; set; }

    }
}