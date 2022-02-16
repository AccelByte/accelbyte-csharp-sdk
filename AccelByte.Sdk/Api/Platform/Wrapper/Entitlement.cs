// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Entitlement {
        private readonly AccelByteSDK _sdk;

        public Entitlement(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
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