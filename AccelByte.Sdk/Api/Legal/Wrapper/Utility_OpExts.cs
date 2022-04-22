// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalUtility_OpExts
    {
        public static Legal.Model.LegalReadinessStatusResponse? Execute(
            this CheckReadiness.CheckReadinessBuilder builder
        )
        {
            CheckReadiness op = builder.Build(
            );

            return ((Legal.Wrapper.Utility)builder.WrapperObject!).CheckReadiness(op);
        }

    }
}