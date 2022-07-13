// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public static class Sdk_ExtensionMethods
    {
        public static bool LoginUser(this AccelByteSDK sdk, string username, string password, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginUser(username, password, (token) =>
            {
                if (autoRefresh)
                {
                    if (sdk.Configuration.Credential == null)
                        sdk.Configuration.Credential = new DefaultCredentialRepository();

                    ICredentialRepository credentialRepo = sdk.Configuration.Credential;
                    if (credentialRepo is IResettableCredentialRepository)
                        ((IResettableCredentialRepository)credentialRepo).SetUsernameAndPassword(username, password);

                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(token.RefreshToken!, refreshThreshold);
                    }
                }
            });
        }

        public static bool LoginUser(this AccelByteSDK sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginUser((token) =>
            {
                if (autoRefresh)
                {
                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(token.RefreshToken!, refreshThreshold);
                    }
                }
            });
        }

        public static bool LoginClient(this AccelByteSDK sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginClient((token) =>
            {
                if (autoRefresh)
                {
                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(String.Empty, refreshThreshold);
                    }
                }
            });
        }

        public static bool LoginPlatform(this AccelByteSDK sdk, string platformId, string platformToken, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginPlatform(platformId, platformToken, (token) =>
              {
                  if (autoRefresh)
                  {
                      ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                      if (tokenRepo is IRefreshTokenRepository)
                      {
                          IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                          refreshTokenRepo.RefreshTokenEnabled = true;
                          refreshTokenRepo.StoreRefreshToken(token.RefreshToken!, refreshThreshold);
                      }
                  }
              });
        }
    }

    public static class SdkBuilder_ExtensionMethods
    {
        public static AccelByteSdkBuilder UseAutoTokenRefresh(this AccelByteSdkBuilder builder)
        {
            builder.SetTokenRepository(new RefreshableTokenRepository());
            builder.AddOperationProcess(new AutoTokenRefreshOperationProcess());
            return builder;
        }
    }
}