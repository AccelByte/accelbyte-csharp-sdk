// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        public FulfillRewards.FulfillRewardsBuilder FulfillRewardsOp
        {
            get { return Operation.FulfillRewards.Builder.SetWrapperObject(this); }
        }
        public PublicRedeemCode.PublicRedeemCodeBuilder PublicRedeemCodeOp
        {
            get { return Operation.PublicRedeemCode.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.FulfillmentHistoryPagingSlicedResult? QueryFulfillmentHistories(QueryFulfillmentHistories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? FulfillItem(FulfillItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? RedeemCode(RedeemCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void FulfillRewards(FulfillRewards input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? PublicRedeemCode(PublicRedeemCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Fulfillment_OperationExtensions
    {
        public static Model.FulfillmentHistoryPagingSlicedResult? Execute(
            this QueryFulfillmentHistories.QueryFulfillmentHistoriesBuilder builder,
            string namespace_
        )
        {
            QueryFulfillmentHistories op = builder.Build(
                namespace_
            );

            return ((Fulfillment)builder.WrapperObject!).QueryFulfillmentHistories(op);
        }

        public static Model.FulfillmentResult? Execute(
            this FulfillItem.FulfillItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            FulfillItem op = builder.Build(
                namespace_,
                userId
            );

            return ((Fulfillment)builder.WrapperObject!).FulfillItem(op);
        }

        public static Model.FulfillmentResult? Execute(
            this RedeemCode.RedeemCodeBuilder builder,
            string namespace_,
            string userId
        )
        {
            RedeemCode op = builder.Build(
                namespace_,
                userId
            );

            return ((Fulfillment)builder.WrapperObject!).RedeemCode(op);
        }

        public static void Execute(
            this FulfillRewards.FulfillRewardsBuilder builder,
            string namespace_,
            string userId
        )
        {
            FulfillRewards op = builder.Build(
                namespace_,
                userId
            );

            ((Fulfillment)builder.WrapperObject!).FulfillRewards(op);
        }

        public static Model.FulfillmentResult? Execute(
            this PublicRedeemCode.PublicRedeemCodeBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicRedeemCode op = builder.Build(
                namespace_,
                userId
            );

            return ((Fulfillment)builder.WrapperObject!).PublicRedeemCode(op);
        }

    }
}