// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

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
    [SdkConsoleCommand("iam","getuserbanhistory")]
    public class GetUserBanHistoryCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "GetUserBanHistory"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public GetUserBanHistoryCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            #pragma warning disable ab_deprecated_operation
            GetUserBanHistory operation = new GetUserBanHistory(
                Namespace,                
                UserId                
            );            
            #pragma warning restore ab_deprecated_operation
            
            #pragma warning disable ab_deprecated_operation_wrapper
            List<AccelByte.Sdk.Api.Iam.Model.ModelUserBanResponse>? response = wrapper.GetUserBanHistory(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}