// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Qosm.Wrapper
{
    public class Server
    {
        private readonly AccelByteSDK _sdk;

        public Server(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public Heartbeat.HeartbeatBuilder HeartbeatOp
        {
            get { return Operation.Heartbeat.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void Heartbeat(Heartbeat input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Server_OperationExtensions
    {
        public static void Execute(
            this Heartbeat.HeartbeatBuilder builder,
            ModelsHeartbeatRequest body
        )
        {
            Heartbeat op = builder.Build(
                body
            );

            ((Server)builder.WrapperObject!).Heartbeat(op);
        }

    }
}