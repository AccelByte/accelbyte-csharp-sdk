// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformAnonymization_OpExts
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

            ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeCampaign(op);
        }
        public static async Task ExecuteAsync(
            this AnonymizeCampaign.AnonymizeCampaignBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeCampaign op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeCampaignAsync(op);
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

            ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeEntitlement(op);
        }
        public static async Task ExecuteAsync(
            this AnonymizeEntitlement.AnonymizeEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeEntitlement op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeEntitlementAsync(op);
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

            ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeFulfillment(op);
        }
        public static async Task ExecuteAsync(
            this AnonymizeFulfillment.AnonymizeFulfillmentBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeFulfillment op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeFulfillmentAsync(op);
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

            ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeIntegration(op);
        }
        public static async Task ExecuteAsync(
            this AnonymizeIntegration.AnonymizeIntegrationBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeIntegration op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeIntegrationAsync(op);
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

            ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeOrder(op);
        }
        public static async Task ExecuteAsync(
            this AnonymizeOrder.AnonymizeOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeOrder op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeOrderAsync(op);
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

            ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizePayment(op);
        }
        public static async Task ExecuteAsync(
            this AnonymizePayment.AnonymizePaymentBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizePayment op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizePaymentAsync(op);
        }
        public static void Execute(
            this AnonymizeRevocation.AnonymizeRevocationBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeRevocation op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeRevocation(op);
        }
        public static async Task ExecuteAsync(
            this AnonymizeRevocation.AnonymizeRevocationBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeRevocation op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeRevocationAsync(op);
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

            ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeSubscription(op);
        }
        public static async Task ExecuteAsync(
            this AnonymizeSubscription.AnonymizeSubscriptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeSubscription op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeSubscriptionAsync(op);
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

            ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeWallet(op);
        }
        public static async Task ExecuteAsync(
            this AnonymizeWallet.AnonymizeWalletBuilder builder,
            string namespace_,
            string userId
        )
        {
            AnonymizeWallet op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.Anonymization)builder.WrapperObject!).AnonymizeWalletAsync(op);
        }
    }
}