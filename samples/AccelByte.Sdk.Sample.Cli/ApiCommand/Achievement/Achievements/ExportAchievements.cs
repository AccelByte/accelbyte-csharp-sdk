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

using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Achievement
{
    [SdkConsoleCommand("achievement", "exportachievements")]
    public class ExportAchievementsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Achievement"; } }

        public string OperationName { get { return "ExportAchievements"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        public ExportAchievementsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.Achievements wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.Achievements(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Achievement.Operation.ExportAchievements.Builder;

            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);




            ExportAchievements operation = opBuilder.Build(
                Namespace
            );


            Stream? response = wrapper.ExportAchievements(operation);
            if (response == null)
                return "No response from server.";

            return Helper.ConvertInputStreamToString(response);
        }
    }
}