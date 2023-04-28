// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Reflection;

using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Logging;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Core.Repository
{
    public class JsonConfigRepository : IConfigRepository
    {
        [JsonPropertyName("base_url")]
        public string BaseUrl { get; set; } = String.Empty;

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; } = String.Empty;

        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; } = String.Empty;

        [JsonPropertyName("app_name")]
        public string AppName { get; set; } = String.Empty;

        [JsonPropertyName("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [JsonPropertyName("trace_id_ver")]
        public string TraceIdVersion { get; set; } = "1";

        [JsonPropertyName("enable_trace_id")]
        public bool EnableTraceId { get; set; } = true;

        [JsonPropertyName("enable_user_agent")]
        public bool EnableUserAgentInfo { get; set; } = true;

        [JsonIgnore]
        public IHttpLogger? Logger { get; set; } = null;

        public static JsonConfigRepository LoadFromString(string json)
        {
            JsonConfigRepository? result = JsonSerializer.Deserialize<JsonConfigRepository>(json);
            if (result == null)
                throw new Exception("Could not deserialize configuration.");
            return result;
        }

        public static JsonConfigRepository LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new Exception("Config file [" + fileName + "] does not exists.");
            string json = File.ReadAllText(fileName);
            JsonConfigRepository? result = JsonSerializer.Deserialize<JsonConfigRepository>(json);
            if (result == null)
                throw new Exception("Could not deserialize configuration from file.");
            return result;
        }

        public static JsonConfigRepository LoadFromDefaultFile()
        {
            string bPath = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!;
            return LoadFromFile(Path.Combine(bPath, "ab_config.json"));
        }
    }
}

namespace AccelByte.Sdk.Core
{
    public partial class AccelByteSdkBuilder<T>
    {
        public AccelByteSdkBuilder<T> UseJsonConfigRepository()
        {
            _ConfigRepository = JsonConfigRepository.LoadFromDefaultFile();
            return this;
        }

        public AccelByteSdkBuilder<T> UseJsonConfigRepository(string fileName)
        {
            _ConfigRepository = JsonConfigRepository.LoadFromFile(fileName);
            return this;
        }
    }
}