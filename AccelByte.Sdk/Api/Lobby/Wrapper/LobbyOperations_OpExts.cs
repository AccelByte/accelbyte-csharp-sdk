// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyLobbyOperations_OpExts
    {
        public static Lobby.Model.ModelsPartyData? Execute(
            this AdminUpdatePartyAttributesV1.AdminUpdatePartyAttributesV1Builder builder,
            ModelsPartyPUTCustomAttributesRequest body,
            string namespace_,
            string partyId
        )
        {
            AdminUpdatePartyAttributesV1 op = builder.Build(
                body,
                namespace_,
                partyId
            );

            return ((Lobby.Wrapper.LobbyOperations)builder.WrapperObject!).AdminUpdatePartyAttributesV1(op);
        }

        public static void Execute(
            this AdminJoinPartyV1.AdminJoinPartyV1Builder builder,
            string namespace_,
            string partyId,
            string userId
        )
        {
            AdminJoinPartyV1 op = builder.Build(
                namespace_,
                partyId,
                userId
            );

            ((Lobby.Wrapper.LobbyOperations)builder.WrapperObject!).AdminJoinPartyV1(op);
        }

        public static List<Lobby.Model.LogAppMessageDeclaration>? Execute(
            this PublicGetMessages.PublicGetMessagesBuilder builder
        )
        {
            PublicGetMessages op = builder.Build(
            );

            return ((Lobby.Wrapper.LobbyOperations)builder.WrapperObject!).PublicGetMessages(op);
        }

    }
}