// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{    
    public static class SdkBuilder_ExtensionMethods
    {
        public static AccelByteSdkBuilder UseLocalTokenValidator(this AccelByteSdkBuilder builder)
        {
            builder.SetTokenValidator(new LocalTokenValidator());
            return builder;
        }

        public static AccelByteSdkBuilder UseAutoRefreshForTokenRevocationList(this AccelByteSdkBuilder builder)
        {
            TokenRevocationListRefresher refresher = new TokenRevocationListRefresher(60000);
            builder.RegisterService(refresher);
            return builder;
        }

        public static AccelByteSdkBuilder UseAutoRefreshForTokenRevocationList(this AccelByteSdkBuilder builder, int refreshInterval)
        {
            TokenRevocationListRefresher refresher = new TokenRevocationListRefresher(refreshInterval);
            builder.RegisterService(refresher);
            return builder;
        }
    }
}
