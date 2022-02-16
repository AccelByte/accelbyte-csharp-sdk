// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Cloudsave
{
    [SdkConsoleCommand("cloudsave","admingetplayerpublicrecordhandlerv1")]
    public class AdminGetPlayerPublicRecordHandlerV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "AdminGetPlayerPublicRecordHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AdminGetPlayerPublicRecordHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminPlayerRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminPlayerRecord(_SDK);

            AdminGetPlayerPublicRecordHandlerV1 operation = new AdminGetPlayerPublicRecordHandlerV1(
                Key,                
                Namespace,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Cloudsave.Model.ModelsPlayerRecord? response = wrapper.AdminGetPlayerPublicRecordHandlerV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}