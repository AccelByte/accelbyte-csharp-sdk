// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Leaderboard
{
    [SdkConsoleCommand("leaderboard","setuservisibilitystatusv2")]
    public class SetUserVisibilityStatusV2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "SetUserVisibilityStatusV2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsSetUserVisibilityRequest Body { get; set; } = new ModelsSetUserVisibilityRequest();
                
        public SetUserVisibilityStatusV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.UserVisibility wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.UserVisibility(_SDK);

            SetUserVisibilityStatusV2 operation = new SetUserVisibilityStatusV2(
                Namespace,                
                UserId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetUserVisibilityResponse? response = wrapper.SetUserVisibilityStatusV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}