// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyThirdParty_OpExts
    {
        public static Lobby.Model.ModelsGetConfigResponse? Execute(
            this AdminGetThirdPartyConfig.AdminGetThirdPartyConfigBuilder builder,
            string namespace_
        )
        {
            AdminGetThirdPartyConfig op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.ThirdParty)builder.WrapperObject!).AdminGetThirdPartyConfig(op);
        }

        public static Lobby.Model.ModelsUpdateConfigResponse? Execute(
            this AdminUpdateThirdPartyConfig.AdminUpdateThirdPartyConfigBuilder builder,
            ModelsUpdateConfigRequest body,
            string namespace_
        )
        {
            AdminUpdateThirdPartyConfig op = builder.Build(
                body,
                namespace_
            );

            return ((Lobby.Wrapper.ThirdParty)builder.WrapperObject!).AdminUpdateThirdPartyConfig(op);
        }

        public static Lobby.Model.ModelsCreateConfigResponse? Execute(
            this AdminCreateThirdPartyConfig.AdminCreateThirdPartyConfigBuilder builder,
            ModelsCreateConfigRequest body,
            string namespace_
        )
        {
            AdminCreateThirdPartyConfig op = builder.Build(
                body,
                namespace_
            );

            return ((Lobby.Wrapper.ThirdParty)builder.WrapperObject!).AdminCreateThirdPartyConfig(op);
        }

        public static string? Execute(
            this AdminDeleteThirdPartyConfig.AdminDeleteThirdPartyConfigBuilder builder,
            string namespace_
        )
        {
            AdminDeleteThirdPartyConfig op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.ThirdParty)builder.WrapperObject!).AdminDeleteThirdPartyConfig(op);
        }

    }
}