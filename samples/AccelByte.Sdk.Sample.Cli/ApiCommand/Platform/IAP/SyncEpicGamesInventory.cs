// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","syncepicgamesinventory")]
    public class SyncEpicGamesInventoryCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "SyncEpicGamesInventory"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public EpicGamesReconcileRequest Body { get; set; } = new EpicGamesReconcileRequest();
                
        public SyncEpicGamesInventoryCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAP wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAP(_SDK);

            SyncEpicGamesInventory operation = new SyncEpicGamesInventory(
                Namespace,                
                UserId,                
                Body                
            );            
            
            List<AccelByte.Sdk.Api.Platform.Model.EpicGamesReconcileResult>? response = wrapper.SyncEpicGamesInventory(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}