using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Eventlog
{
    [SdkConsoleCommand("eventlog","getuseractivitieshandler")]
    public class GetUserActivitiesHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "GetUserActivitiesHandler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("offset")]
        public double? Offset { get; set; }

        [SdkCommandArgument("pageSize")]
        public double PageSize { get; set; } = 0.0;

        public GetUserActivitiesHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.UserInformation wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.UserInformation(_SDK);

            #pragma warning disable ab_deprecated_operation
            GetUserActivitiesHandler operation = new GetUserActivitiesHandler(
                Namespace,                
                UserId,                
                Offset,                
                PageSize                
            );            
            #pragma warning restore ab_deprecated_operation
            
            #pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventResponse? response = wrapper.GetUserActivitiesHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}