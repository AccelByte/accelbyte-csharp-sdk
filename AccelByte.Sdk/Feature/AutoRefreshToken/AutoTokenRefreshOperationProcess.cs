// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Pipeline;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class AutoTokenRefreshOperationProcess : IOperationProcessPipeline
    {
        public IOperationProcessPipeline? Next { get; set; }

        public Operation Handle(Operation operation, AccelByteSDK sdk)
        {
            AccelByteConfig config = sdk.Configuration;
            if (config.TokenRepository is IRefreshTokenRepository)
            {
                IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)config.TokenRepository;
                if (refreshTokenRepo.RefreshTokenEnabled)
                {
                    if (refreshTokenRepo.HasToken)
                    {
                        if (refreshTokenRepo.IsTokenExpiring)
                        {
                            if (!refreshTokenRepo.IsRefreshOnProgress)
                            {
                                refreshTokenRepo.IsRefreshOnProgress = true;
                                if (refreshTokenRepo.LoginType == LoginType.User)
                                {
                                    if (refreshTokenRepo.HasRefreshToken)
                                    {
                                        sdk.RefreshAccessToken(refreshTokenRepo.RefreshToken, (token) =>
                                        {
                                            refreshTokenRepo.UpdateRefreshToken(token.RefreshToken!, token.ExpiresIn!.Value);
                                        });
                                    }
                                    else
                                        sdk.LoginUser(true, refreshTokenRepo.RefreshThreshold);
                                }
                                else if (refreshTokenRepo.LoginType == LoginType.Client)
                                {
                                    sdk.LoginClient(true, refreshTokenRepo.RefreshThreshold);
                                }
                            }                            
                        }
                    }
                }                
            }

            return operation;
        }
    }
}