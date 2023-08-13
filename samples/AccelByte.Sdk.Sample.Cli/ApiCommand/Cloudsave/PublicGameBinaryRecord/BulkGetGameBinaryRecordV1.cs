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
    [SdkConsoleCommand("cloudsave", "bulkgetgamebinaryrecordv1")]
    public class BulkGetGameBinaryRecordV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "BulkGetGameBinaryRecordV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsBulkGetGameRecordRequest Body { get; set; } = new ModelsBulkGetGameRecordRequest();

        public BulkGetGameBinaryRecordV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicGameBinaryRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicGameBinaryRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.BulkGetGameBinaryRecordV1.Builder;





            BulkGetGameBinaryRecordV1 operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsBulkGetGameBinaryRecordResponse? response = wrapper.BulkGetGameBinaryRecordV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}