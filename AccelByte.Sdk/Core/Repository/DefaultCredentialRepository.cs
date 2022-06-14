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
    public class DefaultCredentialRepository : ICredentialRepository, IResettableCredentialRepository
    {
        private const string CLIENT_USERNAME = "AB_USERNAME";

        private const string CLIENT_PASSWORD = "AB_PASSWORD";

        private string _Username = String.Empty;

        private string _Password = String.Empty;

        public string Username
        {
            get
            {
                if (_Username == String.Empty)
                {
                    _Username = Environment.GetEnvironmentVariable(CLIENT_USERNAME) ??
                        throw new Exception($"Environment variable not found (variable: {CLIENT_USERNAME})");
                }
                return _Username;
            }
        }

        public string Password
        {
            get
            {
                if (_Password == String.Empty)
                {
                    _Password = Environment.GetEnvironmentVariable(CLIENT_PASSWORD) ??
                        throw new Exception($"Environment variable not found (variable: {CLIENT_PASSWORD})");
                }
                return _Password;
            }
        }

        public string UserId { get; set; } = String.Empty;

        public void SetUsernameAndPassword(string username, string password)
        {
            _Username = username;
            _Password = password;
        }
    }
}