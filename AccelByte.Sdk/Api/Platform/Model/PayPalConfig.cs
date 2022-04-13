// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PayPalConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clientID")]
        public string? ClientID { get; set; }

        [JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }

        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("webHookId")]
        public string? WebHookId { get; set; }

    }
}