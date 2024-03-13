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
    [SdkConsoleCommand("iam", "listadminsv3")]
    public class ListAdminsV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "ListAdminsV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("after")]
        public string? After { get; set; }

        [SdkCommandArgument("before")]
        public string? Before { get; set; }

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("query")]
        public string? Query { get; set; }

        [SdkCommandArgument("roleId")]
        public string? RoleId { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        public ListAdminsV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.ListAdminsV3.Builder;

            if (After != null)
                opBuilder.SetAfter((string)After);
            if (Before != null)
                opBuilder.SetBefore((string)Before);
            if (EndDate != null)
                opBuilder.SetEndDate((string)EndDate);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Query != null)
                opBuilder.SetQuery((string)Query);
            if (RoleId != null)
                opBuilder.SetRoleId((string)RoleId);
            if (StartDate != null)
                opBuilder.SetStartDate((string)StartDate);




            ListAdminsV3 operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Iam.Model.ModelGetUsersResponseWithPaginationV3? response = wrapper.ListAdminsV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}