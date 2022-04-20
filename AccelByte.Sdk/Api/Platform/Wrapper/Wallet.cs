// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Wallet
    {
        private readonly AccelByteSDK _sdk;

        public Wallet(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CheckWallet.CheckWalletBuilder CheckWalletOp
        {
            get { return Operation.CheckWallet.Builder.SetWrapperObject(this); }
        }
        public CreditUserWallet.CreditUserWalletBuilder CreditUserWalletOp
        {
            get { return Operation.CreditUserWallet.Builder.SetWrapperObject(this); }
        }
        public PayWithUserWallet.PayWithUserWalletBuilder PayWithUserWalletOp
        {
            get { return Operation.PayWithUserWallet.Builder.SetWrapperObject(this); }
        }
        public GetUserWallet.GetUserWalletBuilder GetUserWalletOp
        {
            get { return Operation.GetUserWallet.Builder.SetWrapperObject(this); }
        }
        public DebitUserWallet.DebitUserWalletBuilder DebitUserWalletOp
        {
            get { return Operation.DebitUserWallet.Builder.SetWrapperObject(this); }
        }
        public DisableUserWallet.DisableUserWalletBuilder DisableUserWalletOp
        {
            get { return Operation.DisableUserWallet.Builder.SetWrapperObject(this); }
        }
        public EnableUserWallet.EnableUserWalletBuilder EnableUserWalletOp
        {
            get { return Operation.EnableUserWallet.Builder.SetWrapperObject(this); }
        }
        public ListUserWalletTransactions.ListUserWalletTransactionsBuilder ListUserWalletTransactionsOp
        {
            get { return Operation.ListUserWalletTransactions.Builder.SetWrapperObject(this); }
        }
        public QueryWallets.QueryWalletsBuilder QueryWalletsOp
        {
            get { return Operation.QueryWallets.Builder.SetWrapperObject(this); }
        }
        public GetWallet.GetWalletBuilder GetWalletOp
        {
            get { return Operation.GetWallet.Builder.SetWrapperObject(this); }
        }
        public PublicGetMyWallet.PublicGetMyWalletBuilder PublicGetMyWalletOp
        {
            get { return Operation.PublicGetMyWallet.Builder.SetWrapperObject(this); }
        }
        public PublicGetWallet.PublicGetWalletBuilder PublicGetWalletOp
        {
            get { return Operation.PublicGetWallet.Builder.SetWrapperObject(this); }
        }
        public PublicListUserWalletTransactions.PublicListUserWalletTransactionsBuilder PublicListUserWalletTransactionsOp
        {
            get { return Operation.PublicListUserWalletTransactions.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void CheckWallet(CheckWallet input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletInfo? CreditUserWallet(CreditUserWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletInfo? PayWithUserWallet(PayWithUserWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletInfo? GetUserWallet(GetUserWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletInfo? DebitUserWallet(DebitUserWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DisableUserWallet(DisableUserWallet input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void EnableUserWallet(EnableUserWallet input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletTransactionPagingSlicedResult? ListUserWalletTransactions(ListUserWalletTransactions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletPagingSlicedResult? QueryWallets(QueryWallets input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletInfo? GetWallet(GetWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletInfo? PublicGetMyWallet(PublicGetMyWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletInfo? PublicGetWallet(PublicGetWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletTransactionPagingSlicedResult? PublicListUserWalletTransactions(PublicListUserWalletTransactions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Wallet_OperationExtensions
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

            ((Wallet)builder.WrapperObject!).CheckWallet(op);
        }

        public static Model.WalletInfo? Execute(
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

            return ((Wallet)builder.WrapperObject!).CreditUserWallet(op);
        }

        public static Model.WalletInfo? Execute(
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

            return ((Wallet)builder.WrapperObject!).PayWithUserWallet(op);
        }

        public static Model.WalletInfo? Execute(
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

            return ((Wallet)builder.WrapperObject!).GetUserWallet(op);
        }

        public static Model.WalletInfo? Execute(
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

            return ((Wallet)builder.WrapperObject!).DebitUserWallet(op);
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

            ((Wallet)builder.WrapperObject!).DisableUserWallet(op);
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

            ((Wallet)builder.WrapperObject!).EnableUserWallet(op);
        }

        public static Model.WalletTransactionPagingSlicedResult? Execute(
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

            return ((Wallet)builder.WrapperObject!).ListUserWalletTransactions(op);
        }

        public static Model.WalletPagingSlicedResult? Execute(
            this QueryWallets.QueryWalletsBuilder builder,
            string namespace_
        )
        {
            QueryWallets op = builder.Build(
                namespace_
            );

            return ((Wallet)builder.WrapperObject!).QueryWallets(op);
        }

        public static Model.WalletInfo? Execute(
            this GetWallet.GetWalletBuilder builder,
            string namespace_,
            string walletId
        )
        {
            GetWallet op = builder.Build(
                namespace_,
                walletId
            );

            return ((Wallet)builder.WrapperObject!).GetWallet(op);
        }

        public static Model.WalletInfo? Execute(
            this PublicGetMyWallet.PublicGetMyWalletBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            PublicGetMyWallet op = builder.Build(
                currencyCode,
                namespace_
            );

            return ((Wallet)builder.WrapperObject!).PublicGetMyWallet(op);
        }

        public static Model.WalletInfo? Execute(
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

            return ((Wallet)builder.WrapperObject!).PublicGetWallet(op);
        }

        public static Model.WalletTransactionPagingSlicedResult? Execute(
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

            return ((Wallet)builder.WrapperObject!).PublicListUserWalletTransactions(op);
        }

    }
}