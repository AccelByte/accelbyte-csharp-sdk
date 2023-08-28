// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public static class SdkBuilder_ExtensionMethods
    {
        public static AccelByteSdkBuilder<T> UseLocalTokenValidator<T>(this AccelByteSdkBuilder<T> builder) where T : AccelByteSDK
        {
            builder.SetTokenValidator(new LocalTokenValidator());
            return builder;
        }

        public static AccelByteSdkBuilder<T> UseAutoRefreshForTokenRevocationList<T>(this AccelByteSdkBuilder<T> builder) where T : AccelByteSDK
        {
            TokenRevocationListRefresher refresher = new TokenRevocationListRefresher(60000);
            builder.RegisterService(refresher);
            return builder;
        }

        public static AccelByteSdkBuilder<T> UseAutoRefreshForTokenRevocationList<T>(this AccelByteSdkBuilder<T> builder, int refreshInterval) where T : AccelByteSDK
        {
            TokenRevocationListRefresher refresher = new TokenRevocationListRefresher(refreshInterval);
            builder.RegisterService(refresher);
            return builder;
        }
    }

    public static class Sdk_ExtensionMethods
    {
        public static AccessTokenPayload? ParseAccessToken(this AccelByteSDK sdk, string accessToken, bool validateFirst)
        {
            var validator = new LocalTokenValidator();
            return validator.ParseAccessToken(sdk, accessToken, validateFirst);
        }
    }
}
