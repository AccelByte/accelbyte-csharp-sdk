// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
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
        [Obsolete("Token auto refresh is now configured via UseOnDemandTokenRefresh or UseBackgroundTokenRefresh method in sdk builder. `autoRefresh` and `refreshThreshold` parameter will be ignored.")]
        public static bool LoginUser(this AccelByteSDK sdk, string username, string password, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginUser(username, password);
        }

        [Obsolete("Token auto refresh is now configured via UseOnDemandTokenRefresh or UseBackgroundTokenRefresh method in sdk builder. `autoRefresh` and `refreshThreshold` parameter will be ignored.")]
        public static async Task<bool> LoginUserAsync(this AccelByteSDK sdk, string username, string password, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return await sdk.LoginUserAsync(username, password);
        }

        [Obsolete("Token auto refresh is now configured via UseOnDemandTokenRefresh or UseBackgroundTokenRefresh method in sdk builder. `autoRefresh` and `refreshThreshold` parameter will be ignored.")]
        public static bool LoginUser(this AccelByteSDK sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginUser();
        }

        [Obsolete("Token auto refresh is now configured via UseOnDemandTokenRefresh or UseBackgroundTokenRefresh method in sdk builder. `autoRefresh` and `refreshThreshold` parameter will be ignored.")]
        public static async Task<bool> LoginUserAsync(this AccelByteSDK sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return await sdk.LoginUserAsync();
        }

        [Obsolete("Token auto refresh is now configured via UseOnDemandTokenRefresh or UseBackgroundTokenRefresh method in sdk builder. `autoRefresh` and `refreshThreshold` parameter will be ignored.")]
        public static bool LoginClient(this AccelByteSDK sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginClient();
        }

        [Obsolete("Token auto refresh is now configured via UseOnDemandTokenRefresh or UseBackgroundTokenRefresh method in sdk builder. `autoRefresh` and `refreshThreshold` parameter will be ignored..")]
        public static async Task<bool> LoginClientAsync(this AccelByteSDK sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return await sdk.LoginClientAsync();
        }

        [Obsolete("Token auto refresh is now configured via UseOnDemandTokenRefresh or UseBackgroundTokenRefresh method in sdk builder. `autoRefresh` and `refreshThreshold` parameter will be ignored..")]
        public static bool LoginPlatform(this AccelByteSDK sdk, string platformId, string platformToken, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginPlatform(platformId, platformToken);
        }

        [Obsolete("Token auto refresh is now configured via UseOnDemandTokenRefresh or UseBackgroundTokenRefresh method in sdk builder. `autoRefresh` and `refreshThreshold` parameter will be ignored.")]
        public static async Task<bool> LoginPlatformAsync(this AccelByteSDK sdk, string platformId, string platformToken, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return await sdk.LoginPlatformAsync(platformId, platformToken);
        }
    }

    public static class SdkBuilder_ExtensionMethods
    {
        [Obsolete("Use 'UseOnDemandTokenRefresh' instead.")]
        public static AccelByteSdkBuilder<T> UseAutoTokenRefresh<T>(this AccelByteSdkBuilder<T> builder) where T : AccelByteSDK
        {
            builder.SetTokenRepository(new RefreshableTokenRepository());
            builder.AddOperationProcess(new AutoTokenRefreshOperationProcess());
            return builder;
        }

        [Obsolete("Use 'UseBackgroundTokenRefresh' instead.")]
        public static AccelByteSdkBuilder<T> UseScheduledTokenRefresh<T>(this AccelByteSdkBuilder<T> builder) where T : AccelByteSDK
        {
            builder.SetTokenRepository(new ScheduledRefreshTokenRepository());
            return builder;
        }

        [Obsolete("Use 'UseBackgroundTokenRefresh' instead.")]
        public static AccelByteSdkBuilder<T> UseScheduledTokenRefresh<T>(this AccelByteSdkBuilder<T> builder, Action onTokenRefreshed) where T : AccelByteSDK
        {
            builder.SetTokenRepository(new ScheduledRefreshTokenRepository(onTokenRefreshed));
            return builder;
        }

        /// <summary>
        /// Use on-demand token refresh. It will be enabled when OnDemandTokenRefreshOptions.IsEnabled is set to true. The default configuration sets this value to true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="opts"></param>
        /// <returns></returns>
        public static AccelByteSdkBuilder<T> UseOnDemandTokenRefresh<T>(this AccelByteSdkBuilder<T> builder, OnDemandTokenRefreshOptions opts)
            where T : AccelByteSDK
        {
            if (opts.IsEnabled)
            {
                builder.SetTokenRepository(new RefreshableTokenRepository(opts));
                builder.AddOperationProcess(new AutoTokenRefreshOperationProcess());
                return builder;
            }

            return builder;
        }

        /// <summary>
        /// se on-demand token refresh. The default value for `OnDemandTokenRefreshOptions` will be applied, so on-demand token refresh will be enabled.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="opts"></param>
        /// <returns></returns>
        public static AccelByteSdkBuilder<T> UseOnDemandTokenRefresh<T>(this AccelByteSdkBuilder<T> builder)
            where T : AccelByteSDK
        {
            OnDemandTokenRefreshOptions opts = OnDemandTokenRefreshOptions.Default;
            return builder.UseOnDemandTokenRefresh(opts);
        }

        /// <summary>
        /// Use on-demand token refresh. It will be enabled depending on the value of the RefreshTokenEnabled property in the token repository object passed as a parameter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <param name="opts"></param>
        /// <returns></returns>
        public static AccelByteSdkBuilder<T> UseOnDemandTokenRefresh<T, TRepo>(this AccelByteSdkBuilder<T> builder, TRepo tokenRepo)
            where T : AccelByteSDK
            where TRepo : BaseRefreshTokenRepository
        {
            if (tokenRepo.RefreshTokenEnabled)
            {
                builder.SetTokenRepository(tokenRepo);
                builder.AddOperationProcess(new AutoTokenRefreshOperationProcess());
                return builder;
            }

            return builder;
        }

        public static AccelByteSdkBuilder<T> UseBackgroundTokenRefresh<T>(this AccelByteSdkBuilder<T> builder, BackgroundTokenRefreshOptions opts)
            where T : AccelByteSDK
        {
            if (opts.IsEnabled)
            {
                builder.SetTokenRepository(new ScheduledRefreshTokenRepository(opts, true));
            }

            return builder;
        }

        public static AccelByteSdkBuilder<T> UseBackgroundTokenRefresh<T>(this AccelByteSdkBuilder<T> builder)
            where T : AccelByteSDK
        {
            BackgroundTokenRefreshOptions opts = BackgroundTokenRefreshOptions.Default;
            return builder.UseBackgroundTokenRefresh(opts);
        }
    }
}