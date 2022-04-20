// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class UserProfile
    {
        private readonly AccelByteSDK _sdk;

        public UserProfile(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetUserProfilePublicInfoByIds.AdminGetUserProfilePublicInfoByIdsBuilder AdminGetUserProfilePublicInfoByIdsOp
        {
            get { return Operation.AdminGetUserProfilePublicInfoByIds.Builder.SetWrapperObject(this); }
        }
        public GetUserProfileInfo.GetUserProfileInfoBuilder GetUserProfileInfoOp
        {
            get { return Operation.GetUserProfileInfo.Builder.SetWrapperObject(this); }
        }
        public UpdateUserProfile.UpdateUserProfileBuilder UpdateUserProfileOp
        {
            get { return Operation.UpdateUserProfile.Builder.SetWrapperObject(this); }
        }
        public DeleteUserProfile.DeleteUserProfileBuilder DeleteUserProfileOp
        {
            get { return Operation.DeleteUserProfile.Builder.SetWrapperObject(this); }
        }
        public GetCustomAttributesInfo.GetCustomAttributesInfoBuilder GetCustomAttributesInfoOp
        {
            get { return Operation.GetCustomAttributesInfo.Builder.SetWrapperObject(this); }
        }
        public UpdateCustomAttributesPartially.UpdateCustomAttributesPartiallyBuilder UpdateCustomAttributesPartiallyOp
        {
            get { return Operation.UpdateCustomAttributesPartially.Builder.SetWrapperObject(this); }
        }
        public GetPrivateCustomAttributesInfo.GetPrivateCustomAttributesInfoBuilder GetPrivateCustomAttributesInfoOp
        {
            get { return Operation.GetPrivateCustomAttributesInfo.Builder.SetWrapperObject(this); }
        }
        public UpdatePrivateCustomAttributesPartially.UpdatePrivateCustomAttributesPartiallyBuilder UpdatePrivateCustomAttributesPartiallyOp
        {
            get { return Operation.UpdatePrivateCustomAttributesPartially.Builder.SetWrapperObject(this); }
        }
        public UpdateUserProfileStatus.UpdateUserProfileStatusBuilder UpdateUserProfileStatusOp
        {
            get { return Operation.UpdateUserProfileStatus.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserProfilePublicInfoByIds.PublicGetUserProfilePublicInfoByIdsBuilder PublicGetUserProfilePublicInfoByIdsOp
        {
            get { return Operation.PublicGetUserProfilePublicInfoByIds.Builder.SetWrapperObject(this); }
        }
        public GetMyProfileInfo.GetMyProfileInfoBuilder GetMyProfileInfoOp
        {
            get { return Operation.GetMyProfileInfo.Builder.SetWrapperObject(this); }
        }
        public UpdateMyProfile.UpdateMyProfileBuilder UpdateMyProfileOp
        {
            get { return Operation.UpdateMyProfile.Builder.SetWrapperObject(this); }
        }
        public CreateMyProfile.CreateMyProfileBuilder CreateMyProfileOp
        {
            get { return Operation.CreateMyProfile.Builder.SetWrapperObject(this); }
        }
        public GetMyZipCode.GetMyZipCodeBuilder GetMyZipCodeOp
        {
            get { return Operation.GetMyZipCode.Builder.SetWrapperObject(this); }
        }
        public UpdateMyZipCode.UpdateMyZipCodeBuilder UpdateMyZipCodeOp
        {
            get { return Operation.UpdateMyZipCode.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserProfileInfo.PublicGetUserProfileInfoBuilder PublicGetUserProfileInfoOp
        {
            get { return Operation.PublicGetUserProfileInfo.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateUserProfile.PublicUpdateUserProfileBuilder PublicUpdateUserProfileOp
        {
            get { return Operation.PublicUpdateUserProfile.Builder.SetWrapperObject(this); }
        }
        public PublicCreateUserProfile.PublicCreateUserProfileBuilder PublicCreateUserProfileOp
        {
            get { return Operation.PublicCreateUserProfile.Builder.SetWrapperObject(this); }
        }
        public PublicGetCustomAttributesInfo.PublicGetCustomAttributesInfoBuilder PublicGetCustomAttributesInfoOp
        {
            get { return Operation.PublicGetCustomAttributesInfo.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateCustomAttributesPartially.PublicUpdateCustomAttributesPartiallyBuilder PublicUpdateCustomAttributesPartiallyOp
        {
            get { return Operation.PublicUpdateCustomAttributesPartially.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserProfilePublicInfo.PublicGetUserProfilePublicInfoBuilder PublicGetUserProfilePublicInfoOp
        {
            get { return Operation.PublicGetUserProfilePublicInfo.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateUserProfileStatus.PublicUpdateUserProfileStatusBuilder PublicUpdateUserProfileStatusOp
        {
            get { return Operation.PublicUpdateUserProfileStatus.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.UserProfilePublicInfo>? AdminGetUserProfilePublicInfoByIds(AdminGetUserProfilePublicInfoByIds input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? GetUserProfileInfo(GetUserProfileInfo input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? UpdateUserProfile(UpdateUserProfile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? DeleteUserProfile(DeleteUserProfile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? GetCustomAttributesInfo(GetCustomAttributesInfo input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? UpdateCustomAttributesPartially(UpdateCustomAttributesPartially input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? GetPrivateCustomAttributesInfo(GetPrivateCustomAttributesInfo input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? UpdatePrivateCustomAttributesPartially(UpdatePrivateCustomAttributesPartially input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? UpdateUserProfileStatus(UpdateUserProfileStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.UserProfilePublicInfo>? PublicGetUserProfilePublicInfoByIds(PublicGetUserProfilePublicInfoByIds input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? GetMyProfileInfo(GetMyProfileInfo input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? UpdateMyProfile(UpdateMyProfile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePrivateInfo? CreateMyProfile(CreateMyProfile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserZipCode? GetMyZipCode(GetMyZipCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserZipCode? UpdateMyZipCode(UpdateMyZipCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfileInfo? PublicGetUserProfileInfo(PublicGetUserProfileInfo input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfileInfo? PublicUpdateUserProfile(PublicUpdateUserProfile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfileInfo? PublicCreateUserProfile(PublicCreateUserProfile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? PublicGetCustomAttributesInfo(PublicGetCustomAttributesInfo input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? PublicUpdateCustomAttributesPartially(PublicUpdateCustomAttributesPartially input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfilePublicInfo? PublicGetUserProfilePublicInfo(PublicGetUserProfilePublicInfo input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserProfileInfo? PublicUpdateUserProfileStatus(PublicUpdateUserProfileStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}