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

namespace AccelByte.Sdk.Tests.Integration
{
    public class ExistingTestPlayer : ICredentialRepository, ITestPlayer
    {
        private readonly string _EnvPrefix;

        private readonly DefaultTokenRepository _TokenRepo;

        private readonly AccelByteSDK _Sdk;

        public string AccessToken
        {
            get => _TokenRepo.Token;
        }

        /// <summary>
        /// Create an ITestPlayer object from existing user's credential specified in environment variables.
        /// </summary>
        /// <param name="envPrefix">Environment var key prefix. E. g. AB_PLAYER1. Will be appended by `_USERNAME` for username and `_PASSWORD` for password.</param>
        /// <param name="doLogin">Set true to login immediately</param>
        public ExistingTestPlayer(string envPrefix, bool doLogin)
        {
            _EnvPrefix = envPrefix;
            _TokenRepo = new DefaultTokenRepository();

            _Sdk = AccelByteSDK.Builder
                .UseDefaultConfigRepository()
                .UseDefaultHttpClient()
                .SetCredentialRepository(this)
                .SetTokenRepository(_TokenRepo)
                .Build();

            if (doLogin)
                Login();
        }

        public void Login()
        {
            _Sdk.LoginUser();
        }

        public void Logout()
        {
            _Sdk.Logout();
        }

        public void Run(Action<AccelByteSDK, ITestPlayer> action)
        {
            action.Invoke(_Sdk, this);
        }

        #region ICredentialRepository implementation
        public string Username
        {
            get
            {
                return Environment.GetEnvironmentVariable($"{_EnvPrefix}_USERNAME") ??
                    throw new Exception($"Environment variable not found (variable: {_EnvPrefix}_USERNAME)");
            }
        }

        public string Password
        {
            get
            {
                return Environment.GetEnvironmentVariable($"{_EnvPrefix}_PASSWORD") ??
                    throw new Exception($"Environment variable not found (variable: {_EnvPrefix}_PASSWORD)");
            }
        }

        public string UserId { get; set; } = String.Empty;
        #endregion
    }
}