// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class Session
    {
        private readonly AccelByteSDK _sdk;

        public Session(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreateSession.CreateSessionBuilder CreateSessionOp
        {
            get { return Operation.CreateSession.Builder.SetWrapperObject(this); }
        }
        public ClaimServer.ClaimServerBuilder ClaimServerOp
        {
            get { return Operation.ClaimServer.Builder.SetWrapperObject(this); }
        }
        public GetSession.GetSessionBuilder GetSessionOp
        {
            get { return Operation.GetSession.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsSessionResponse? CreateSession(CreateSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ClaimServer(ClaimServer input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? GetSession(GetSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Session_OperationExtensions
    {
        public static Model.ModelsSessionResponse? Execute(
            this CreateSession.CreateSessionBuilder builder,
            ModelsCreateSessionRequest body,
            string namespace_
        )
        {
            CreateSession op = builder.Build(
                body,
                namespace_
            );

            return ((Session)builder.WrapperObject!).CreateSession(op);
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

            ((Session)builder.WrapperObject!).ClaimServer(op);
        }

        public static Model.ModelsSessionResponse? Execute(
            this GetSession.GetSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            GetSession op = builder.Build(
                namespace_,
                sessionID
            );

            return ((Session)builder.WrapperObject!).GetSession(op);
        }

    }
}