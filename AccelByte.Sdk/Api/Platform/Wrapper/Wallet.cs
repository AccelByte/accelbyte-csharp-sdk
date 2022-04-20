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
}