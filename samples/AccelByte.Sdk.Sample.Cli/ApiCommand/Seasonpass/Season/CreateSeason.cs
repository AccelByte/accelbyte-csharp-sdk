// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass","createseason")]
    public class CreateSeasonCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "CreateSeason"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SeasonCreate Body { get; set; } = new SeasonCreate();
                
        public CreateSeasonCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Season wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Season(_SDK);

            CreateSeason operation = new CreateSeason(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Seasonpass.Model.SeasonInfo? response = wrapper.CreateSeason(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}