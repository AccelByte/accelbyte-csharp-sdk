// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Entitlement
    {
        private readonly AccelByteSDK _sdk;

        public Entitlement(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryEntitlements.QueryEntitlementsBuilder QueryEntitlementsOp
        {
            get { return Operation.QueryEntitlements.Builder.SetWrapperObject(this); }
        }
        public GetEntitlement.GetEntitlementBuilder GetEntitlementOp
        {
            get { return Operation.GetEntitlement.Builder.SetWrapperObject(this); }
        }
        public QueryUserEntitlements.QueryUserEntitlementsBuilder QueryUserEntitlementsOp
        {
            get { return Operation.QueryUserEntitlements.Builder.SetWrapperObject(this); }
        }
        public GrantUserEntitlement.GrantUserEntitlementBuilder GrantUserEntitlementOp
        {
            get { return Operation.GrantUserEntitlement.Builder.SetWrapperObject(this); }
        }
        public GetUserAppEntitlementByAppId.GetUserAppEntitlementByAppIdBuilder GetUserAppEntitlementByAppIdOp
        {
            get { return Operation.GetUserAppEntitlementByAppId.Builder.SetWrapperObject(this); }
        }
        public QueryUserEntitlementsByAppType.QueryUserEntitlementsByAppTypeBuilder QueryUserEntitlementsByAppTypeOp
        {
            get { return Operation.QueryUserEntitlementsByAppType.Builder.SetWrapperObject(this); }
        }
        public GetUserEntitlementByItemId.GetUserEntitlementByItemIdBuilder GetUserEntitlementByItemIdOp
        {
            get { return Operation.GetUserEntitlementByItemId.Builder.SetWrapperObject(this); }
        }
        public GetUserEntitlementBySku.GetUserEntitlementBySkuBuilder GetUserEntitlementBySkuOp
        {
            get { return Operation.GetUserEntitlementBySku.Builder.SetWrapperObject(this); }
        }
        public ExistsAnyUserActiveEntitlement.ExistsAnyUserActiveEntitlementBuilder ExistsAnyUserActiveEntitlementOp
        {
            get { return Operation.ExistsAnyUserActiveEntitlement.Builder.SetWrapperObject(this); }
        }
        public ExistsAnyUserActiveEntitlementByItemIds.ExistsAnyUserActiveEntitlementByItemIdsBuilder ExistsAnyUserActiveEntitlementByItemIdsOp
        {
            get { return Operation.ExistsAnyUserActiveEntitlementByItemIds.Builder.SetWrapperObject(this); }
        }
        public GetUserAppEntitlementOwnershipByAppId.GetUserAppEntitlementOwnershipByAppIdBuilder GetUserAppEntitlementOwnershipByAppIdOp
        {
            get { return Operation.GetUserAppEntitlementOwnershipByAppId.Builder.SetWrapperObject(this); }
        }
        public GetUserEntitlementOwnershipByItemId.GetUserEntitlementOwnershipByItemIdBuilder GetUserEntitlementOwnershipByItemIdOp
        {
            get { return Operation.GetUserEntitlementOwnershipByItemId.Builder.SetWrapperObject(this); }
        }
        public GetUserEntitlementOwnershipBySku.GetUserEntitlementOwnershipBySkuBuilder GetUserEntitlementOwnershipBySkuOp
        {
            get { return Operation.GetUserEntitlementOwnershipBySku.Builder.SetWrapperObject(this); }
        }
        public RevokeUserEntitlements.RevokeUserEntitlementsBuilder RevokeUserEntitlementsOp
        {
            get { return Operation.RevokeUserEntitlements.Builder.SetWrapperObject(this); }
        }
        public GetUserEntitlement.GetUserEntitlementBuilder GetUserEntitlementOp
        {
            get { return Operation.GetUserEntitlement.Builder.SetWrapperObject(this); }
        }
        public UpdateUserEntitlement.UpdateUserEntitlementBuilder UpdateUserEntitlementOp
        {
            get { return Operation.UpdateUserEntitlement.Builder.SetWrapperObject(this); }
        }
        public ConsumeUserEntitlement.ConsumeUserEntitlementBuilder ConsumeUserEntitlementOp
        {
            get { return Operation.ConsumeUserEntitlement.Builder.SetWrapperObject(this); }
        }
        public DisableUserEntitlement.DisableUserEntitlementBuilder DisableUserEntitlementOp
        {
            get { return Operation.DisableUserEntitlement.Builder.SetWrapperObject(this); }
        }
        public EnableUserEntitlement.EnableUserEntitlementBuilder EnableUserEntitlementOp
        {
            get { return Operation.EnableUserEntitlement.Builder.SetWrapperObject(this); }
        }
        public GetUserEntitlementHistories.GetUserEntitlementHistoriesBuilder GetUserEntitlementHistoriesOp
        {
            get { return Operation.GetUserEntitlementHistories.Builder.SetWrapperObject(this); }
        }
        public RevokeUserEntitlement.RevokeUserEntitlementBuilder RevokeUserEntitlementOp
        {
            get { return Operation.RevokeUserEntitlement.Builder.SetWrapperObject(this); }
        }
        public PublicExistsAnyMyActiveEntitlement.PublicExistsAnyMyActiveEntitlementBuilder PublicExistsAnyMyActiveEntitlementOp
        {
            get { return Operation.PublicExistsAnyMyActiveEntitlement.Builder.SetWrapperObject(this); }
        }
        public PublicGetMyAppEntitlementOwnershipByAppId.PublicGetMyAppEntitlementOwnershipByAppIdBuilder PublicGetMyAppEntitlementOwnershipByAppIdOp
        {
            get { return Operation.PublicGetMyAppEntitlementOwnershipByAppId.Builder.SetWrapperObject(this); }
        }
        public PublicGetMyEntitlementOwnershipByItemId.PublicGetMyEntitlementOwnershipByItemIdBuilder PublicGetMyEntitlementOwnershipByItemIdOp
        {
            get { return Operation.PublicGetMyEntitlementOwnershipByItemId.Builder.SetWrapperObject(this); }
        }
        public PublicGetMyEntitlementOwnershipBySku.PublicGetMyEntitlementOwnershipBySkuBuilder PublicGetMyEntitlementOwnershipBySkuOp
        {
            get { return Operation.PublicGetMyEntitlementOwnershipBySku.Builder.SetWrapperObject(this); }
        }
        public PublicGetEntitlementOwnershipToken.PublicGetEntitlementOwnershipTokenBuilder PublicGetEntitlementOwnershipTokenOp
        {
            get { return Operation.PublicGetEntitlementOwnershipToken.Builder.SetWrapperObject(this); }
        }
        public PublicQueryUserEntitlements.PublicQueryUserEntitlementsBuilder PublicQueryUserEntitlementsOp
        {
            get { return Operation.PublicQueryUserEntitlements.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserAppEntitlementByAppId.PublicGetUserAppEntitlementByAppIdBuilder PublicGetUserAppEntitlementByAppIdOp
        {
            get { return Operation.PublicGetUserAppEntitlementByAppId.Builder.SetWrapperObject(this); }
        }
        public PublicQueryUserEntitlementsByAppType.PublicQueryUserEntitlementsByAppTypeBuilder PublicQueryUserEntitlementsByAppTypeOp
        {
            get { return Operation.PublicQueryUserEntitlementsByAppType.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserEntitlementByItemId.PublicGetUserEntitlementByItemIdBuilder PublicGetUserEntitlementByItemIdOp
        {
            get { return Operation.PublicGetUserEntitlementByItemId.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserEntitlementBySku.PublicGetUserEntitlementBySkuBuilder PublicGetUserEntitlementBySkuOp
        {
            get { return Operation.PublicGetUserEntitlementBySku.Builder.SetWrapperObject(this); }
        }
        public PublicExistsAnyUserActiveEntitlement.PublicExistsAnyUserActiveEntitlementBuilder PublicExistsAnyUserActiveEntitlementOp
        {
            get { return Operation.PublicExistsAnyUserActiveEntitlement.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserAppEntitlementOwnershipByAppId.PublicGetUserAppEntitlementOwnershipByAppIdBuilder PublicGetUserAppEntitlementOwnershipByAppIdOp
        {
            get { return Operation.PublicGetUserAppEntitlementOwnershipByAppId.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserEntitlementOwnershipByItemId.PublicGetUserEntitlementOwnershipByItemIdBuilder PublicGetUserEntitlementOwnershipByItemIdOp
        {
            get { return Operation.PublicGetUserEntitlementOwnershipByItemId.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserEntitlementOwnershipBySku.PublicGetUserEntitlementOwnershipBySkuBuilder PublicGetUserEntitlementOwnershipBySkuOp
        {
            get { return Operation.PublicGetUserEntitlementOwnershipBySku.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserEntitlement.PublicGetUserEntitlementBuilder PublicGetUserEntitlementOp
        {
            get { return Operation.PublicGetUserEntitlement.Builder.SetWrapperObject(this); }
        }
        public PublicConsumeUserEntitlement.PublicConsumeUserEntitlementBuilder PublicConsumeUserEntitlementOp
        {
            get { return Operation.PublicConsumeUserEntitlement.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.EntitlementPagingSlicedResult? QueryEntitlements(QueryEntitlements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? GetEntitlement(GetEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementPagingSlicedResult? QueryUserEntitlements(QueryUserEntitlements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.StackableEntitlementInfo>? GrantUserEntitlement(GrantUserEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppEntitlementInfo? GetUserAppEntitlementByAppId(GetUserAppEntitlementByAppId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppEntitlementPagingSlicedResult? QueryUserEntitlementsByAppType(QueryUserEntitlementsByAppType input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? GetUserEntitlementByItemId(GetUserEntitlementByItemId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? GetUserEntitlementBySku(GetUserEntitlementBySku input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? ExistsAnyUserActiveEntitlement(ExistsAnyUserActiveEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? ExistsAnyUserActiveEntitlementByItemIds(ExistsAnyUserActiveEntitlementByItemIds input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? GetUserAppEntitlementOwnershipByAppId(GetUserAppEntitlementOwnershipByAppId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? GetUserEntitlementOwnershipByItemId(GetUserEntitlementOwnershipByItemId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? GetUserEntitlementOwnershipBySku(GetUserEntitlementOwnershipBySku input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkOperationResult? RevokeUserEntitlements(RevokeUserEntitlements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? GetUserEntitlement(GetUserEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? UpdateUserEntitlement(UpdateUserEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? ConsumeUserEntitlement(ConsumeUserEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? DisableUserEntitlement(DisableUserEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? EnableUserEntitlement(EnableUserEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.EntitlementHistoryInfo>? GetUserEntitlementHistories(GetUserEntitlementHistories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? RevokeUserEntitlement(RevokeUserEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? PublicExistsAnyMyActiveEntitlement(PublicExistsAnyMyActiveEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? PublicGetMyAppEntitlementOwnershipByAppId(PublicGetMyAppEntitlementOwnershipByAppId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? PublicGetMyEntitlementOwnershipByItemId(PublicGetMyEntitlementOwnershipByItemId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? PublicGetMyEntitlementOwnershipBySku(PublicGetMyEntitlementOwnershipBySku input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OwnershipToken? PublicGetEntitlementOwnershipToken(PublicGetEntitlementOwnershipToken input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementPagingSlicedResult? PublicQueryUserEntitlements(PublicQueryUserEntitlements input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppEntitlementInfo? PublicGetUserAppEntitlementByAppId(PublicGetUserAppEntitlementByAppId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppEntitlementPagingSlicedResult? PublicQueryUserEntitlementsByAppType(PublicQueryUserEntitlementsByAppType input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? PublicGetUserEntitlementByItemId(PublicGetUserEntitlementByItemId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? PublicGetUserEntitlementBySku(PublicGetUserEntitlementBySku input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? PublicExistsAnyUserActiveEntitlement(PublicExistsAnyUserActiveEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? PublicGetUserAppEntitlementOwnershipByAppId(PublicGetUserAppEntitlementOwnershipByAppId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? PublicGetUserEntitlementOwnershipByItemId(PublicGetUserEntitlementOwnershipByItemId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? PublicGetUserEntitlementOwnershipBySku(PublicGetUserEntitlementOwnershipBySku input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? PublicGetUserEntitlement(PublicGetUserEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? PublicConsumeUserEntitlement(PublicConsumeUserEntitlement input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Entitlement_OperationExtensions
    {
        public static Model.EntitlementPagingSlicedResult? Execute(
            this QueryEntitlements.QueryEntitlementsBuilder builder,
            string namespace_
        )
        {
            QueryEntitlements op = builder.Build(
                namespace_
            );

            return ((Entitlement)builder.WrapperObject!).QueryEntitlements(op);
        }

        public static Model.EntitlementInfo? Execute(
            this GetEntitlement.GetEntitlementBuilder builder,
            string entitlementId,
            string namespace_
        )
        {
            GetEntitlement op = builder.Build(
                entitlementId,
                namespace_
            );

            return ((Entitlement)builder.WrapperObject!).GetEntitlement(op);
        }

        public static Model.EntitlementPagingSlicedResult? Execute(
            this QueryUserEntitlements.QueryUserEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserEntitlements op = builder.Build(
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).QueryUserEntitlements(op);
        }

        public static List<Model.StackableEntitlementInfo>? Execute(
            this GrantUserEntitlement.GrantUserEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            GrantUserEntitlement op = builder.Build(
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).GrantUserEntitlement(op);
        }

        public static Model.AppEntitlementInfo? Execute(
            this GetUserAppEntitlementByAppId.GetUserAppEntitlementByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            GetUserAppEntitlementByAppId op = builder.Build(
                namespace_,
                userId,
                appId
            );

            return ((Entitlement)builder.WrapperObject!).GetUserAppEntitlementByAppId(op);
        }

        public static Model.AppEntitlementPagingSlicedResult? Execute(
            this QueryUserEntitlementsByAppType.QueryUserEntitlementsByAppTypeBuilder builder,
            string namespace_,
            string userId,
            string appType
        )
        {
            QueryUserEntitlementsByAppType op = builder.Build(
                namespace_,
                userId,
                appType
            );

            return ((Entitlement)builder.WrapperObject!).QueryUserEntitlementsByAppType(op);
        }

        public static Model.EntitlementInfo? Execute(
            this GetUserEntitlementByItemId.GetUserEntitlementByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            GetUserEntitlementByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Entitlement)builder.WrapperObject!).GetUserEntitlementByItemId(op);
        }

        public static Model.EntitlementInfo? Execute(
            this GetUserEntitlementBySku.GetUserEntitlementBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            GetUserEntitlementBySku op = builder.Build(
                namespace_,
                userId,
                sku
            );

            return ((Entitlement)builder.WrapperObject!).GetUserEntitlementBySku(op);
        }

        public static Model.Ownership? Execute(
            this ExistsAnyUserActiveEntitlement.ExistsAnyUserActiveEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            ExistsAnyUserActiveEntitlement op = builder.Build(
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).ExistsAnyUserActiveEntitlement(op);
        }

        public static Model.Ownership? Execute(
            this ExistsAnyUserActiveEntitlementByItemIds.ExistsAnyUserActiveEntitlementByItemIdsBuilder builder,
            string namespace_,
            string userId,
            List<string> itemIds
        )
        {
            ExistsAnyUserActiveEntitlementByItemIds op = builder.Build(
                namespace_,
                userId,
                itemIds
            );

            return ((Entitlement)builder.WrapperObject!).ExistsAnyUserActiveEntitlementByItemIds(op);
        }

        public static Model.Ownership? Execute(
            this GetUserAppEntitlementOwnershipByAppId.GetUserAppEntitlementOwnershipByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            GetUserAppEntitlementOwnershipByAppId op = builder.Build(
                namespace_,
                userId,
                appId
            );

            return ((Entitlement)builder.WrapperObject!).GetUserAppEntitlementOwnershipByAppId(op);
        }

        public static Model.TimedOwnership? Execute(
            this GetUserEntitlementOwnershipByItemId.GetUserEntitlementOwnershipByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            GetUserEntitlementOwnershipByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Entitlement)builder.WrapperObject!).GetUserEntitlementOwnershipByItemId(op);
        }

        public static Model.TimedOwnership? Execute(
            this GetUserEntitlementOwnershipBySku.GetUserEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            GetUserEntitlementOwnershipBySku op = builder.Build(
                namespace_,
                userId,
                sku
            );

            return ((Entitlement)builder.WrapperObject!).GetUserEntitlementOwnershipBySku(op);
        }

        public static Model.BulkOperationResult? Execute(
            this RevokeUserEntitlements.RevokeUserEntitlementsBuilder builder,
            string namespace_,
            string userId,
            string entitlementIds
        )
        {
            RevokeUserEntitlements op = builder.Build(
                namespace_,
                userId,
                entitlementIds
            );

            return ((Entitlement)builder.WrapperObject!).RevokeUserEntitlements(op);
        }

        public static Model.EntitlementInfo? Execute(
            this GetUserEntitlement.GetUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            GetUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).GetUserEntitlement(op);
        }

        public static Model.EntitlementInfo? Execute(
            this UpdateUserEntitlement.UpdateUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            UpdateUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).UpdateUserEntitlement(op);
        }

        public static Model.EntitlementInfo? Execute(
            this ConsumeUserEntitlement.ConsumeUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            ConsumeUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).ConsumeUserEntitlement(op);
        }

        public static Model.EntitlementInfo? Execute(
            this DisableUserEntitlement.DisableUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            DisableUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).DisableUserEntitlement(op);
        }

        public static Model.EntitlementInfo? Execute(
            this EnableUserEntitlement.EnableUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            EnableUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).EnableUserEntitlement(op);
        }

        public static List<Model.EntitlementHistoryInfo>? Execute(
            this GetUserEntitlementHistories.GetUserEntitlementHistoriesBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            GetUserEntitlementHistories op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).GetUserEntitlementHistories(op);
        }

        public static Model.EntitlementInfo? Execute(
            this RevokeUserEntitlement.RevokeUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            RevokeUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).RevokeUserEntitlement(op);
        }

        public static Model.Ownership? Execute(
            this PublicExistsAnyMyActiveEntitlement.PublicExistsAnyMyActiveEntitlementBuilder builder,
            string namespace_
        )
        {
            PublicExistsAnyMyActiveEntitlement op = builder.Build(
                namespace_
            );

            return ((Entitlement)builder.WrapperObject!).PublicExistsAnyMyActiveEntitlement(op);
        }

        public static Model.Ownership? Execute(
            this PublicGetMyAppEntitlementOwnershipByAppId.PublicGetMyAppEntitlementOwnershipByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            PublicGetMyAppEntitlementOwnershipByAppId op = builder.Build(
                namespace_,
                appId
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetMyAppEntitlementOwnershipByAppId(op);
        }

        public static Model.TimedOwnership? Execute(
            this PublicGetMyEntitlementOwnershipByItemId.PublicGetMyEntitlementOwnershipByItemIdBuilder builder,
            string namespace_,
            string itemId
        )
        {
            PublicGetMyEntitlementOwnershipByItemId op = builder.Build(
                namespace_,
                itemId
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetMyEntitlementOwnershipByItemId(op);
        }

        public static Model.TimedOwnership? Execute(
            this PublicGetMyEntitlementOwnershipBySku.PublicGetMyEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PublicGetMyEntitlementOwnershipBySku op = builder.Build(
                namespace_,
                sku
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetMyEntitlementOwnershipBySku(op);
        }

        public static Model.OwnershipToken? Execute(
            this PublicGetEntitlementOwnershipToken.PublicGetEntitlementOwnershipTokenBuilder builder,
            string namespace_
        )
        {
            PublicGetEntitlementOwnershipToken op = builder.Build(
                namespace_
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetEntitlementOwnershipToken(op);
        }

        public static Model.EntitlementPagingSlicedResult? Execute(
            this PublicQueryUserEntitlements.PublicQueryUserEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicQueryUserEntitlements op = builder.Build(
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).PublicQueryUserEntitlements(op);
        }

        public static Model.AppEntitlementInfo? Execute(
            this PublicGetUserAppEntitlementByAppId.PublicGetUserAppEntitlementByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            PublicGetUserAppEntitlementByAppId op = builder.Build(
                namespace_,
                userId,
                appId
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetUserAppEntitlementByAppId(op);
        }

        public static Model.AppEntitlementPagingSlicedResult? Execute(
            this PublicQueryUserEntitlementsByAppType.PublicQueryUserEntitlementsByAppTypeBuilder builder,
            string namespace_,
            string userId,
            string appType
        )
        {
            PublicQueryUserEntitlementsByAppType op = builder.Build(
                namespace_,
                userId,
                appType
            );

            return ((Entitlement)builder.WrapperObject!).PublicQueryUserEntitlementsByAppType(op);
        }

        public static Model.EntitlementInfo? Execute(
            this PublicGetUserEntitlementByItemId.PublicGetUserEntitlementByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PublicGetUserEntitlementByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetUserEntitlementByItemId(op);
        }

        public static Model.EntitlementInfo? Execute(
            this PublicGetUserEntitlementBySku.PublicGetUserEntitlementBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            PublicGetUserEntitlementBySku op = builder.Build(
                namespace_,
                userId,
                sku
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetUserEntitlementBySku(op);
        }

        public static Model.Ownership? Execute(
            this PublicExistsAnyUserActiveEntitlement.PublicExistsAnyUserActiveEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicExistsAnyUserActiveEntitlement op = builder.Build(
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).PublicExistsAnyUserActiveEntitlement(op);
        }

        public static Model.Ownership? Execute(
            this PublicGetUserAppEntitlementOwnershipByAppId.PublicGetUserAppEntitlementOwnershipByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            PublicGetUserAppEntitlementOwnershipByAppId op = builder.Build(
                namespace_,
                userId,
                appId
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetUserAppEntitlementOwnershipByAppId(op);
        }

        public static Model.TimedOwnership? Execute(
            this PublicGetUserEntitlementOwnershipByItemId.PublicGetUserEntitlementOwnershipByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PublicGetUserEntitlementOwnershipByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetUserEntitlementOwnershipByItemId(op);
        }

        public static Model.TimedOwnership? Execute(
            this PublicGetUserEntitlementOwnershipBySku.PublicGetUserEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            PublicGetUserEntitlementOwnershipBySku op = builder.Build(
                namespace_,
                userId,
                sku
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetUserEntitlementOwnershipBySku(op);
        }

        public static Model.EntitlementInfo? Execute(
            this PublicGetUserEntitlement.PublicGetUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PublicGetUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).PublicGetUserEntitlement(op);
        }

        public static Model.EntitlementInfo? Execute(
            this PublicConsumeUserEntitlement.PublicConsumeUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PublicConsumeUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Entitlement)builder.WrapperObject!).PublicConsumeUserEntitlement(op);
        }

    }
}