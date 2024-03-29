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

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social", "adminlistusersstatitems")]
    public class AdminListUsersStatItemsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "AdminListUsersStatItems"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("additionalKey")]
        public string? AdditionalKey { get; set; }

        [SdkCommandArgument("statCodes")]
        public List<string>? StatCodes { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        public AdminListUsersStatItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.AdminListUsersStatItems.Builder;

            if (AdditionalKey != null)
                opBuilder.SetAdditionalKey((string)AdditionalKey);
            if (StatCodes != null)
                opBuilder.SetStatCodes((List<string>)StatCodes);
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);




            AdminListUsersStatItems operation = opBuilder.Build(
                Namespace,
                UserId
            );


            List<AccelByte.Sdk.Api.Social.Model.ADTOObjectForUserStatItemValue>? response = wrapper.AdminListUsersStatItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}