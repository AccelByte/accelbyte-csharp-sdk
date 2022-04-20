// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformPaymentCallbackConfig_OpExts
    {
        public static Platform.Model.PaymentCallbackConfigInfo? Execute(
            this GetPaymentCallbackConfig.GetPaymentCallbackConfigBuilder builder,
            string namespace_
        )
        {
            GetPaymentCallbackConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.PaymentCallbackConfig)builder.WrapperObject!).GetPaymentCallbackConfig(op);
        }

        public static Platform.Model.PaymentCallbackConfigInfo? Execute(
            this UpdatePaymentCallbackConfig.UpdatePaymentCallbackConfigBuilder builder,
            string namespace_
        )
        {
            UpdatePaymentCallbackConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.PaymentCallbackConfig)builder.WrapperObject!).UpdatePaymentCallbackConfig(op);
        }

    }
}