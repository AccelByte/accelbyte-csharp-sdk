// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Chat.Wrapper
{
    public class Moderation
    {
        private readonly AccelByteSDK _sdk;

        public Moderation(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetChatSnapshot.AdminGetChatSnapshotBuilder AdminGetChatSnapshotOp
        {
            get { return Operation.AdminGetChatSnapshot.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteChatSnapshot.AdminDeleteChatSnapshotBuilder AdminDeleteChatSnapshotOp
        {
            get { return Operation.AdminDeleteChatSnapshot.Builder.SetWrapperObject(this); }
        }
        public PublicGetChatSnapshot.PublicGetChatSnapshotBuilder PublicGetChatSnapshotOp
        {
            get { return Operation.PublicGetChatSnapshot.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsChatSnapshots? AdminGetChatSnapshot(AdminGetChatSnapshot input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteChatSnapshot(AdminDeleteChatSnapshot input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChatSnapshots? PublicGetChatSnapshot(PublicGetChatSnapshot input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}