// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ams.Wrapper
{
    public class Servers
    {
        private readonly AccelByteSDK _sdk;

        public Servers(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public FleetServerHistory.FleetServerHistoryBuilder FleetServerHistoryOp
        {
            get { return Operation.FleetServerHistory.Builder.SetWrapperObject(this); }
        }
        public FleetServerInfo.FleetServerInfoBuilder FleetServerInfoOp
        {
            get { return Operation.FleetServerInfo.Builder.SetWrapperObject(this); }
        }
        public ServerHistory.ServerHistoryBuilder ServerHistoryOp
        {
            get { return Operation.ServerHistory.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApiDSHistoryList? FleetServerHistory(FleetServerHistory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiFleetServerInfoResponse? FleetServerInfo(FleetServerInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiFleetServerHistoryResponse? ServerHistory(ServerHistory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}