// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformCampaign_OpExts
    {
        public static Platform.Model.CampaignPagingSlicedResult? Execute(
            this QueryCampaigns.QueryCampaignsBuilder builder,
            string namespace_
        )
        {
            QueryCampaigns op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).QueryCampaigns(op);
        }

        public static Platform.Model.CampaignInfo? Execute(
            this CreateCampaign.CreateCampaignBuilder builder,
            string namespace_
        )
        {
            CreateCampaign op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).CreateCampaign(op);
        }

        public static Platform.Model.CampaignInfo? Execute(
            this GetCampaign.GetCampaignBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            GetCampaign op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).GetCampaign(op);
        }

        public static Platform.Model.CampaignInfo? Execute(
            this UpdateCampaign.UpdateCampaignBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            UpdateCampaign op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).UpdateCampaign(op);
        }

        public static Platform.Model.CampaignDynamicInfo? Execute(
            this GetCampaignDynamic.GetCampaignDynamicBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            GetCampaignDynamic op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).GetCampaignDynamic(op);
        }

        public static Platform.Model.CodeInfoPagingSlicedResult? Execute(
            this QueryCodes.QueryCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            QueryCodes op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).QueryCodes(op);
        }

        public static Platform.Model.CodeCreateResult? Execute(
            this CreateCodes.CreateCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            CreateCodes op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).CreateCodes(op);
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

            ((Platform.Wrapper.Campaign)builder.WrapperObject!).Download(op);
        }

        public static Platform.Model.BulkOperationResult? Execute(
            this BulkDisableCodes.BulkDisableCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            BulkDisableCodes op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).BulkDisableCodes(op);
        }

        public static Platform.Model.BulkOperationResult? Execute(
            this BulkEnableCodes.BulkEnableCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            BulkEnableCodes op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).BulkEnableCodes(op);
        }

        public static Platform.Model.RedeemHistoryPagingSlicedResult? Execute(
            this QueryRedeemHistory.QueryRedeemHistoryBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            QueryRedeemHistory op = builder.Build(
                campaignId,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).QueryRedeemHistory(op);
        }

        public static Platform.Model.CodeInfo? Execute(
            this GetCode.GetCodeBuilder builder,
            string code,
            string namespace_
        )
        {
            GetCode op = builder.Build(
                code,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).GetCode(op);
        }

        public static Platform.Model.CodeInfo? Execute(
            this DisableCode.DisableCodeBuilder builder,
            string code,
            string namespace_
        )
        {
            DisableCode op = builder.Build(
                code,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).DisableCode(op);
        }

        public static Platform.Model.CodeInfo? Execute(
            this EnableCode.EnableCodeBuilder builder,
            string code,
            string namespace_
        )
        {
            EnableCode op = builder.Build(
                code,
                namespace_
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).EnableCode(op);
        }

        public static Platform.Model.RedeemResult? Execute(
            this ApplyUserRedemption.ApplyUserRedemptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            ApplyUserRedemption op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Campaign)builder.WrapperObject!).ApplyUserRedemption(op);
        }

    }
}