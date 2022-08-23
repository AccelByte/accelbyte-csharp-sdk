// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Core.Repository
{
    public class JsonCredentialRepository : ICredentialRepository
    {
        [JsonPropertyName("username")]
        public string Username { get; set; } = String.Empty;

        [JsonPropertyName("password")]
        public string Password { get; set; } = String.Empty;

        [JsonIgnore]
        public string UserId { get; set; } = String.Empty;

        public static JsonCredentialRepository LoadFromString(string json)
        {
            JsonCredentialRepository? result = JsonSerializer.Deserialize<JsonCredentialRepository>(json);
            if (result == null)
                throw new Exception("Could not deserialize credential.");
            return result;
        }

        public static JsonCredentialRepository LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new Exception("Config file [" + fileName + "] does not exists.");
            string json = File.ReadAllText(fileName);
            JsonCredentialRepository? result = JsonSerializer.Deserialize<JsonCredentialRepository>(json);
            if (result == null)
                throw new Exception("Could not deserialize credential from file.");
            return result;
        }

        public static JsonCredentialRepository LoadFromDefaultFile()
        {
            string bPath = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!;
            return LoadFromFile(Path.Combine(bPath, "ab_credential.json"));
        }
    }
}

namespace AccelByte.Sdk.Core
{
    public partial class AccelByteSdkBuilder
    {
        public AccelByteSdkBuilder UseJsonCredentialRepository()
        {
            _Credential = JsonCredentialRepository.LoadFromDefaultFile();
            return this;
        }

        public AccelByteSdkBuilder UseJsonCredentialRepository(string fileName)
        {
            _Credential = JsonCredentialRepository.LoadFromFile(fileName);
            return this;
        }
    }
}