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

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session", "adminquerygamesessions")]
    public class AdminQueryGameSessionsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Session"; } }

        public string OperationName { get { return "AdminQueryGameSessions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("configurationName")]
        public string? ConfigurationName { get; set; }

        [SdkCommandArgument("dsPodName")]
        public string? DsPodName { get; set; }

        [SdkCommandArgument("fromTime")]
        public string? FromTime { get; set; }

        [SdkCommandArgument("gameMode")]
        public string? GameMode { get; set; }

        [SdkCommandArgument("isPersistent")]
        public string? IsPersistent { get; set; }

        [SdkCommandArgument("isSoftDeleted")]
        public string? IsSoftDeleted { get; set; }

        [SdkCommandArgument("joinability")]
        public string? Joinability { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("matchPool")]
        public string? MatchPool { get; set; }

        [SdkCommandArgument("memberID")]
        public string? MemberID { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("order")]
        public string? Order { get; set; }

        [SdkCommandArgument("orderBy")]
        public string? OrderBy { get; set; }

        [SdkCommandArgument("sessionID")]
        public string? SessionID { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("statusV2")]
        public string? StatusV2 { get; set; }

        [SdkCommandArgument("toTime")]
        public string? ToTime { get; set; }

        public AdminQueryGameSessionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.GameSession wrapper = new AccelByte.Sdk.Api.Session.Wrapper.GameSession(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminQueryGameSessions.Builder;

            if (ConfigurationName != null)
                opBuilder.SetConfigurationName((string)ConfigurationName);
            if (DsPodName != null)
                opBuilder.SetDsPodName((string)DsPodName);
            if (FromTime != null)
                opBuilder.SetFromTime((string)FromTime);
            if (GameMode != null)
                opBuilder.SetGameMode((string)GameMode);
            if (IsPersistent != null)
                opBuilder.SetIsPersistent((string)IsPersistent);
            if (IsSoftDeleted != null)
                opBuilder.SetIsSoftDeleted((string)IsSoftDeleted);
            if (Joinability != null)
                opBuilder.SetJoinability(AdminQueryGameSessionsJoinability.NewValue(Joinability));
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (MatchPool != null)
                opBuilder.SetMatchPool((string)MatchPool);
            if (MemberID != null)
                opBuilder.SetMemberID((string)MemberID);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Order != null)
                opBuilder.SetOrder((string)Order);
            if (OrderBy != null)
                opBuilder.SetOrderBy((string)OrderBy);
            if (SessionID != null)
                opBuilder.SetSessionID((string)SessionID);
            if (Status != null)
                opBuilder.SetStatus(AdminQueryGameSessionsStatus.NewValue(Status));
            if (StatusV2 != null)
                opBuilder.SetStatusV2(AdminQueryGameSessionsStatusV2.NewValue(StatusV2));
            if (ToTime != null)
                opBuilder.SetToTime((string)ToTime);




            AdminQueryGameSessions operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Session.Model.ApimodelsGameSessionQueryResponse? response = wrapper.AdminQueryGameSessions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}