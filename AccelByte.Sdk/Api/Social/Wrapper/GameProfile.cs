// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class GameProfile
    {
        private readonly AccelByteSDK _sdk;

        public GameProfile(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetUserProfiles.GetUserProfilesBuilder GetUserProfilesOp
        {
            get { return Operation.GetUserProfiles.Builder.SetWrapperObject(this); }
        }
        public GetProfile.GetProfileBuilder GetProfileOp
        {
            get { return Operation.GetProfile.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserGameProfiles.PublicGetUserGameProfilesBuilder PublicGetUserGameProfilesOp
        {
            get { return Operation.PublicGetUserGameProfiles.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserProfiles.PublicGetUserProfilesBuilder PublicGetUserProfilesOp
        {
            get { return Operation.PublicGetUserProfiles.Builder.SetWrapperObject(this); }
        }
        public PublicCreateProfile.PublicCreateProfileBuilder PublicCreateProfileOp
        {
            get { return Operation.PublicCreateProfile.Builder.SetWrapperObject(this); }
        }
        public PublicGetProfile.PublicGetProfileBuilder PublicGetProfileOp
        {
            get { return Operation.PublicGetProfile.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateProfile.PublicUpdateProfileBuilder PublicUpdateProfileOp
        {
            get { return Operation.PublicUpdateProfile.Builder.SetWrapperObject(this); }
        }
        public PublicDeleteProfile.PublicDeleteProfileBuilder PublicDeleteProfileOp
        {
            get { return Operation.PublicDeleteProfile.Builder.SetWrapperObject(this); }
        }
        public PublicGetProfileAttribute.PublicGetProfileAttributeBuilder PublicGetProfileAttributeOp
        {
            get { return Operation.PublicGetProfileAttribute.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateAttribute.PublicUpdateAttributeBuilder PublicUpdateAttributeOp
        {
            get { return Operation.PublicUpdateAttribute.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.GameProfileHeader>? GetUserProfiles(GetUserProfiles input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.GameProfileInfo? GetProfile(GetProfile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.UserGameProfiles>? PublicGetUserGameProfiles(PublicGetUserGameProfiles input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.GameProfileHeader>? PublicGetUserProfiles(PublicGetUserProfiles input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCreateProfile(PublicCreateProfile input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.GameProfileInfo? PublicGetProfile(PublicGetProfile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.GameProfileInfo? PublicUpdateProfile(PublicUpdateProfile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeleteProfile(PublicDeleteProfile input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Attribute? PublicGetProfileAttribute(PublicGetProfileAttribute input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.GameProfileInfo? PublicUpdateAttribute(PublicUpdateAttribute input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class GameProfile_OperationExtensions
    {
        public static List<Model.GameProfileHeader>? Execute(
            this GetUserProfiles.GetUserProfilesBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserProfiles op = builder.Build(
                namespace_,
                userId
            );

            return ((GameProfile)builder.WrapperObject!).GetUserProfiles(op);
        }

        public static Model.GameProfileInfo? Execute(
            this GetProfile.GetProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            GetProfile op = builder.Build(
                namespace_,
                profileId,
                userId
            );

            return ((GameProfile)builder.WrapperObject!).GetProfile(op);
        }

        public static List<Model.UserGameProfiles>? Execute(
            this PublicGetUserGameProfiles.PublicGetUserGameProfilesBuilder builder,
            string namespace_,
            List<string> userIds
        )
        {
            PublicGetUserGameProfiles op = builder.Build(
                namespace_,
                userIds
            );

            return ((GameProfile)builder.WrapperObject!).PublicGetUserGameProfiles(op);
        }

        public static List<Model.GameProfileHeader>? Execute(
            this PublicGetUserProfiles.PublicGetUserProfilesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserProfiles op = builder.Build(
                namespace_,
                userId
            );

            return ((GameProfile)builder.WrapperObject!).PublicGetUserProfiles(op);
        }

        public static void Execute(
            this PublicCreateProfile.PublicCreateProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicCreateProfile op = builder.Build(
                namespace_,
                userId
            );

            ((GameProfile)builder.WrapperObject!).PublicCreateProfile(op);
        }

        public static Model.GameProfileInfo? Execute(
            this PublicGetProfile.PublicGetProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicGetProfile op = builder.Build(
                namespace_,
                profileId,
                userId
            );

            return ((GameProfile)builder.WrapperObject!).PublicGetProfile(op);
        }

        public static Model.GameProfileInfo? Execute(
            this PublicUpdateProfile.PublicUpdateProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicUpdateProfile op = builder.Build(
                namespace_,
                profileId,
                userId
            );

            return ((GameProfile)builder.WrapperObject!).PublicUpdateProfile(op);
        }

        public static void Execute(
            this PublicDeleteProfile.PublicDeleteProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicDeleteProfile op = builder.Build(
                namespace_,
                profileId,
                userId
            );

            ((GameProfile)builder.WrapperObject!).PublicDeleteProfile(op);
        }

        public static Model.Attribute? Execute(
            this PublicGetProfileAttribute.PublicGetProfileAttributeBuilder builder,
            string attributeName,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicGetProfileAttribute op = builder.Build(
                attributeName,
                namespace_,
                profileId,
                userId
            );

            return ((GameProfile)builder.WrapperObject!).PublicGetProfileAttribute(op);
        }

        public static Model.GameProfileInfo? Execute(
            this PublicUpdateAttribute.PublicUpdateAttributeBuilder builder,
            string attributeName,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicUpdateAttribute op = builder.Build(
                attributeName,
                namespace_,
                profileId,
                userId
            );

            return ((GameProfile)builder.WrapperObject!).PublicUpdateAttribute(op);
        }

    }
}