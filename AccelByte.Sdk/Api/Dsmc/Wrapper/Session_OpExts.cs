// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsmcSession_OpExts
    {
        public static Dsmc.Model.ModelsSessionResponse? Execute(
            this CreateSession.CreateSessionBuilder builder,
            ModelsCreateSessionRequest body,
            string namespace_
        )
        {
            CreateSession op = builder.Build(
                body,
                namespace_
            );

            return ((Dsmc.Wrapper.Session)builder.WrapperObject!).CreateSession(op);
        }
        public static void Execute(
            this ClaimServer.ClaimServerBuilder builder,
            ModelsClaimSessionRequest body,
            string namespace_
        )
        {
            ClaimServer op = builder.Build(
                body,
                namespace_
            );

            ((Dsmc.Wrapper.Session)builder.WrapperObject!).ClaimServer(op);
        }
        public static Dsmc.Model.ModelsSessionResponse? Execute(
            this GetSession.GetSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            GetSession op = builder.Build(
                namespace_,
                sessionID
            );

            return ((Dsmc.Wrapper.Session)builder.WrapperObject!).GetSession(op);
        }
        public static void Execute(
            this CancelSession.CancelSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            CancelSession op = builder.Build(
                namespace_,
                sessionID
            );

            ((Dsmc.Wrapper.Session)builder.WrapperObject!).CancelSession(op);
        }
    }
}