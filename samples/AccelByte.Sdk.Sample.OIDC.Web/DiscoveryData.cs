// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
using System.Net.Http;

namespace AccelByte.Sdk.Sample.OIDC.Web
{
    public class DiscoveryData
    {
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; } = String.Empty;

        [JsonPropertyName("jwks_uri")]
        public string JWKSUri { get; set; } = String.Empty;

        [JsonPropertyName("authorization_endpoint")]
        public string AuthEndpoint { get; set; } = String.Empty;

        [JsonPropertyName("token_endpoint")]
        public string TokenEndpoint { get; set; } = String.Empty;

        [JsonPropertyName("registration_endpoint")]
        public string RegistrationEndpoint { get; set; } = String.Empty;

        [JsonPropertyName("introspection_endpoint")]
        public string IntrospectionEndpoint { get; set; } = String.Empty;

        [JsonPropertyName("userinfo_endpoint")]
        public string UserInfoEndpoint { get; set; } = String.Empty;

        [JsonPropertyName("scopes_supported")]
        public List<string> SupportedScopes { get; set; } = new List<string>();

        [JsonPropertyName("grant_types_supported")]
        public List<string> SupportedGrantTypes { get; set; } = new List<string>();

        [JsonPropertyName("claims_supported")]
        public List<string> SupportedClaims { get; set; } = new List<string>();

        public static DiscoveryData Retrieve(HttpClient httpClient, string discoveryUrl)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, discoveryUrl);

            HttpResponseMessage response = httpClient.Send(req);
            string jsonString = AccelByte.Sdk.Core.Util.Helper.ConvertInputStreamToString(response.Content.ReadAsStream());
            return JsonSerializer.Deserialize<DiscoveryData>(jsonString)!;
        }
    }
}