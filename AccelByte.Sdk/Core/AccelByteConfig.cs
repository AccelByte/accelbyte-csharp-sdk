// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Client;

namespace AccelByte.Sdk.Core
{
    public class AccelByteConfig
    {
        public ICredentialRepository? Credential { get; set; }

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
    }
}