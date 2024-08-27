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

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social", "bulkgetordefaultbyuserid")]
    public class BulkGetOrDefaultByUserIdCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "BulkGetOrDefaultByUserId"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("additionalKey")]
        public string? AdditionalKey { get; set; }

        [SdkCommandData("body")]
        public BulkUserStatItemByStatCodes Body { get; set; } = new BulkUserStatItemByStatCodes();

        public BulkGetOrDefaultByUserIdCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.BulkGetOrDefaultByUserId.Builder;

            if (AdditionalKey != null)
                opBuilder.SetAdditionalKey((string)AdditionalKey);

            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Social.Model.BulkUserStatItemByStatCodes)Body);



            BulkGetOrDefaultByUserId operation = opBuilder.Build(
                Namespace,
                UserId
            );


            List<AccelByte.Sdk.Api.Social.Model.ADTOObjectForUserStatItemValue>? response = wrapper.BulkGetOrDefaultByUserId(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}