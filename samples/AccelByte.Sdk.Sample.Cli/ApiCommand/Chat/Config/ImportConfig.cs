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

using AccelByte.Sdk.Api.Chat.Wrapper;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Chat
{
    [SdkConsoleCommand("chat","importconfig")]
    public class ImportConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Chat"; } }

        public string OperationName{ get { return "ImportConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandFile("file")]
        public Stream? File { get; set; }
                    
        public ImportConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.ImportConfig.Builder;



            if (File != null)
                opBuilder.SetFile((Stream)File);


            ImportConfig operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Chat.Model.ModelsImportConfigResponse? response = wrapper.ImportConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}