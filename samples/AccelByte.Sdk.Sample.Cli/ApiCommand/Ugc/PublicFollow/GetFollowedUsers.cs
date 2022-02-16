// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","getfollowedusers")]
    public class GetFollowedUsersCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "GetFollowedUsers"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public string? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public string? Offset { get; set; }

        public GetFollowedUsersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicFollow wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicFollow(_SDK);

            GetFollowedUsers operation = new GetFollowedUsers(
                Namespace,                
                Limit,                
                Offset                
            );            
            
            AccelByte.Sdk.Api.Ugc.Model.ModelsPaginatedCreatorOverviewResponse? response = wrapper.GetFollowedUsers(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}