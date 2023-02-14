// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        public AnonymizeRevocation.AnonymizeRevocationBuilder AnonymizeRevocationOp
        {
            get { return Operation.AnonymizeRevocation.Builder.SetWrapperObject(this); }
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

        public void AnonymizeCampaign(AnonymizeCampaign input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeEntitlement(AnonymizeEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeFulfillment(AnonymizeFulfillment input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeIntegration(AnonymizeIntegration input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeOrder(AnonymizeOrder input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizePayment(AnonymizePayment input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeRevocation(AnonymizeRevocation input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeSubscription(AnonymizeSubscription input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeWallet(AnonymizeWallet input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}