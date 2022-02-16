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
    [SdkConsoleCommand("seasonpass","createtier")]
    public class CreateTierCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "CreateTier"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("seasonId")]
        public string SeasonId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public TierCreate Body { get; set; } = new TierCreate();
                
        public CreateTierCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Tier wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Tier(_SDK);

            CreateTier operation = new CreateTier(
                Namespace,                
                SeasonId,                
                Body                
            );            
            
            List<AccelByte.Sdk.Api.Seasonpass.Model.Tier>? response = wrapper.CreateTier(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}