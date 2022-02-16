// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Achievement
{
    [SdkConsoleCommand("achievement","importachievements")]
    public class ImportAchievementsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Achievement"; } }

        public string OperationName{ get { return "ImportAchievements"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandFile("file")]
        public Stream? File { get; set; }
                    
        [SdkCommandArgument("strategy")]
        public string Strategy { get; set; } = String.Empty;
                    
        public ImportAchievementsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.Achievements wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.Achievements(_SDK);

            ImportAchievements operation = new ImportAchievements(
                Namespace,                
                File,                
                Strategy                
            );            
            
            AccelByte.Sdk.Api.Achievement.Model.ServiceImportConfigResponse? response = wrapper.ImportAchievements(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}