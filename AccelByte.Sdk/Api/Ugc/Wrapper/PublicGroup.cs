// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicGroup
    {
        private readonly AccelByteSDK _sdk;

        public PublicGroup(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetGroups.GetGroupsBuilder GetGroupsOp
        {
            get { return Operation.GetGroups.Builder.SetWrapperObject(this); }
        }
        public CreateGroup.CreateGroupBuilder CreateGroupOp
        {
            get { return Operation.CreateGroup.Builder.SetWrapperObject(this); }
        }
        public GetGroup.GetGroupBuilder GetGroupOp
        {
            get { return Operation.GetGroup.Builder.SetWrapperObject(this); }
        }
        public UpdateGroup.UpdateGroupBuilder UpdateGroupOp
        {
            get { return Operation.UpdateGroup.Builder.SetWrapperObject(this); }
        }
        public DeleteGroup.DeleteGroupBuilder DeleteGroupOp
        {
            get { return Operation.DeleteGroup.Builder.SetWrapperObject(this); }
        }
        public GetGroupContent.GetGroupContentBuilder GetGroupContentOp
        {
            get { return Operation.GetGroupContent.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedGroupResponse? GetGroups(GetGroups input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? CreateGroup(CreateGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? GetGroup(GetGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? UpdateGroup(UpdateGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroup(DeleteGroup input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? GetGroupContent(GetGroupContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}