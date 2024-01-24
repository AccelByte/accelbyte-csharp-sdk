// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Core
{
    public class AccelByteConfig
    {
        public static string DefaultFlightId { get; private set; }

        static AccelByteConfig()
        {
            DefaultFlightId = Guid.NewGuid().ToString();
        }

        public void UpdateDefaultFlightId(string flightId)
        {
            DefaultFlightId = flightId;
        }



        public ICredentialRepository? Credential { get; set; }

        public ITokenValidator? TokenValidator { get; set; }

        public AccelByteConfig(IHttpClient httpClient,
                ITokenRepository tokenRepository,
                IConfigRepository configRepository)
        {
            HttpClient = httpClient;
            TokenRepository = tokenRepository;
            ConfigRepository = configRepository;
        }

        public IHttpClient HttpClient { get; }

        public ITokenRepository TokenRepository { get; }

        public IConfigRepository ConfigRepository { get; }

        public bool UseRefreshIfPossible { get; set; } = false;

        public Action<LoginType, AuthActionType, TokenData?, AccelByteSDK>? OnAfterLogin { get; set; } = null;
    }
}