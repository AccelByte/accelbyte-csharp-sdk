// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamSSO_OpExts
    {
        public static void Execute(
            this LoginSSOClient.LoginSSOClientBuilder builder,
            string platformId
        )
        {
            LoginSSOClient op = builder.Build(
                platformId
            );

            ((Iam.Wrapper.SSO)builder.WrapperObject!).LoginSSOClient(op);
        }

        public static void Execute(
            this LogoutSSOClient.LogoutSSOClientBuilder builder,
            string platformId
        )
        {
            LogoutSSOClient op = builder.Build(
                platformId
            );

            ((Iam.Wrapper.SSO)builder.WrapperObject!).LogoutSSOClient(op);
        }

    }
}