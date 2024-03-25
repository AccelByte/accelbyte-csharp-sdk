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

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam", "adminsearchuserv3")]
    public class AdminSearchUserV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminSearchUserV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("by")]
        public string? By { get; set; }

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("includeTotal")]
        public bool? IncludeTotal { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("platformBy")]
        public string? PlatformBy { get; set; }

        [SdkCommandArgument("platformId")]
        public string? PlatformId { get; set; }

        [SdkCommandArgument("query")]
        public string? Query { get; set; }

        [SdkCommandArgument("roleIds")]
        public string? RoleIds { get; set; }

        [SdkCommandArgument("skipLoginQueue")]
        public bool? SkipLoginQueue { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("testAccount")]
        public bool? TestAccount { get; set; }

        public AdminSearchUserV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminSearchUserV3.Builder;

            if (By != null)
                opBuilder.SetBy((string)By);
            if (EndDate != null)
                opBuilder.SetEndDate((string)EndDate);
            if (IncludeTotal != null)
                opBuilder.SetIncludeTotal((bool)IncludeTotal);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (PlatformBy != null)
                opBuilder.SetPlatformBy((string)PlatformBy);
            if (PlatformId != null)
                opBuilder.SetPlatformId((string)PlatformId);
            if (Query != null)
                opBuilder.SetQuery((string)Query);
            if (RoleIds != null)
                opBuilder.SetRoleIds((string)RoleIds);
            if (SkipLoginQueue != null)
                opBuilder.SetSkipLoginQueue((bool)SkipLoginQueue);
            if (StartDate != null)
                opBuilder.SetStartDate((string)StartDate);
            if (TestAccount != null)
                opBuilder.SetTestAccount((bool)TestAccount);




            AdminSearchUserV3 operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Iam.Model.ModelSearchUsersResponseWithPaginationV3? response = wrapper.AdminSearchUserV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}