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
    [SdkConsoleCommand("chat", "adminprofanityimport")]
    public class AdminProfanityImportCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Chat"; } }

        public string OperationName { get { return "AdminProfanityImport"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("action")]
        public string? Action { get; set; }

        [SdkCommandArgument("showResult")]
        public bool? ShowResult { get; set; }

        [SdkCommandFile("file")]
        public Stream File { get; set; } = new MemoryStream();

        public AdminProfanityImportCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Profanity wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Profanity(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminProfanityImport.Builder;

            if (Action != null)
                opBuilder.SetAction(AdminProfanityImportAction.NewValue(Action));
            if (ShowResult != null)
                opBuilder.SetShowResult((bool)ShowResult);




            AdminProfanityImport operation = opBuilder.Build(
                File,
                Namespace
            );


            AccelByte.Sdk.Api.Chat.Model.ModelsDictionaryImportResult? response = wrapper.AdminProfanityImport(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}