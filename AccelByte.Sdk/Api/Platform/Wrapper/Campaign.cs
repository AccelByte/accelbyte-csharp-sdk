// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Campaign
    {
        private readonly AccelByteSDK _sdk;

        public Campaign(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryCampaigns.QueryCampaignsBuilder QueryCampaignsOp
        {
            get { return Operation.QueryCampaigns.Builder.SetWrapperObject(this); }
        }
        public CreateCampaign.CreateCampaignBuilder CreateCampaignOp
        {
            get { return Operation.CreateCampaign.Builder.SetWrapperObject(this); }
        }
        public GetCampaign.GetCampaignBuilder GetCampaignOp
        {
            get { return Operation.GetCampaign.Builder.SetWrapperObject(this); }
        }
        public UpdateCampaign.UpdateCampaignBuilder UpdateCampaignOp
        {
            get { return Operation.UpdateCampaign.Builder.SetWrapperObject(this); }
        }
        public GetCampaignDynamic.GetCampaignDynamicBuilder GetCampaignDynamicOp
        {
            get { return Operation.GetCampaignDynamic.Builder.SetWrapperObject(this); }
        }
        public QueryCodes.QueryCodesBuilder QueryCodesOp
        {
            get { return Operation.QueryCodes.Builder.SetWrapperObject(this); }
        }
        public CreateCodes.CreateCodesBuilder CreateCodesOp
        {
            get { return Operation.CreateCodes.Builder.SetWrapperObject(this); }
        }
        public Download.DownloadBuilder DownloadOp
        {
            get { return Operation.Download.Builder.SetWrapperObject(this); }
        }
        public BulkDisableCodes.BulkDisableCodesBuilder BulkDisableCodesOp
        {
            get { return Operation.BulkDisableCodes.Builder.SetWrapperObject(this); }
        }
        public BulkEnableCodes.BulkEnableCodesBuilder BulkEnableCodesOp
        {
            get { return Operation.BulkEnableCodes.Builder.SetWrapperObject(this); }
        }
        public QueryRedeemHistory.QueryRedeemHistoryBuilder QueryRedeemHistoryOp
        {
            get { return Operation.QueryRedeemHistory.Builder.SetWrapperObject(this); }
        }
        public GetCode.GetCodeBuilder GetCodeOp
        {
            get { return Operation.GetCode.Builder.SetWrapperObject(this); }
        }
        public DisableCode.DisableCodeBuilder DisableCodeOp
        {
            get { return Operation.DisableCode.Builder.SetWrapperObject(this); }
        }
        public EnableCode.EnableCodeBuilder EnableCodeOp
        {
            get { return Operation.EnableCode.Builder.SetWrapperObject(this); }
        }
        public ApplyUserRedemption.ApplyUserRedemptionBuilder ApplyUserRedemptionOp
        {
            get { return Operation.ApplyUserRedemption.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.CampaignPagingSlicedResult? QueryCampaigns(QueryCampaigns input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CampaignInfo? CreateCampaign(CreateCampaign input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CampaignInfo? GetCampaign(GetCampaign input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CampaignInfo? UpdateCampaign(UpdateCampaign input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CampaignDynamicInfo? GetCampaignDynamic(GetCampaignDynamic input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CodeInfoPagingSlicedResult? QueryCodes(QueryCodes input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CodeCreateResult? CreateCodes(CreateCodes input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void Download(Download input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkOperationResult? BulkDisableCodes(BulkDisableCodes input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkOperationResult? BulkEnableCodes(BulkEnableCodes input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RedeemHistoryPagingSlicedResult? QueryRedeemHistory(QueryRedeemHistory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CodeInfo? GetCode(GetCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CodeInfo? DisableCode(DisableCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CodeInfo? EnableCode(EnableCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RedeemResult? ApplyUserRedemption(ApplyUserRedemption input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Campaign_OperationExtensions
    {
        public static Model.CampaignPagingSlicedResult? Execute(
            this QueryCampaigns.QueryCampaignsBuilder builder,
            string namespace_
        )
        {
            QueryCampaigns op = builder.Build(
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).QueryCampaigns(op);
        }

        public static Model.CampaignInfo? Execute(
            this CreateCampaign.CreateCampaignBuilder builder,
            string namespace_
        )
        {
            CreateCampaign op = builder.Build(
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).CreateCampaign(op);
        }

        public static Model.CampaignInfo? Execute(
            this GetCampaign.GetCampaignBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            GetCampaign op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).GetCampaign(op);
        }

        public static Model.CampaignInfo? Execute(
            this UpdateCampaign.UpdateCampaignBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            UpdateCampaign op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).UpdateCampaign(op);
        }

        public static Model.CampaignDynamicInfo? Execute(
            this GetCampaignDynamic.GetCampaignDynamicBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            GetCampaignDynamic op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).GetCampaignDynamic(op);
        }

        public static Model.CodeInfoPagingSlicedResult? Execute(
            this QueryCodes.QueryCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            QueryCodes op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).QueryCodes(op);
        }

        public static Model.CodeCreateResult? Execute(
            this CreateCodes.CreateCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            CreateCodes op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).CreateCodes(op);
        }

        public static void Execute(
            this Download.DownloadBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            Download op = builder.Build(
                campaignId,
                namespace_
            );

            ((Campaign)builder.WrapperObject!).Download(op);
        }

        public static Model.BulkOperationResult? Execute(
            this BulkDisableCodes.BulkDisableCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            BulkDisableCodes op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).BulkDisableCodes(op);
        }

        public static Model.BulkOperationResult? Execute(
            this BulkEnableCodes.BulkEnableCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            BulkEnableCodes op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).BulkEnableCodes(op);
        }

        public static Model.RedeemHistoryPagingSlicedResult? Execute(
            this QueryRedeemHistory.QueryRedeemHistoryBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            QueryRedeemHistory op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).QueryRedeemHistory(op);
        }

        public static Model.CodeInfo? Execute(
            this GetCode.GetCodeBuilder builder,
            string code,
            string namespace_
        )
        {
            GetCode op = builder.Build(
                code,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).GetCode(op);
        }

        public static Model.CodeInfo? Execute(
            this DisableCode.DisableCodeBuilder builder,
            string code,
            string namespace_
        )
        {
            DisableCode op = builder.Build(
                code,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).DisableCode(op);
        }

        public static Model.CodeInfo? Execute(
            this EnableCode.EnableCodeBuilder builder,
            string code,
            string namespace_
        )
        {
            EnableCode op = builder.Build(
                code,
                namespace_
            );

            return ((Campaign)builder.WrapperObject!).EnableCode(op);
        }

        public static Model.RedeemResult? Execute(
            this ApplyUserRedemption.ApplyUserRedemptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            ApplyUserRedemption op = builder.Build(
                namespace_,
                userId
            );

            return ((Campaign)builder.WrapperObject!).ApplyUserRedemption(op);
        }

    }
}