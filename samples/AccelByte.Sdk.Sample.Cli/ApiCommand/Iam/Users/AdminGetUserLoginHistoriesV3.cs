// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam", "admingetuserloginhistoriesv3")]
    public class AdminGetUserLoginHistoriesV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminGetUserLoginHistoriesV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("after")]
        public double? After { get; set; }

        [SdkCommandArgument("before")]
        public double? Before { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        public AdminGetUserLoginHistoriesV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetUserLoginHistoriesV3.Builder;

            if (After != null)
                opBuilder.SetAfter((double)After);
            if (Before != null)
                opBuilder.SetBefore((double)Before);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);




            AdminGetUserLoginHistoriesV3 operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Iam.Model.ModelLoginHistoriesResponse? response = wrapper.AdminGetUserLoginHistoriesV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}