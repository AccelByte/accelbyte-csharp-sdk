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
    [SdkConsoleCommand("eventlog","deleteuseractivitieshandler")]
    public class DeleteUserActivitiesHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "DeleteUserActivitiesHandler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public DeleteUserActivitiesHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.UserInformation wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.UserInformation(_SDK);

            #pragma warning disable ab_deprecated_operation
            DeleteUserActivitiesHandler operation = new DeleteUserActivitiesHandler(
                Namespace,                
                UserId                
            );            
            #pragma warning restore ab_deprecated_operation
            
            #pragma warning disable ab_deprecated_operation_wrapper
            wrapper.DeleteUserActivitiesHandler(operation);
            return String.Empty;
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}