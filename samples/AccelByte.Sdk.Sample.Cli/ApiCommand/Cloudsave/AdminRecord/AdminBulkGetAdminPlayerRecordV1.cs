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

using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Cloudsave
{
    [SdkConsoleCommand("cloudsave", "adminbulkgetadminplayerrecordv1")]
    public class AdminBulkGetAdminPlayerRecordV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "AdminBulkGetAdminPlayerRecordV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsBulkGetAdminPlayerRecordRequest Body { get; set; } = new ModelsBulkGetAdminPlayerRecordRequest();

        public AdminBulkGetAdminPlayerRecordV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.AdminBulkGetAdminPlayerRecordV1.Builder;





            AdminBulkGetAdminPlayerRecordV1 operation = opBuilder.Build(
                Body,
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsBulkGetAdminPlayerRecordResponse? response = wrapper.AdminBulkGetAdminPlayerRecordV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}