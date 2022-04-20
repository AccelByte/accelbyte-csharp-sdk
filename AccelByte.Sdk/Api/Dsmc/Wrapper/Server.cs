// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class Server
    {
        private readonly AccelByteSDK _sdk;

        public Server(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public DeregisterLocalServer.DeregisterLocalServerBuilder DeregisterLocalServerOp
        {
            get { return Operation.DeregisterLocalServer.Builder.SetWrapperObject(this); }
        }
        public RegisterLocalServer.RegisterLocalServerBuilder RegisterLocalServerOp
        {
            get { return Operation.RegisterLocalServer.Builder.SetWrapperObject(this); }
        }
        public RegisterServer.RegisterServerBuilder RegisterServerOp
        {
            get { return Operation.RegisterServer.Builder.SetWrapperObject(this); }
        }
        public ShutdownServer.ShutdownServerBuilder ShutdownServerOp
        {
            get { return Operation.ShutdownServer.Builder.SetWrapperObject(this); }
        }
        public GetServerSession.GetServerSessionBuilder GetServerSessionOp
        {
            get { return Operation.GetServerSession.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void DeregisterLocalServer(DeregisterLocalServer input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsServer? RegisterLocalServer(RegisterLocalServer input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsServer? RegisterServer(RegisterServer input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ShutdownServer(ShutdownServer input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsServerSessionResponse? GetServerSession(GetServerSession input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}