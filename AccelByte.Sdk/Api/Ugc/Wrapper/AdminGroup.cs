// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminGroup
    {
        private readonly AccelByteSDK _sdk;

        public AdminGroup(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public SingleAdminGetAllGroups.SingleAdminGetAllGroupsBuilder SingleAdminGetAllGroupsOp
        {
            get { return Operation.SingleAdminGetAllGroups.Builder.SetWrapperObject(this); }
        }
        public AdminCreateGroup.AdminCreateGroupBuilder AdminCreateGroupOp
        {
            get { return Operation.AdminCreateGroup.Builder.SetWrapperObject(this); }
        }
        public SingleAdminGetGroup.SingleAdminGetGroupBuilder SingleAdminGetGroupOp
        {
            get { return Operation.SingleAdminGetGroup.Builder.SetWrapperObject(this); }
        }
        public SingleAdminUpdateGroup.SingleAdminUpdateGroupBuilder SingleAdminUpdateGroupOp
        {
            get { return Operation.SingleAdminUpdateGroup.Builder.SetWrapperObject(this); }
        }
        public SingleAdminDeleteGroup.SingleAdminDeleteGroupBuilder SingleAdminDeleteGroupOp
        {
            get { return Operation.SingleAdminDeleteGroup.Builder.SetWrapperObject(this); }
        }
        public SingleAdminGetGroupContents.SingleAdminGetGroupContentsBuilder SingleAdminGetGroupContentsOp
        {
            get { return Operation.SingleAdminGetGroupContents.Builder.SetWrapperObject(this); }
        }
        public AdminGetAllGroups.AdminGetAllGroupsBuilder AdminGetAllGroupsOp
        {
            get { return Operation.AdminGetAllGroups.Builder.SetWrapperObject(this); }
        }
        public AdminGetGroup.AdminGetGroupBuilder AdminGetGroupOp
        {
            get { return Operation.AdminGetGroup.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateGroup.AdminUpdateGroupBuilder AdminUpdateGroupOp
        {
            get { return Operation.AdminUpdateGroup.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteGroup.AdminDeleteGroupBuilder AdminDeleteGroupOp
        {
            get { return Operation.AdminDeleteGroup.Builder.SetWrapperObject(this); }
        }
        public AdminGetGroupContents.AdminGetGroupContentsBuilder AdminGetGroupContentsOp
        {
            get { return Operation.AdminGetGroupContents.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedGroupResponse? SingleAdminGetAllGroups(SingleAdminGetAllGroups input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? AdminCreateGroup(AdminCreateGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? SingleAdminGetGroup(SingleAdminGetGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? SingleAdminUpdateGroup(SingleAdminUpdateGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SingleAdminDeleteGroup(SingleAdminDeleteGroup input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? SingleAdminGetGroupContents(SingleAdminGetGroupContents input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedGroupResponse? AdminGetAllGroups(AdminGetAllGroups input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? AdminGetGroup(AdminGetGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? AdminUpdateGroup(AdminUpdateGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteGroup(AdminDeleteGroup input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? AdminGetGroupContents(AdminGetGroupContents input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class AdminGroup_OperationExtensions
    {
        public static Model.ModelsPaginatedGroupResponse? Execute(
            this SingleAdminGetAllGroups.SingleAdminGetAllGroupsBuilder builder,
            string namespace_
        )
        {
            SingleAdminGetAllGroups op = builder.Build(
                namespace_
            );

            return ((AdminGroup)builder.WrapperObject!).SingleAdminGetAllGroups(op);
        }

        public static Model.ModelsCreateGroupResponse? Execute(
            this AdminCreateGroup.AdminCreateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string namespace_
        )
        {
            AdminCreateGroup op = builder.Build(
                body,
                namespace_
            );

            return ((AdminGroup)builder.WrapperObject!).AdminCreateGroup(op);
        }

        public static Model.ModelsCreateGroupResponse? Execute(
            this SingleAdminGetGroup.SingleAdminGetGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            SingleAdminGetGroup op = builder.Build(
                groupId,
                namespace_
            );

            return ((AdminGroup)builder.WrapperObject!).SingleAdminGetGroup(op);
        }

        public static Model.ModelsCreateGroupResponse? Execute(
            this SingleAdminUpdateGroup.SingleAdminUpdateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string groupId,
            string namespace_
        )
        {
            SingleAdminUpdateGroup op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((AdminGroup)builder.WrapperObject!).SingleAdminUpdateGroup(op);
        }

        public static void Execute(
            this SingleAdminDeleteGroup.SingleAdminDeleteGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            SingleAdminDeleteGroup op = builder.Build(
                groupId,
                namespace_
            );

            ((AdminGroup)builder.WrapperObject!).SingleAdminDeleteGroup(op);
        }

        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this SingleAdminGetGroupContents.SingleAdminGetGroupContentsBuilder builder,
            string groupId,
            string namespace_
        )
        {
            SingleAdminGetGroupContents op = builder.Build(
                groupId,
                namespace_
            );

            return ((AdminGroup)builder.WrapperObject!).SingleAdminGetGroupContents(op);
        }

        public static Model.ModelsPaginatedGroupResponse? Execute(
            this AdminGetAllGroups.AdminGetAllGroupsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetAllGroups op = builder.Build(
                namespace_,
                userId
            );

            return ((AdminGroup)builder.WrapperObject!).AdminGetAllGroups(op);
        }

        public static Model.ModelsCreateGroupResponse? Execute(
            this AdminGetGroup.AdminGetGroupBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            AdminGetGroup op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((AdminGroup)builder.WrapperObject!).AdminGetGroup(op);
        }

        public static Model.ModelsCreateGroupResponse? Execute(
            this AdminUpdateGroup.AdminUpdateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string groupId,
            string namespace_,
            string userId
        )
        {
            AdminUpdateGroup op = builder.Build(
                body,
                groupId,
                namespace_,
                userId
            );

            return ((AdminGroup)builder.WrapperObject!).AdminUpdateGroup(op);
        }

        public static void Execute(
            this AdminDeleteGroup.AdminDeleteGroupBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            AdminDeleteGroup op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            ((AdminGroup)builder.WrapperObject!).AdminDeleteGroup(op);
        }

        public static Model.ModelsPaginatedContentDownloadResponse? Execute(
            this AdminGetGroupContents.AdminGetGroupContentsBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            AdminGetGroupContents op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((AdminGroup)builder.WrapperObject!).AdminGetGroupContents(op);
        }

    }
}