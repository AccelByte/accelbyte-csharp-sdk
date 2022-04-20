// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class PaymentAccount
    {
        private readonly AccelByteSDK _sdk;

        public PaymentAccount(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicGetPaymentAccounts.PublicGetPaymentAccountsBuilder PublicGetPaymentAccountsOp
        {
            get { return Operation.PublicGetPaymentAccounts.Builder.SetWrapperObject(this); }
        }
        public PublicDeletePaymentAccount.PublicDeletePaymentAccountBuilder PublicDeletePaymentAccountOp
        {
            get { return Operation.PublicDeletePaymentAccount.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.PaymentAccount>? PublicGetPaymentAccounts(PublicGetPaymentAccounts input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeletePaymentAccount(PublicDeletePaymentAccount input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PaymentAccount_OperationExtensions
    {
        public static List<Model.PaymentAccount>? Execute(
            this PublicGetPaymentAccounts.PublicGetPaymentAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetPaymentAccounts op = builder.Build(
                namespace_,
                userId
            );

            return ((PaymentAccount)builder.WrapperObject!).PublicGetPaymentAccounts(op);
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

            ((PaymentAccount)builder.WrapperObject!).PublicDeletePaymentAccount(op);
        }

    }
}