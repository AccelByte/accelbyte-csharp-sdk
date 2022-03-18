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

        public static readonly IntegrationTestConfigRepository Server = new IntegrationTestConfigRepository("AB_SERVER_CLIENT_ID", "AB_SERVER_CLIENT_SECRET", "AB_SERVER_NAMESPACE");

        public static readonly IntegrationTestConfigRepository Admin = new IntegrationTestConfigRepository("AB_CLIENT_ID", "AB_CLIENT_SECRET", "AB_NAMESPACE");


        private string _EnvName_ClientId;

        private string _EnvName_ClientSecret;

        private string _EnvName_Namespace;

        public string BaseUrl
        {
            get
            {
                string? temp = Environment.GetEnvironmentVariable("AB_BASE_URL");
                if (temp != null)
                    return UnQuote(temp);
                else
                    throw new Exception($"Environment variable not found (variable: AB_BASE_URL)");
            }
        }

        public string ClientId
        {
            get
            {
                string? temp = Environment.GetEnvironmentVariable(_EnvName_ClientId);
                if (temp != null)
                    return UnQuote(temp);
                else
                    throw new Exception($"Environment variable not found (variable: {_EnvName_ClientId})");
            }
        }

        public string ClientSecret
        {
            get
            {
                string? temp = Environment.GetEnvironmentVariable(_EnvName_ClientSecret);
                if (temp != null)
                    return UnQuote(temp);
                else
                    throw new Exception($"Environment variable not found (variable: {_EnvName_ClientSecret})");
            }
        }

        public string AppName
        {
            get
            {
                string? temp = Environment.GetEnvironmentVariable("AB_APP_NAME");
                if (temp != null)
                    return UnQuote(temp);
                else
                    throw new Exception($"Environment variable not found (variable: AB_APP_NAME)");
            }
        }

        public string Namespace
        {
            get
            {
                string? aNamespace = Environment.GetEnvironmentVariable(_EnvName_Namespace);
                if (aNamespace != null)
                    return UnQuote(aNamespace);
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

        private string UnQuote(string value)
        {
            if ((value.Substring(0, 1) == "\"") && (value.Substring(value.Length - 1, 1) == "\""))
                return value.Substring(1, value.Length - 2);
            else
                return value;
        }

        private IntegrationTestConfigRepository(string envClientId, string envClientSecret, string envNamespace)
        {
            _EnvName_ClientId = UnQuote(envClientId);
            _EnvName_ClientSecret = UnQuote(envClientSecret);
            _EnvName_Namespace = UnQuote(envNamespace);
        }
    }
}