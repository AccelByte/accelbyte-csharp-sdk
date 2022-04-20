// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformWallet_OpExts
    {
        public static void Execute(
            this CheckWallet.CheckWalletBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            CheckWallet op = builder.Build(
                currencyCode,
                namespace_,
                userId
            );

            ((Platform.Wrapper.Wallet)builder.WrapperObject!).CheckWallet(op);
        }

        public static Platform.Model.WalletInfo? Execute(
            this CreditUserWallet.CreditUserWalletBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            CreditUserWallet op = builder.Build(
                currencyCode,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).CreditUserWallet(op);
        }

        public static Platform.Model.WalletInfo? Execute(
            this PayWithUserWallet.PayWithUserWalletBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PayWithUserWallet op = builder.Build(
                currencyCode,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).PayWithUserWallet(op);
        }

        public static Platform.Model.WalletInfo? Execute(
            this GetUserWallet.GetUserWalletBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            GetUserWallet op = builder.Build(
                namespace_,
                userId,
                walletId
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).GetUserWallet(op);
        }

        public static Platform.Model.WalletInfo? Execute(
            this DebitUserWallet.DebitUserWalletBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            DebitUserWallet op = builder.Build(
                namespace_,
                userId,
                walletId
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).DebitUserWallet(op);
        }

        public static void Execute(
            this DisableUserWallet.DisableUserWalletBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            DisableUserWallet op = builder.Build(
                namespace_,
                userId,
                walletId
            );

            ((Platform.Wrapper.Wallet)builder.WrapperObject!).DisableUserWallet(op);
        }

        public static void Execute(
            this EnableUserWallet.EnableUserWalletBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            EnableUserWallet op = builder.Build(
                namespace_,
                userId,
                walletId
            );

            ((Platform.Wrapper.Wallet)builder.WrapperObject!).EnableUserWallet(op);
        }

        public static Platform.Model.WalletTransactionPagingSlicedResult? Execute(
            this ListUserWalletTransactions.ListUserWalletTransactionsBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            ListUserWalletTransactions op = builder.Build(
                namespace_,
                userId,
                walletId
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).ListUserWalletTransactions(op);
        }

        public static Platform.Model.WalletPagingSlicedResult? Execute(
            this QueryWallets.QueryWalletsBuilder builder,
            string namespace_
        )
        {
            QueryWallets op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).QueryWallets(op);
        }

        public static Platform.Model.WalletInfo? Execute(
            this GetWallet.GetWalletBuilder builder,
            string namespace_,
            string walletId
        )
        {
            GetWallet op = builder.Build(
                namespace_,
                walletId
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).GetWallet(op);
        }

        public static Platform.Model.WalletInfo? Execute(
            this PublicGetMyWallet.PublicGetMyWalletBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            PublicGetMyWallet op = builder.Build(
                currencyCode,
                namespace_
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).PublicGetMyWallet(op);
        }

        public static Platform.Model.WalletInfo? Execute(
            this PublicGetWallet.PublicGetWalletBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PublicGetWallet op = builder.Build(
                currencyCode,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).PublicGetWallet(op);
        }

        public static Platform.Model.WalletTransactionPagingSlicedResult? Execute(
            this PublicListUserWalletTransactions.PublicListUserWalletTransactionsBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PublicListUserWalletTransactions op = builder.Build(
                currencyCode,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Wallet)builder.WrapperObject!).PublicListUserWalletTransactions(op);
        }

    }
}