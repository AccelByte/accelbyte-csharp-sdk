// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Presence
    {
        private readonly AccelByteSDK _sdk;

        public Presence(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UsersPresenceHandlerV1.UsersPresenceHandlerV1Builder UsersPresenceHandlerV1Op
        {
            get { return Operation.UsersPresenceHandlerV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.HandlersGetUsersPresenceResponse? UsersPresenceHandlerV1(UsersPresenceHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Presence_OperationExtensions
    {
        public static Model.HandlersGetUsersPresenceResponse? Execute(
            this UsersPresenceHandlerV1.UsersPresenceHandlerV1Builder builder,
            string namespace_,
            string userIds
        )
        {
            UsersPresenceHandlerV1 op = builder.Build(
                namespace_,
                userIds
            );

            return ((Presence)builder.WrapperObject!).UsersPresenceHandlerV1(op);
        }

    }
}