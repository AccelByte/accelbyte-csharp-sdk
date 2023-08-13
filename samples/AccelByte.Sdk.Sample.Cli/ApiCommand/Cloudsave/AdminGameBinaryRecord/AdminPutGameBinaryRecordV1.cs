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
    [SdkConsoleCommand("cloudsave", "adminputgamebinaryrecordv1")]
    public class AdminPutGameBinaryRecordV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "AdminPutGameBinaryRecordV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsBinaryRecordRequest Body { get; set; } = new ModelsBinaryRecordRequest();

        public AdminPutGameBinaryRecordV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminGameBinaryRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminGameBinaryRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.AdminPutGameBinaryRecordV1.Builder;





            AdminPutGameBinaryRecordV1 operation = opBuilder.Build(
                Body,
                Key,
                Namespace
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsGameBinaryRecordResponse? response = wrapper.AdminPutGameBinaryRecordV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}