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
    [SdkConsoleCommand("cloudsave", "adminputplayerrecordconcurrenthandlerv1")]
    public class AdminPutPlayerRecordConcurrentHandlerV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "AdminPutPlayerRecordConcurrentHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("responseBody")]
        public bool? ResponseBody { get; set; }

        [SdkCommandData("body")]
        public ModelsAdminConcurrentRecordRequest Body { get; set; } = new ModelsAdminConcurrentRecordRequest();

        public AdminPutPlayerRecordConcurrentHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminConcurrentRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminConcurrentRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.AdminPutPlayerRecordConcurrentHandlerV1.Builder;

            if (ResponseBody != null)
                opBuilder.SetResponseBody((bool)ResponseBody);




            AdminPutPlayerRecordConcurrentHandlerV1 operation = opBuilder.Build(
                Body,
                Key,
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsPlayerRecordConcurrentUpdateResponse? response = wrapper.AdminPutPlayerRecordConcurrentHandlerV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}