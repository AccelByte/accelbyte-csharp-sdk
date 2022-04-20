// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class Anonymization
    {
        private readonly AccelByteSDK _sdk;

        public Anonymization(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminDeleteAllUserChannels.AdminDeleteAllUserChannelsBuilder AdminDeleteAllUserChannelsOp
        {
            get { return Operation.AdminDeleteAllUserChannels.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteAllUserContents.AdminDeleteAllUserContentsBuilder AdminDeleteAllUserContentsOp
        {
            get { return Operation.AdminDeleteAllUserContents.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteAllUserGroup.AdminDeleteAllUserGroupBuilder AdminDeleteAllUserGroupOp
        {
            get { return Operation.AdminDeleteAllUserGroup.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteAllUserStates.AdminDeleteAllUserStatesBuilder AdminDeleteAllUserStatesOp
        {
            get { return Operation.AdminDeleteAllUserStates.Builder.SetWrapperObject(this); }
        }
        public DeleteAllUserChannel.DeleteAllUserChannelBuilder DeleteAllUserChannelOp
        {
            get { return Operation.DeleteAllUserChannel.Builder.SetWrapperObject(this); }
        }
        public DeleteAllUserContents.DeleteAllUserContentsBuilder DeleteAllUserContentsOp
        {
            get { return Operation.DeleteAllUserContents.Builder.SetWrapperObject(this); }
        }
        public DeleteAllUserGroup.DeleteAllUserGroupBuilder DeleteAllUserGroupOp
        {
            get { return Operation.DeleteAllUserGroup.Builder.SetWrapperObject(this); }
        }
        public DeleteAllUserStates.DeleteAllUserStatesBuilder DeleteAllUserStatesOp
        {
            get { return Operation.DeleteAllUserStates.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void AdminDeleteAllUserChannels(AdminDeleteAllUserChannels input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteAllUserContents(AdminDeleteAllUserContents input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteAllUserGroup(AdminDeleteAllUserGroup input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteAllUserStates(AdminDeleteAllUserStates input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAllUserChannel(DeleteAllUserChannel input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAllUserContents(DeleteAllUserContents input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAllUserGroup(DeleteAllUserGroup input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAllUserStates(DeleteAllUserStates input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Anonymization_OperationExtensions
    {
        public static void Execute(
            this AdminDeleteAllUserChannels.AdminDeleteAllUserChannelsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminDeleteAllUserChannels op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AdminDeleteAllUserChannels(op);
        }

        public static void Execute(
            this AdminDeleteAllUserContents.AdminDeleteAllUserContentsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminDeleteAllUserContents op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AdminDeleteAllUserContents(op);
        }

        public static void Execute(
            this AdminDeleteAllUserGroup.AdminDeleteAllUserGroupBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminDeleteAllUserGroup op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AdminDeleteAllUserGroup(op);
        }

        public static void Execute(
            this AdminDeleteAllUserStates.AdminDeleteAllUserStatesBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminDeleteAllUserStates op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).AdminDeleteAllUserStates(op);
        }

        public static void Execute(
            this DeleteAllUserChannel.DeleteAllUserChannelBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteAllUserChannel op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).DeleteAllUserChannel(op);
        }

        public static void Execute(
            this DeleteAllUserContents.DeleteAllUserContentsBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteAllUserContents op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).DeleteAllUserContents(op);
        }

        public static void Execute(
            this DeleteAllUserGroup.DeleteAllUserGroupBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteAllUserGroup op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).DeleteAllUserGroup(op);
        }

        public static void Execute(
            this DeleteAllUserStates.DeleteAllUserStatesBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteAllUserStates op = builder.Build(
                namespace_,
                userId
            );

            ((Anonymization)builder.WrapperObject!).DeleteAllUserStates(op);
        }

    }
}