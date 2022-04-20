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

    public static class PublicGroup_OperationExtensions
    {
        public static Model.ModelsPaginatedGroupResponse? Execute(
            this GetGroups.GetGroupsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetGroups op = builder.Build(
                namespace_,
                userId
            );

            return ((PublicGroup)builder.WrapperObject!).GetGroups(op);
        }

        public static Model.ModelsCreateGroupResponse? Execute(
            this CreateGroup.CreateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string namespace_,
            string userId
        )
        {
            CreateGroup op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((PublicGroup)builder.WrapperObject!).CreateGroup(op);
        }

        public static Model.ModelsCreateGroupResponse? Execute(
            this GetGroup.GetGroupBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            GetGroup op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((PublicGroup)builder.WrapperObject!).GetGroup(op);
        }

        public static Model.ModelsCreateGroupResponse? Execute(
            this UpdateGroup.UpdateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string groupId,
            string namespace_,
            string userId
        )
        {
            UpdateGroup op = builder.Build(
                body,
                groupId,
                namespace_,
                userId
            );

            return ((PublicGroup)builder.WrapperObject!).UpdateGroup(op);
        }

        public static void Execute(
            this DeleteGroup.DeleteGroupBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            DeleteGroup op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            ((PublicGroup)builder.WrapperObject!).DeleteGroup(op);
        }

        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this GetGroupContent.GetGroupContentBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            GetGroupContent op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((PublicGroup)builder.WrapperObject!).GetGroupContent(op);
        }

    }
}