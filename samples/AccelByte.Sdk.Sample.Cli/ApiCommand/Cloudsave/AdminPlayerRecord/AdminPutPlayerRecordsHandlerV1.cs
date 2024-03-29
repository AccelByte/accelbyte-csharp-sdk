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
    [SdkConsoleCommand("cloudsave", "adminputplayerrecordshandlerv1")]
    public class AdminPutPlayerRecordsHandlerV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "AdminPutPlayerRecordsHandlerV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsBulkUpdatePlayerRecordsRequest Body { get; set; } = new ModelsBulkUpdatePlayerRecordsRequest();

        public AdminPutPlayerRecordsHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminPlayerRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminPlayerRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.AdminPutPlayerRecordsHandlerV1.Builder;





            AdminPutPlayerRecordsHandlerV1 operation = opBuilder.Build(
                Body,
                Namespace,
                UserId
            );


            List<AccelByte.Sdk.Api.Cloudsave.Model.ModelsBulkUpdatePlayerRecordResponse>? response = wrapper.AdminPutPlayerRecordsHandlerV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}