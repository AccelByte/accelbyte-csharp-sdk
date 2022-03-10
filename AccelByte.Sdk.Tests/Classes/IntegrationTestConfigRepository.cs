// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;

namespace AccelByte.Sdk.Tests
{
    public class IntegrationTestConfigRepository : IConfigRepository
    {
        public static readonly IntegrationTestConfigRepository Client = new IntegrationTestConfigRepository("AB_CLIENT_ID", "AB_CLIENT_SECRET", "AB_CLIENT_NAMESPACE");

        public static readonly IntegrationTestConfigRepository Server = new IntegrationTestConfigRepository("AB_SERVER_CLIENT_ID", "AB_SERVER_CLIENT_SECRET", "AB_PUBLISHER_NAMESPACE");

        public static readonly IntegrationTestConfigRepository Admin = new IntegrationTestConfigRepository("AB_ADMIN_CLIENT_ID", "AB_ADMIN_CLIENT_SECRET", "AB_ADMIN_NAMESPACE");


        private string _EnvName_ClientId;

        private string _EnvName_ClientSecret;

        private string _EnvName_Namespace;

        public string BaseUrl
        {
            get => Environment.GetEnvironmentVariable("AB_BASE_URL") ??
                    throw new Exception($"Environment variable not found (variable: AB_BASE_URL)");
        }

        public string ClientId
        {
            get => Environment.GetEnvironmentVariable(_EnvName_ClientId) ??
                    throw new Exception($"Environment variable not found (variable: {_EnvName_ClientId})");
        }

        public string ClientSecret
        {
            get => Environment.GetEnvironmentVariable(_EnvName_ClientSecret) ??
                     throw new Exception($"Environment variable not found (variable: {_EnvName_ClientSecret})");
        }

        public string AppName
        {
            get => Environment.GetEnvironmentVariable("AB_APP_NAME") ??
                     throw new Exception($"Environment variable not found (variable: AB_APP_NAME)");
        }

        public string Namespace
        {
            get
            {
                string? aNamespace = Environment.GetEnvironmentVariable(_EnvName_Namespace);
                if (aNamespace != null)
                    return aNamespace;
                else
                    return String.Empty;
            }
        }

        public string TraceIdVersion
        {
            get
            {
                string? aVersion = Environment.GetEnvironmentVariable("AB_TRACEID_VERSION");
                if (aVersion == null)
                    return "1";
                else
                    return aVersion;
            }
        }

        public bool EnableTraceId
        {
            get
            {
                string? aEnable = Environment.GetEnvironmentVariable("AB_ENABLE_TRACEID");
                if (aEnable == null)
                    return true;
                else
                    return (aEnable.Trim() == "1");
            }
        }

        public bool EnableUserAgentInfo
        {
            get
            {
                string? aEnable = Environment.GetEnvironmentVariable("AB_ENABLE_USERAGENT");
                if (aEnable == null)
                    return true;
                else
                    return (aEnable.Trim() == "1");
            }
        }

        public IHttpLogger? Logger { get; set; } = null;

        private IntegrationTestConfigRepository(string envClientId, string envClientSecret, string envNamespace)
        {
            _EnvName_ClientId = envClientId;
            _EnvName_ClientSecret = envClientSecret;
            _EnvName_Namespace = envNamespace;
        }
    }
}