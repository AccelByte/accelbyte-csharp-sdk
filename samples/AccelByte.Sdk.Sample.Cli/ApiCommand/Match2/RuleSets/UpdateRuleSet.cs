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

using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Match2
{
    [SdkConsoleCommand("match2","updateruleset")]
    public class UpdateRuleSetCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Match2"; } }

        public string OperationName{ get { return "UpdateRuleSet"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("ruleset")]
        public string Ruleset { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApiMatchRuleSetData Body { get; set; } = new ApiMatchRuleSetData();
                
        public UpdateRuleSetCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.RuleSets wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.RuleSets(_SDK);

            UpdateRuleSet operation = new UpdateRuleSet(
                Namespace,                
                Ruleset,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Match2.Model.ApiMatchRuleSet? response = wrapper.UpdateRuleSet(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}