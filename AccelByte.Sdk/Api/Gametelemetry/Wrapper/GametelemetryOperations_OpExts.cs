// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;
using AccelByte.Sdk.Api.Gametelemetry.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GametelemetryGametelemetryOperations_OpExts
    {
        public static void Execute(
            this AdminGetEventsGameTelemetryV1AdminEventsGet.AdminGetEventsGameTelemetryV1AdminEventsGetBuilder builder,
            string namespace_,
            string accessToken
        )
        {
            AdminGetEventsGameTelemetryV1AdminEventsGet op = builder.Build(
                namespace_,
                accessToken                
            );

            ((Gametelemetry.Wrapper.GametelemetryOperations)builder.WrapperObject!).AdminGetEventsGameTelemetryV1AdminEventsGet(op);
        }

        public static void Execute(
            this AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet.AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetBuilder builder,
            string accessToken
        )
        {
            AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet op = builder.Build(
                accessToken                
            );

            ((Gametelemetry.Wrapper.GametelemetryOperations)builder.WrapperObject!).AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet(op);
        }

        public static void Execute(
            this ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder builder,
            List<TelemetryBody> body,
            string accessToken
        )
        {
            ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost op = builder.Build(
                body,
                accessToken                
            );

            ((Gametelemetry.Wrapper.GametelemetryOperations)builder.WrapperObject!).ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(op);
        }

        public static Dictionary<string, object>? Execute(
            this ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGetBuilder builder,
            string steamId,
            string accessToken
        )
        {
            ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet op = builder.Build(
                steamId,
                accessToken                
            );

            return ((Gametelemetry.Wrapper.GametelemetryOperations)builder.WrapperObject!).ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet(op);
        }

        public static void Execute(
            this ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePutBuilder builder,
            string playtime,
            string steamId,
            string accessToken
        )
        {
            ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut op = builder.Build(
                playtime,
                steamId,
                accessToken                
            );

            ((Gametelemetry.Wrapper.GametelemetryOperations)builder.WrapperObject!).ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut(op);
        }

    }
}