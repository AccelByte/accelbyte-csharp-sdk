// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dslogmanager.Wrapper
{
    public class TerminatedServers
    {
        private readonly AccelByteSDK _sdk;

        public TerminatedServers(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListTerminatedServers.ListTerminatedServersBuilder ListTerminatedServersOp
        {
            get { return Operation.ListTerminatedServers.Builder.SetWrapperObject(this); }
        }
        public DownloadServerLogs.DownloadServerLogsBuilder DownloadServerLogsOp
        {
            get { return Operation.DownloadServerLogs.Builder.SetWrapperObject(this); }
        }
        public CheckServerLogs.CheckServerLogsBuilder CheckServerLogsOp
        {
            get { return Operation.CheckServerLogs.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsListTerminatedServersResponse? ListTerminatedServers(ListTerminatedServers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DownloadServerLogs(DownloadServerLogs input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsLogFileStatus? CheckServerLogs(CheckServerLogs input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class TerminatedServers_OperationExtensions
    {
        public static Model.ModelsListTerminatedServersResponse? Execute(
            this ListTerminatedServers.ListTerminatedServersBuilder builder,
            string namespace_
        )
        {
            ListTerminatedServers op = builder.Build(
                namespace_
            );

            return ((TerminatedServers)builder.WrapperObject!).ListTerminatedServers(op);
        }

        public static void Execute(
            this DownloadServerLogs.DownloadServerLogsBuilder builder,
            string namespace_,
            string podName
        )
        {
            DownloadServerLogs op = builder.Build(
                namespace_,
                podName
            );

            ((TerminatedServers)builder.WrapperObject!).DownloadServerLogs(op);
        }

        public static Model.ModelsLogFileStatus? Execute(
            this CheckServerLogs.CheckServerLogsBuilder builder,
            string namespace_,
            string podName
        )
        {
            CheckServerLogs op = builder.Build(
                namespace_,
                podName
            );

            return ((TerminatedServers)builder.WrapperObject!).CheckServerLogs(op);
        }

    }
}