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

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser", "userquerysession")]
    public class UserQuerySessionCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Sessionbrowser"; } }

        public string OperationName { get { return "UserQuerySession"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("gameMode")]
        public string? GameMode { get; set; }

        [SdkCommandArgument("gameVersion")]
        public string? GameVersion { get; set; }

        [SdkCommandArgument("joinable")]
        public string? Joinable { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("matchExist")]
        public string? MatchExist { get; set; }

        [SdkCommandArgument("matchId")]
        public string? MatchId { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("serverStatus")]
        public string? ServerStatus { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        [SdkCommandArgument("sessionType")]
        public string SessionType { get; set; } = String.Empty;

        public UserQuerySessionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Sessionbrowser.Operation.UserQuerySession.Builder;

            if (GameMode != null)
                opBuilder.SetGameMode((string)GameMode);
            if (GameVersion != null)
                opBuilder.SetGameVersion((string)GameVersion);
            if (Joinable != null)
                opBuilder.SetJoinable((string)Joinable);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (MatchExist != null)
                opBuilder.SetMatchExist((string)MatchExist);
            if (MatchId != null)
                opBuilder.SetMatchId((string)MatchId);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (ServerStatus != null)
                opBuilder.SetServerStatus((string)ServerStatus);
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            UserQuerySession operation = opBuilder.Build(
                Namespace,
                SessionType
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsSessionQueryResponse? response = wrapper.UserQuerySession(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}