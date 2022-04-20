// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamOAuth20Extension_OpExts
    {
        public static string Execute(
            this UserAuthenticationV3.UserAuthenticationV3Builder builder,
            string password,
            string requestId,
            string userName
        )
        {
            UserAuthenticationV3 op = builder.Build(
                password,
                requestId,
                userName
            );

            return ((Iam.Wrapper.OAuth20Extension)builder.WrapperObject!).UserAuthenticationV3(op);
        }

        public static Iam.Model.OauthmodelCountryLocationResponse? Execute(
            this GetCountryLocationV3.GetCountryLocationV3Builder builder
        )
        {
            GetCountryLocationV3 op = builder.Build(
            );

            return ((Iam.Wrapper.OAuth20Extension)builder.WrapperObject!).GetCountryLocationV3(op);
        }

        public static void Execute(
            this Logout.LogoutBuilder builder
        )
        {
            Logout op = builder.Build(
            );

            ((Iam.Wrapper.OAuth20Extension)builder.WrapperObject!).Logout(op);
        }

        public static string Execute(
            this PlatformAuthenticationV3.PlatformAuthenticationV3Builder builder,
            string platformId,
            string state
        )
        {
            PlatformAuthenticationV3 op = builder.Build(
                platformId,
                state
            );

            return ((Iam.Wrapper.OAuth20Extension)builder.WrapperObject!).PlatformAuthenticationV3(op);
        }

    }
}