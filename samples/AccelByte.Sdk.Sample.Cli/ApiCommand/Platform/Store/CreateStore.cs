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

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform", "createstore")]
    public class CreateStoreCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "CreateStore"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public StoreCreate Body { get; set; } = new StoreCreate();

        public CreateStoreCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Store wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Store(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.CreateStore.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.StoreCreate)Body);



            CreateStore operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.StoreInfo? response = wrapper.CreateStore(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}