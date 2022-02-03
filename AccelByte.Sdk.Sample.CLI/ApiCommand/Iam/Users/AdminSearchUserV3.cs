using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","adminsearchuserv3")]
    public class AdminSearchUserV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminSearchUserV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("by")]
        public string? By { get; set; }

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public string? Offset { get; set; }

        [SdkCommandArgument("platformBy")]
        public string? PlatformBy { get; set; }

        [SdkCommandArgument("platformId")]
        public string? PlatformId { get; set; }

        [SdkCommandArgument("query")]
        public string? Query { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        public AdminSearchUserV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            AdminSearchUserV3 operation = new AdminSearchUserV3(
                Namespace,                
                By,                
                EndDate,                
                Limit,                
                Offset,                
                PlatformBy,                
                PlatformId,                
                Query,                
                StartDate                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelSearchUsersResponseWithPaginationV3? response = wrapper.AdminSearchUserV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}