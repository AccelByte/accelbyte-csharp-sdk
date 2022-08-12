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
    public static class PlatformPaymentAccount_OpExts
    {
        public static List<Platform.Model.PaymentAccount>? Execute(
            this PublicGetPaymentAccounts.PublicGetPaymentAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetPaymentAccounts op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.PaymentAccount)builder.WrapperObject!).PublicGetPaymentAccounts(op);
        }

        public static void Execute(
            this PublicDeletePaymentAccount.PublicDeletePaymentAccountBuilder builder,
            string id,
            string namespace_,
            string type,
            string userId
        )
        {
            PublicDeletePaymentAccount op = builder.Build(
                id,
                namespace_,
                type,
                userId
            );

            ((Platform.Wrapper.PaymentAccount)builder.WrapperObject!).PublicDeletePaymentAccount(op);
        }

    }
}