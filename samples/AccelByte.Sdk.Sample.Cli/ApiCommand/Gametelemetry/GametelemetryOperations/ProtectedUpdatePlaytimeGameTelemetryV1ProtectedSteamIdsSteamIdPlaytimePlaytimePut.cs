// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gametelemetry.Wrapper;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gametelemetry
{
    [SdkConsoleCommand("gametelemetry","protectedupdateplaytimegametelemetryv1protectedsteamidssteamidplaytimeplaytimeput")]
    public class ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePutCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gametelemetry"; } }

        public string OperationName{ get { return "ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut"; } }

        [SdkCommandArgument("playtime")]
        public string Playtime { get; set; } = String.Empty;

        [SdkCommandArgument("steamId")]
        public string SteamId { get; set; } = String.Empty;

        public ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePutCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations wrapper = new AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations(_SDK);

            ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut operation = new ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut(
                Playtime,                
                SteamId                
            );            
            
            wrapper.ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut(operation);
            return String.Empty;
        }
    }
}