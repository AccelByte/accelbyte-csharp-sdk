// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Anonymization
    {
        private readonly AccelByteSDK _sdk;

        public Anonymization(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AnonymizeCampaign.AnonymizeCampaignBuilder AnonymizeCampaignOp
        {
            get { return Operation.AnonymizeCampaign.Builder.SetWrapperObject(this); }
        }
        public AnonymizeEntitlement.AnonymizeEntitlementBuilder AnonymizeEntitlementOp
        {
            get { return Operation.AnonymizeEntitlement.Builder.SetWrapperObject(this); }
        }
        public AnonymizeFulfillment.AnonymizeFulfillmentBuilder AnonymizeFulfillmentOp
        {
            get { return Operation.AnonymizeFulfillment.Builder.SetWrapperObject(this); }
        }
        public AnonymizeIntegration.AnonymizeIntegrationBuilder AnonymizeIntegrationOp
        {
            get { return Operation.AnonymizeIntegration.Builder.SetWrapperObject(this); }
        }
        public AnonymizeOrder.AnonymizeOrderBuilder AnonymizeOrderOp
        {
            get { return Operation.AnonymizeOrder.Builder.SetWrapperObject(this); }
        }
        public AnonymizePayment.AnonymizePaymentBuilder AnonymizePaymentOp
        {
            get { return Operation.AnonymizePayment.Builder.SetWrapperObject(this); }
        }
        public AnonymizeSubscription.AnonymizeSubscriptionBuilder AnonymizeSubscriptionOp
        {
            get { return Operation.AnonymizeSubscription.Builder.SetWrapperObject(this); }
        }
        public AnonymizeWallet.AnonymizeWalletBuilder AnonymizeWalletOp
        {
            get { return Operation.AnonymizeWallet.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void AnonymizeCampaign(AnonymizeCampaign input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeEntitlement(AnonymizeEntitlement input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeFulfillment(AnonymizeFulfillment input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeIntegration(AnonymizeIntegration input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeOrder(AnonymizeOrder input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizePayment(AnonymizePayment input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeSubscription(AnonymizeSubscription input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeWallet(AnonymizeWallet input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Anonymization_OperationExtensions
    {
        public static void Execute(
            this AnonymizeCampaign.AnonymizeCampaignBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeCampaign op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AnonymizeCampaign(op);
        }

        public static void Execute(
            this AnonymizeEntitlement.AnonymizeEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeEntitlement op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AnonymizeEntitlement(op);
        }

        public static void Execute(
            this AnonymizeFulfillment.AnonymizeFulfillmentBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeFulfillment op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AnonymizeFulfillment(op);
        }

        public static void Execute(
            this AnonymizeIntegration.AnonymizeIntegrationBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeIntegration op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AnonymizeIntegration(op);
        }

        public static void Execute(
            this AnonymizeOrder.AnonymizeOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeOrder op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AnonymizeOrder(op);
        }

        public static void Execute(
            this AnonymizePayment.AnonymizePaymentBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizePayment op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AnonymizePayment(op);
        }

        public static void Execute(
            this AnonymizeSubscription.AnonymizeSubscriptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeSubscription op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AnonymizeSubscription(op);
        }

        public static void Execute(
            this AnonymizeWallet.AnonymizeWalletBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeWallet op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AnonymizeWallet(op);
        }

    }
}