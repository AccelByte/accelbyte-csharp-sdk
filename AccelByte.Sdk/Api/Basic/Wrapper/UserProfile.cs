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

    public static class UserProfile_OperationExtensions
    {
        public static List<Model.UserProfilePublicInfo>? Execute(
            this AdminGetUserProfilePublicInfoByIds.AdminGetUserProfilePublicInfoByIdsBuilder builder,
            string namespace_
        )
        {
            AdminGetUserProfilePublicInfoByIds op = builder.Build(
                namespace_
            );

            return ((UserProfile)builder.WrapperObject!).AdminGetUserProfilePublicInfoByIds(op);
        }

        public static Model.UserProfilePrivateInfo? Execute(
            this GetUserProfileInfo.GetUserProfileInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserProfileInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).GetUserProfileInfo(op);
        }

        public static Model.UserProfilePrivateInfo? Execute(
            this UpdateUserProfile.UpdateUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdateUserProfile op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).UpdateUserProfile(op);
        }

        public static Model.UserProfilePrivateInfo? Execute(
            this DeleteUserProfile.DeleteUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteUserProfile op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).DeleteUserProfile(op);
        }

        public static Dictionary<string, object>? Execute(
            this GetCustomAttributesInfo.GetCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetCustomAttributesInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).GetCustomAttributesInfo(op);
        }

        public static Dictionary<string, object>? Execute(
            this UpdateCustomAttributesPartially.UpdateCustomAttributesPartiallyBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdateCustomAttributesPartially op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).UpdateCustomAttributesPartially(op);
        }

        public static Dictionary<string, object>? Execute(
            this GetPrivateCustomAttributesInfo.GetPrivateCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetPrivateCustomAttributesInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).GetPrivateCustomAttributesInfo(op);
        }

        public static Dictionary<string, object>? Execute(
            this UpdatePrivateCustomAttributesPartially.UpdatePrivateCustomAttributesPartiallyBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdatePrivateCustomAttributesPartially op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).UpdatePrivateCustomAttributesPartially(op);
        }

        public static Model.UserProfilePrivateInfo? Execute(
            this UpdateUserProfileStatus.UpdateUserProfileStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdateUserProfileStatus op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).UpdateUserProfileStatus(op);
        }

        public static List<Model.UserProfilePublicInfo>? Execute(
            this PublicGetUserProfilePublicInfoByIds.PublicGetUserProfilePublicInfoByIdsBuilder builder,
            string namespace_,
            string userIds
        )
        {
            PublicGetUserProfilePublicInfoByIds op = builder.Build(
                namespace_,
                userIds
            );

            return ((UserProfile)builder.WrapperObject!).PublicGetUserProfilePublicInfoByIds(op);
        }

        public static Model.UserProfilePrivateInfo? Execute(
            this GetMyProfileInfo.GetMyProfileInfoBuilder builder,
            string namespace_
        )
        {
            GetMyProfileInfo op = builder.Build(
                namespace_
            );

            return ((UserProfile)builder.WrapperObject!).GetMyProfileInfo(op);
        }

        public static Model.UserProfilePrivateInfo? Execute(
            this UpdateMyProfile.UpdateMyProfileBuilder builder,
            string namespace_
        )
        {
            UpdateMyProfile op = builder.Build(
                namespace_
            );

            return ((UserProfile)builder.WrapperObject!).UpdateMyProfile(op);
        }

        public static Model.UserProfilePrivateInfo? Execute(
            this CreateMyProfile.CreateMyProfileBuilder builder,
            string namespace_
        )
        {
            CreateMyProfile op = builder.Build(
                namespace_
            );

            return ((UserProfile)builder.WrapperObject!).CreateMyProfile(op);
        }

        public static Model.UserZipCode? Execute(
            this GetMyZipCode.GetMyZipCodeBuilder builder,
            string namespace_
        )
        {
            GetMyZipCode op = builder.Build(
                namespace_
            );

            return ((UserProfile)builder.WrapperObject!).GetMyZipCode(op);
        }

        public static Model.UserZipCode? Execute(
            this UpdateMyZipCode.UpdateMyZipCodeBuilder builder,
            UserZipCodeUpdate userZipCodeUpdate,
            string namespace_
        )
        {
            UpdateMyZipCode op = builder.Build(
                userZipCodeUpdate,
                namespace_
            );

            return ((UserProfile)builder.WrapperObject!).UpdateMyZipCode(op);
        }

        public static Model.UserProfileInfo? Execute(
            this PublicGetUserProfileInfo.PublicGetUserProfileInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserProfileInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).PublicGetUserProfileInfo(op);
        }

        public static Model.UserProfileInfo? Execute(
            this PublicUpdateUserProfile.PublicUpdateUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicUpdateUserProfile op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).PublicUpdateUserProfile(op);
        }

        public static Model.UserProfileInfo? Execute(
            this PublicCreateUserProfile.PublicCreateUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicCreateUserProfile op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).PublicCreateUserProfile(op);
        }

        public static Dictionary<string, object>? Execute(
            this PublicGetCustomAttributesInfo.PublicGetCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetCustomAttributesInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).PublicGetCustomAttributesInfo(op);
        }

        public static Dictionary<string, object>? Execute(
            this PublicUpdateCustomAttributesPartially.PublicUpdateCustomAttributesPartiallyBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicUpdateCustomAttributesPartially op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).PublicUpdateCustomAttributesPartially(op);
        }

        public static Model.UserProfilePublicInfo? Execute(
            this PublicGetUserProfilePublicInfo.PublicGetUserProfilePublicInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserProfilePublicInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).PublicGetUserProfilePublicInfo(op);
        }

        public static Model.UserProfileInfo? Execute(
            this PublicUpdateUserProfileStatus.PublicUpdateUserProfileStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicUpdateUserProfileStatus op = builder.Build(
                namespace_,
                userId
            );

            return ((UserProfile)builder.WrapperObject!).PublicUpdateUserProfileStatus(op);
        }

    }
}