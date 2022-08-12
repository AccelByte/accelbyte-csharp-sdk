// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyPresence_OpExts
    {
        public static Lobby.Model.HandlersGetUsersPresenceResponse? Execute(
            this UsersPresenceHandlerV1.UsersPresenceHandlerV1Builder builder,
            string namespace_,
            string userIds
        )
        {
            UsersPresenceHandlerV1 op = builder.Build(
                namespace_,
                userIds
            );

            return ((Lobby.Wrapper.Presence)builder.WrapperObject!).UsersPresenceHandlerV1(op);
        }

    }
}