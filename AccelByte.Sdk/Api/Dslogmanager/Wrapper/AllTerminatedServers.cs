// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dslogmanager.Wrapper
{
    public class AllTerminatedServers
    {
        private readonly AccelByteSDK _sdk;

        public AllTerminatedServers(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public BatchDownloadServerLogs.BatchDownloadServerLogsBuilder BatchDownloadServerLogsOp
        {
            get { return Operation.BatchDownloadServerLogs.Builder.SetWrapperObject(this); }
        }
        public ListAllTerminatedServers.ListAllTerminatedServersBuilder ListAllTerminatedServersOp
        {
            get { return Operation.ListAllTerminatedServers.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void BatchDownloadServerLogs(BatchDownloadServerLogs input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListTerminatedServersResponse? ListAllTerminatedServers(ListAllTerminatedServers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}