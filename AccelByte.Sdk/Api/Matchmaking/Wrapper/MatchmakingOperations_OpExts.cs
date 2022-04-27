// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class MatchmakingMatchmakingOperations_OpExts
    {
        public static void Execute(
            this GetHealthcheckInfo.GetHealthcheckInfoBuilder builder
        )
        {
            GetHealthcheckInfo op = builder.Build(
            );

            ((Matchmaking.Wrapper.MatchmakingOperations)builder.WrapperObject!).GetHealthcheckInfo(op);
        }

        public static void Execute(
            this HandlerV3Healthz.HandlerV3HealthzBuilder builder
        )
        {
            HandlerV3Healthz op = builder.Build(
            );

            ((Matchmaking.Wrapper.MatchmakingOperations)builder.WrapperObject!).HandlerV3Healthz(op);
        }

        public static List<Matchmaking.Model.LogAppMessageDeclaration>? Execute(
            this PublicGetMessages.PublicGetMessagesBuilder builder
        )
        {
            PublicGetMessages op = builder.Build(
            );

            return ((Matchmaking.Wrapper.MatchmakingOperations)builder.WrapperObject!).PublicGetMessages(op);
        }

        public static void Execute(
            this VersionCheckHandler.VersionCheckHandlerBuilder builder
        )
        {
            VersionCheckHandler op = builder.Build(
            );

            ((Matchmaking.Wrapper.MatchmakingOperations)builder.WrapperObject!).VersionCheckHandler(op);
        }

    }
}