// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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

        public Model.NamespaceSlotConfigInfo? GetNamespaceSlotConfig(GetNamespaceSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceSlotConfigInfo? UpdateNamespaceSlotConfig(UpdateNamespaceSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteNamespaceSlotConfig(DeleteNamespaceSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSlotConfigInfo? GetUserSlotConfig(GetUserSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSlotConfigInfo? UpdateUserSlotConfig(UpdateUserSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserSlotConfig(DeleteUserSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}