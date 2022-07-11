// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace AccelByte.Sdk.Sample.OIDC.Web
{
    public class ProviderSpecification
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = String.Empty;

        [JsonPropertyName("key")]
        public string Key { get; set; } = String.Empty;

        [JsonPropertyName("discovery_url")]
        public string DiscoveryUrl { get; set; } = String.Empty;

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; } = String.Empty;

        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; } = String.Empty;

        [JsonPropertyName("scope")]
        public string Scope { get; set; } = String.Empty;

        [JsonPropertyName("platform_id")]
        public string ABPlatformId { get; set; } = String.Empty;

        public static List<ProviderSpecification> LoadProviderSpecifications(string fileName)
        {
            String fContent = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<ProviderSpecification>>(fContent, new JsonSerializerOptions()
            {
                AllowTrailingCommas = true,
                ReadCommentHandling = JsonCommentHandling.Skip
            })!;
        }
    }

    public class ProviderSpecification_FE
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = String.Empty;

        [JsonPropertyName("key")]
        public string Key { get; set; } = String.Empty;

        [JsonPropertyName("discovery_url")]
        public string DiscoveryUrl { get; set; } = String.Empty;

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; } = String.Empty;

        [JsonPropertyName("scope")]
        public string Scope { get; set; } = String.Empty;

        internal ProviderSpecification_FE(ProviderSpecification pspec)
        {
            Name = pspec.Name;
            Key = pspec.Key;
            DiscoveryUrl = pspec.DiscoveryUrl;
            ClientId = pspec.ClientId;
            Scope = pspec.Scope;
        }
    }

    public static class ProviderSpecification_Extensions
    {
        public static string ToJSONStringForFrontend(this List<ProviderSpecification> source, bool encodeBase64)
        {
            List<ProviderSpecification_FE> rList = new List<ProviderSpecification_FE>();
            foreach (var spec in source)
                rList.Add(new ProviderSpecification_FE(spec));
            string sJson = JsonSerializer.Serialize(rList);
            if (encodeBase64)
            {
                byte[] bJson = Encoding.UTF8.GetBytes(sJson);
                return Convert.ToBase64String(bJson);
            }
            else
                return sJson;
        }

        public static Dictionary<string, ProviderSpecification> ToDictionary(this List<ProviderSpecification> source)
        {
            Dictionary<string, ProviderSpecification> result = new Dictionary<string, ProviderSpecification>();
            foreach (var spec in source)
                result.Add(spec.Key, spec);
            return result;
        }
    }
}