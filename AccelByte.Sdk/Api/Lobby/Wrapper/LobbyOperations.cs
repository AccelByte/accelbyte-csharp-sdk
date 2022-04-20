// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class LobbyOperations
    {
        private readonly AccelByteSDK _sdk;

        public LobbyOperations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminUpdatePartyAttributesV1.AdminUpdatePartyAttributesV1Builder AdminUpdatePartyAttributesV1Op
        {
            get { return Operation.AdminUpdatePartyAttributesV1.Builder.SetWrapperObject(this); }
        }
        public AdminJoinPartyV1.AdminJoinPartyV1Builder AdminJoinPartyV1Op
        {
            get { return Operation.AdminJoinPartyV1.Builder.SetWrapperObject(this); }
        }
        public PublicGetMessages.PublicGetMessagesBuilder PublicGetMessagesOp
        {
            get { return Operation.PublicGetMessages.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPartyData? AdminUpdatePartyAttributesV1(AdminUpdatePartyAttributesV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminJoinPartyV1(AdminJoinPartyV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.LogAppMessageDeclaration>? PublicGetMessages(PublicGetMessages input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}