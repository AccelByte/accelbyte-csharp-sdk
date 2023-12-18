// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Fulfillment
    {
        private readonly AccelByteSDK _sdk;

        public Fulfillment(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryFulfillmentHistories.QueryFulfillmentHistoriesBuilder QueryFulfillmentHistoriesOp
        {
            get { return Operation.QueryFulfillmentHistories.Builder.SetWrapperObject(this); }
        }
        public FulfillItem.FulfillItemBuilder FulfillItemOp
        {
            get { return Operation.FulfillItem.Builder.SetWrapperObject(this); }
        }
        public RedeemCode.RedeemCodeBuilder RedeemCodeOp
        {
            get { return Operation.RedeemCode.Builder.SetWrapperObject(this); }
        }
        public PreCheckFulfillItem.PreCheckFulfillItemBuilder PreCheckFulfillItemOp
        {
            get { return Operation.PreCheckFulfillItem.Builder.SetWrapperObject(this); }
        }
        public FulfillRewards.FulfillRewardsBuilder FulfillRewardsOp
        {
            get { return Operation.FulfillRewards.Builder.SetWrapperObject(this); }
        }
        public PublicRedeemCode.PublicRedeemCodeBuilder PublicRedeemCodeOp
        {
            get { return Operation.PublicRedeemCode.Builder.SetWrapperObject(this); }
        }
        public FulfillRewardsV2.FulfillRewardsV2Builder FulfillRewardsV2Op
        {
            get { return Operation.FulfillRewardsV2.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.FulfillmentHistoryPagingSlicedResult? QueryFulfillmentHistories(QueryFulfillmentHistories input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? FulfillItem(FulfillItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? RedeemCode(RedeemCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.FulfillmentItem>? PreCheckFulfillItem(PreCheckFulfillItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void FulfillRewards(FulfillRewards input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? PublicRedeemCode(PublicRedeemCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? FulfillRewardsV2(FulfillRewardsV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}