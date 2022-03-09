// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Repository
{
    public class DefaultCredentialRepository : ICredentialRepository
    {
        private const string CLIENT_USERNAME = "AB_USERNAME";

        private const string CLIENT_PASSWORD = "AB_PASSWORD";        

        public string Username
        {
            get => Environment.GetEnvironmentVariable(CLIENT_USERNAME) ??
                    throw new Exception($"Environment variable not found (variable: {CLIENT_USERNAME})");
        }

        public string Password
        {
            get => Environment.GetEnvironmentVariable(CLIENT_PASSWORD) ??
                    throw new Exception($"Environment variable not found (variable: {CLIENT_PASSWORD})");
        }
    }
}