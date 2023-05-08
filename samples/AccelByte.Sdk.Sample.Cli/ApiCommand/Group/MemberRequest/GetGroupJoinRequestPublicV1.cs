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

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Group
{
    [SdkConsoleCommand("group", "getgroupjoinrequestpublicv1")]
    public class GetGroupJoinRequestPublicV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Group"; } }

        public string OperationName { get { return "GetGroupJoinRequestPublicV1"; } }

        [SdkCommandArgument("groupId")]
        public string GroupId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetGroupJoinRequestPublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.MemberRequest wrapper = new AccelByte.Sdk.Api.Group.Wrapper.MemberRequest(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Group.Operation.GetGroupJoinRequestPublicV1.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);




            GetGroupJoinRequestPublicV1 operation = opBuilder.Build(
                GroupId,
                Namespace
            );


            AccelByte.Sdk.Api.Group.Model.ModelsGetMemberRequestsListResponseV1? response = wrapper.GetGroupJoinRequestPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}