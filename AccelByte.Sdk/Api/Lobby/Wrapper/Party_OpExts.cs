// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyParty_OpExts
    {
        public static Lobby.Model.ModelsPartyData? Execute(
            this AdminGetPartyDataV1.AdminGetPartyDataV1Builder builder,
            string namespace_,
            string partyId
        )
        {
            AdminGetPartyDataV1 op = builder.Build(
                namespace_,
                partyId
            );

            return ((Lobby.Wrapper.Party)builder.WrapperObject!).AdminGetPartyDataV1(op);
        }

        public static Lobby.Model.ModelsPartyData? Execute(
            this AdminGetUserPartyV1.AdminGetUserPartyV1Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserPartyV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Lobby.Wrapper.Party)builder.WrapperObject!).AdminGetUserPartyV1(op);
        }

        public static Lobby.Model.ModelsPartyData? Execute(
            this PublicGetPartyDataV1.PublicGetPartyDataV1Builder builder,
            string namespace_,
            string partyId
        )
        {
            PublicGetPartyDataV1 op = builder.Build(
                namespace_,
                partyId
            );

            return ((Lobby.Wrapper.Party)builder.WrapperObject!).PublicGetPartyDataV1(op);
        }

        public static Lobby.Model.ModelsPartyData? Execute(
            this PublicUpdatePartyAttributesV1.PublicUpdatePartyAttributesV1Builder builder,
            ModelsPartyPUTCustomAttributesRequest body,
            string namespace_,
            string partyId
        )
        {
            PublicUpdatePartyAttributesV1 op = builder.Build(
                body,
                namespace_,
                partyId
            );

            return ((Lobby.Wrapper.Party)builder.WrapperObject!).PublicUpdatePartyAttributesV1(op);
        }

    }
}