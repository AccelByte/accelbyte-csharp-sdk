// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamSSOSAML20_OpExts
    {
        public static string Execute(
            this PlatformAuthenticateSAMLV3Handler.PlatformAuthenticateSAMLV3HandlerBuilder builder,
            string platformId,
            string state
        )
        {
            PlatformAuthenticateSAMLV3Handler op = builder.Build(
                platformId,
                state
            );

            return ((Iam.Wrapper.SSOSAML20)builder.WrapperObject!).PlatformAuthenticateSAMLV3Handler(op);
        }

    }
}