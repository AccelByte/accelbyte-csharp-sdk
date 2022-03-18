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
    public class IntegrationTestCredentialRepository : ICredentialRepository
    {
        public static readonly IntegrationTestCredentialRepository Admin = new IntegrationTestCredentialRepository("AB_USERNAME", "AB_PASSWORD");

        private string _EnvName_Username;

        private string _EnvName_Password;

        public string Username
        {
            get
            {
                string? temp = Environment.GetEnvironmentVariable(_EnvName_Username);
                if (temp != null)
                    return UnQuote(temp);
                else
                    throw new Exception($"Environment variable not found (variable: {_EnvName_Username})");
            }
        }

        public string Password
        {
            get
            {
                string? temp = Environment.GetEnvironmentVariable(_EnvName_Password);
                if (temp != null)
                    return UnQuote(temp);
                else
                    throw new Exception($"Environment variable not found (variable: {_EnvName_Password})");
            }
        }

        public string UserId { get; set; } = String.Empty;

        private string UnQuote(string value)
        {
            if ((value.Substring(0, 1) == "\"") && (value.Substring(value.Length - 1, 1) == "\""))
                return value.Substring(1, value.Length - 2);
            else
                return value;
        }

        public IntegrationTestCredentialRepository(string envUsername, string envPassword)
        {
            _EnvName_Username = envUsername;
            _EnvName_Password = envPassword;
        }
    }
}