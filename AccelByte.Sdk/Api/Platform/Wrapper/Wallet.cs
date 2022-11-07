// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        public GetPlatformWalletConfig.GetPlatformWalletConfigBuilder GetPlatformWalletConfigOp
        {
            get { return Operation.GetPlatformWalletConfig.Builder.SetWrapperObject(this); }
        }
        public UpdatePlatformWalletConfig.UpdatePlatformWalletConfigBuilder UpdatePlatformWalletConfigOp
        {
            get { return Operation.UpdatePlatformWalletConfig.Builder.SetWrapperObject(this); }
        }
        public ResetPlatformWalletConfig.ResetPlatformWalletConfigBuilder ResetPlatformWalletConfigOp
        {
            get { return Operation.ResetPlatformWalletConfig.Builder.SetWrapperObject(this); }
        }
        public QueryUserCurrencyWallets.QueryUserCurrencyWalletsBuilder QueryUserCurrencyWalletsOp
        {
            get { return Operation.QueryUserCurrencyWallets.Builder.SetWrapperObject(this); }
        }
        public ListUserCurrencyTransactions.ListUserCurrencyTransactionsBuilder ListUserCurrencyTransactionsOp
        {
            get { return Operation.ListUserCurrencyTransactions.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetUserWallet.GetUserWalletBuilder GetUserWalletOp
        {
            get { return Operation.GetUserWallet.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DebitUserWallet.DebitUserWalletBuilder DebitUserWalletOp
        {
            get { return Operation.DebitUserWallet.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DisableUserWallet.DisableUserWalletBuilder DisableUserWalletOp
        {
            get { return Operation.DisableUserWallet.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public EnableUserWallet.EnableUserWalletBuilder EnableUserWalletOp
        {
            get { return Operation.EnableUserWallet.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public ListUserWalletTransactions.ListUserWalletTransactionsBuilder ListUserWalletTransactionsOp
        {
            get { return Operation.ListUserWalletTransactions.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public QueryWallets.QueryWalletsBuilder QueryWalletsOp
        {
            get { return Operation.QueryWallets.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        
        public Model.PlatformWalletConfigInfo? GetPlatformWalletConfig(GetPlatformWalletConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformWalletConfigInfo? UpdatePlatformWalletConfig(UpdatePlatformWalletConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformWalletConfigInfo? ResetPlatformWalletConfig(ResetPlatformWalletConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CurrencyWallet>? QueryUserCurrencyWallets(QueryUserCurrencyWallets input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletTransactionPagingSlicedResult? ListUserCurrencyTransactions(ListUserCurrencyTransactions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void CheckWallet(CheckWallet input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.WalletInfo? CreditUserWallet(CreditUserWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformWallet? PayWithUserWallet(PayWithUserWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.WalletInfo? GetUserWallet(GetUserWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.WalletInfo? DebitUserWallet(DebitUserWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void DisableUserWallet(DisableUserWallet input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void EnableUserWallet(EnableUserWallet input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.DetailedWalletTransactionPagingSlicedResult? ListUserWalletTransactions(ListUserWalletTransactions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.WalletPagingSlicedResult? QueryWallets(QueryWallets input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.WalletInfo? GetWallet(GetWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.PlatformWallet? PublicGetMyWallet(PublicGetMyWallet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformWallet? PublicGetWallet(PublicGetWallet input) {
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