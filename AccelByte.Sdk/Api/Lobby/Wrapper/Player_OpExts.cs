// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyPlayer_OpExts
    {
        public static Lobby.Model.ModelsGetLobbyCcuResponse? Execute(
            this AdminGetLobbyCCU.AdminGetLobbyCCUBuilder builder,
            string namespace_
        )
        {
            AdminGetLobbyCCU op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Player)builder.WrapperObject!).AdminGetLobbyCCU(op);
        }

        public static Lobby.Model.ModelsGetAllPlayerSessionAttributeResponse? Execute(
            this AdminGetAllPlayerSessionAttribute.AdminGetAllPlayerSessionAttributeBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetAllPlayerSessionAttribute op = builder.Build(
                namespace_,
                userId
            );

            return ((Lobby.Wrapper.Player)builder.WrapperObject!).AdminGetAllPlayerSessionAttribute(op);
        }

        public static void Execute(
            this AdminSetPlayerSessionAttribute.AdminSetPlayerSessionAttributeBuilder builder,
            ModelsSetPlayerSessionAttributeRequest body,
            string namespace_,
            string userId
        )
        {
            AdminSetPlayerSessionAttribute op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Lobby.Wrapper.Player)builder.WrapperObject!).AdminSetPlayerSessionAttribute(op);
        }

        public static Lobby.Model.ModelsGetPlayerSessionAttributeResponse? Execute(
            this AdminGetPlayerSessionAttribute.AdminGetPlayerSessionAttributeBuilder builder,
            string attribute,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerSessionAttribute op = builder.Build(
                attribute,
                namespace_,
                userId
            );

            return ((Lobby.Wrapper.Player)builder.WrapperObject!).AdminGetPlayerSessionAttribute(op);
        }

        public static Lobby.Model.ModelsGetAllPlayerBlockedUsersResponse? Execute(
            this AdminGetPlayerBlockedPlayersV1.AdminGetPlayerBlockedPlayersV1Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerBlockedPlayersV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Lobby.Wrapper.Player)builder.WrapperObject!).AdminGetPlayerBlockedPlayersV1(op);
        }

        public static Lobby.Model.ModelsGetAllPlayerBlockedByUsersResponse? Execute(
            this AdminGetPlayerBlockedByPlayersV1.AdminGetPlayerBlockedByPlayersV1Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerBlockedByPlayersV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Lobby.Wrapper.Player)builder.WrapperObject!).AdminGetPlayerBlockedByPlayersV1(op);
        }

        public static void Execute(
            this AdminBulkBlockPlayersV1.AdminBulkBlockPlayersV1Builder builder,
            ModelsListBlockedPlayerRequest body,
            string namespace_,
            string userId
        )
        {
            AdminBulkBlockPlayersV1 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Lobby.Wrapper.Player)builder.WrapperObject!).AdminBulkBlockPlayersV1(op);
        }

        public static Lobby.Model.ModelsGetAllPlayerBlockedUsersResponse? Execute(
            this PublicGetPlayerBlockedPlayersV1.PublicGetPlayerBlockedPlayersV1Builder builder,
            string namespace_
        )
        {
            PublicGetPlayerBlockedPlayersV1 op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Player)builder.WrapperObject!).PublicGetPlayerBlockedPlayersV1(op);
        }

        public static Lobby.Model.ModelsGetAllPlayerBlockedByUsersResponse? Execute(
            this PublicGetPlayerBlockedByPlayersV1.PublicGetPlayerBlockedByPlayersV1Builder builder,
            string namespace_
        )
        {
            PublicGetPlayerBlockedByPlayersV1 op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Player)builder.WrapperObject!).PublicGetPlayerBlockedByPlayersV1(op);
        }

    }
}