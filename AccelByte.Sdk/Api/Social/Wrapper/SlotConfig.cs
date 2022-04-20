// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class SlotConfig
    {
        private readonly AccelByteSDK _sdk;

        public SlotConfig(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetNamespaceSlotConfig.GetNamespaceSlotConfigBuilder GetNamespaceSlotConfigOp
        {
            get { return Operation.GetNamespaceSlotConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateNamespaceSlotConfig.UpdateNamespaceSlotConfigBuilder UpdateNamespaceSlotConfigOp
        {
            get { return Operation.UpdateNamespaceSlotConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteNamespaceSlotConfig.DeleteNamespaceSlotConfigBuilder DeleteNamespaceSlotConfigOp
        {
            get { return Operation.DeleteNamespaceSlotConfig.Builder.SetWrapperObject(this); }
        }
        public GetUserSlotConfig.GetUserSlotConfigBuilder GetUserSlotConfigOp
        {
            get { return Operation.GetUserSlotConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateUserSlotConfig.UpdateUserSlotConfigBuilder UpdateUserSlotConfigOp
        {
            get { return Operation.UpdateUserSlotConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteUserSlotConfig.DeleteUserSlotConfigBuilder DeleteUserSlotConfigOp
        {
            get { return Operation.DeleteUserSlotConfig.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.NamespaceSlotConfigInfo? GetNamespaceSlotConfig(GetNamespaceSlotConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceSlotConfigInfo? UpdateNamespaceSlotConfig(UpdateNamespaceSlotConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteNamespaceSlotConfig(DeleteNamespaceSlotConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSlotConfigInfo? GetUserSlotConfig(GetUserSlotConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSlotConfigInfo? UpdateUserSlotConfig(UpdateUserSlotConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserSlotConfig(DeleteUserSlotConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class SlotConfig_OperationExtensions
    {
        public static Model.NamespaceSlotConfigInfo? Execute(
            this GetNamespaceSlotConfig.GetNamespaceSlotConfigBuilder builder,
            string namespace_
        )
        {
            GetNamespaceSlotConfig op = builder.Build(
                namespace_
            );

            return ((SlotConfig)builder.WrapperObject!).GetNamespaceSlotConfig(op);
        }

        public static Model.NamespaceSlotConfigInfo? Execute(
            this UpdateNamespaceSlotConfig.UpdateNamespaceSlotConfigBuilder builder,
            string namespace_
        )
        {
            UpdateNamespaceSlotConfig op = builder.Build(
                namespace_
            );

            return ((SlotConfig)builder.WrapperObject!).UpdateNamespaceSlotConfig(op);
        }

        public static void Execute(
            this DeleteNamespaceSlotConfig.DeleteNamespaceSlotConfigBuilder builder,
            string namespace_
        )
        {
            DeleteNamespaceSlotConfig op = builder.Build(
                namespace_
            );

            ((SlotConfig)builder.WrapperObject!).DeleteNamespaceSlotConfig(op);
        }

        public static Model.UserSlotConfigInfo? Execute(
            this GetUserSlotConfig.GetUserSlotConfigBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserSlotConfig op = builder.Build(
                namespace_,
                userId
            );

            return ((SlotConfig)builder.WrapperObject!).GetUserSlotConfig(op);
        }

        public static Model.UserSlotConfigInfo? Execute(
            this UpdateUserSlotConfig.UpdateUserSlotConfigBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdateUserSlotConfig op = builder.Build(
                namespace_,
                userId
            );

            return ((SlotConfig)builder.WrapperObject!).UpdateUserSlotConfig(op);
        }

        public static void Execute(
            this DeleteUserSlotConfig.DeleteUserSlotConfigBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteUserSlotConfig op = builder.Build(
                namespace_,
                userId
            );

            ((SlotConfig)builder.WrapperObject!).DeleteUserSlotConfig(op);
        }

    }
}