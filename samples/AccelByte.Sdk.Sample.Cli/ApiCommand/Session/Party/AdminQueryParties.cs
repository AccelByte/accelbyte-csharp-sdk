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
    [SdkConsoleCommand("session","adminqueryparties")]
    public class AdminQueryPartiesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "AdminQueryParties"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("joinability")]
        public string? Joinability { get; set; }

        [SdkCommandArgument("key")]
        public string? Key { get; set; }

        [SdkCommandArgument("leaderID")]
        public string? LeaderID { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("memberID")]
        public string? MemberID { get; set; }

        [SdkCommandArgument("memberStatus")]
        public string? MemberStatus { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("order")]
        public string? Order { get; set; }

        [SdkCommandArgument("orderBy")]
        public string? OrderBy { get; set; }

        [SdkCommandArgument("value")]
        public string? Value { get; set; }

        public AdminQueryPartiesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.Party wrapper = new AccelByte.Sdk.Api.Session.Wrapper.Party(_SDK);

            AdminQueryParties operation = new AdminQueryParties(
                Namespace,                
                Joinability,                
                Key,                
                LeaderID,                
                Limit,                
                MemberID,                
                MemberStatus,                
                Offset,                
                Order,                
                OrderBy,                
                Value                
            );            
            
            AccelByte.Sdk.Api.Session.Model.ApimodelsPartyQueryResponse? response = wrapper.AdminQueryParties(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}