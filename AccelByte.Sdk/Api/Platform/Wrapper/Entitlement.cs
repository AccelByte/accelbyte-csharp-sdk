// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
}