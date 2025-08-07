// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Pipeline;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class AutoTokenRefreshOperationProcess : IOperationProcessPipeline, IOperationProcessPipelineAsync
    {
        public IOperationProcessPipeline? Next { get; set; }

        public AutoTokenRefreshOperationProcess() { }

        public Operation Handle(Operation operation, AccelByteSDK sdk)
        {
            AccelByteConfig config = sdk.Configuration;
            ITokenRepository tokenRepo = config.TokenRepository;

            if (config.TokenRepository is IRefreshTokenRepository refreshTokenRepo)
            {
                if (refreshTokenRepo.RefreshTokenEnabled)
                    refreshTokenRepo.DoRefreshToken(sdk, null, null, true);
            }

            return operation;
        }

        public async Task<Operation> HandleAsync(Operation operation, AccelByteSDK sdk)
        {
            AccelByteConfig config = sdk.Configuration;
            ITokenRepository tokenRepo = config.TokenRepository;

            if (config.TokenRepository is IRefreshTokenRepository refreshTokenRepo)
            {
                if (refreshTokenRepo.RefreshTokenEnabled)
                    await refreshTokenRepo.DoRefreshTokenAsync(sdk, null, null, true);
            }

            return operation;
        }
    }
}