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
    [SdkConsoleCommand("cloudsave","putgamerecordconcurrenthandlerv1")]
    public class PutGameRecordConcurrentHandlerV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "PutGameRecordConcurrentHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsConcurrentRecordRequest Body { get; set; } = new ModelsConcurrentRecordRequest();
                
        public PutGameRecordConcurrentHandlerV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.ConcurrentRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.ConcurrentRecord(_SDK);

            PutGameRecordConcurrentHandlerV1 operation = new PutGameRecordConcurrentHandlerV1(
                Key,                
                Namespace,                
                Body                
            );            
            
            wrapper.PutGameRecordConcurrentHandlerV1(operation);
            return String.Empty;
        }
    }
}