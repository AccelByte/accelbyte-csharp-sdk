// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformRevocation_OpExts
    {
        public static Platform.Model.RevocationConfigInfo? Execute(
            this GetPaymentCallbackConfig1.GetPaymentCallbackConfig1Builder builder,
            string namespace_
        )
        {
            GetPaymentCallbackConfig1 op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Revocation)builder.WrapperObject!).GetPaymentCallbackConfig1(op);
        }
        public static Platform.Model.RevocationConfigInfo? Execute(
            this UpdateRevocationConfig.UpdateRevocationConfigBuilder builder,
            string namespace_
        )
        {
            UpdateRevocationConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Revocation)builder.WrapperObject!).UpdateRevocationConfig(op);
        }
        public static void Execute(
            this DeleteRevocationConfig.DeleteRevocationConfigBuilder builder,
            string namespace_
        )
        {
            DeleteRevocationConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.Revocation)builder.WrapperObject!).DeleteRevocationConfig(op);
        }
        public static Platform.Model.RevocationHistoryPagingSlicedResult? Execute(
            this QueryRevocationHistories.QueryRevocationHistoriesBuilder builder,
            string namespace_
        )
        {
            QueryRevocationHistories op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Revocation)builder.WrapperObject!).QueryRevocationHistories(op);
        }
        public static Platform.Model.RevocationResult? Execute(
            this DoRevocation.DoRevocationBuilder builder,
            string namespace_,
            string userId
        )
        {
            DoRevocation op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Revocation)builder.WrapperObject!).DoRevocation(op);
        }
    }
}