// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dslogmanager.Wrapper
{
    public class DslogmanagerOperations
    {
        private readonly AccelByteSDK _sdk;

        public DslogmanagerOperations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicGetMessages.PublicGetMessagesBuilder PublicGetMessagesOp
        {
            get { return Operation.PublicGetMessages.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.LogAppMessageDeclaration>? PublicGetMessages(PublicGetMessages input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}