// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Chat.Wrapper
{
    public class Operations
    {
        private readonly AccelByteSDK _sdk;

        public Operations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicGetMessages.PublicGetMessagesBuilder PublicGetMessagesOp
        {
            get { return Operation.PublicGetMessages.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<Model.LogAppMessageDeclaration>? PublicGetMessages(PublicGetMessages input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}