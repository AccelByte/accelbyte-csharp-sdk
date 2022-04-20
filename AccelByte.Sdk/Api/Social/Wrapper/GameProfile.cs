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
}