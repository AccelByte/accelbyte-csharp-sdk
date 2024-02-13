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
    [SdkConsoleCommand("cloudsave", "deletegamebinaryrecordttlconfig")]
    public class DeleteGameBinaryRecordTTLConfigCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "DeleteGameBinaryRecordTTLConfig"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteGameBinaryRecordTTLConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.TTLConfig wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.TTLConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.DeleteGameBinaryRecordTTLConfig.Builder;





            DeleteGameBinaryRecordTTLConfig operation = opBuilder.Build(
                Key,
                Namespace
            );


            wrapper.DeleteGameBinaryRecordTTLConfig(operation);
            return String.Empty;
        }
    }
}