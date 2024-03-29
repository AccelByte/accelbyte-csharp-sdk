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

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr", "publicgetuserpersonaldatarequests")]
    public class PublicGetUserPersonalDataRequestsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Gdpr"; } }

        public string OperationName { get { return "PublicGetUserPersonalDataRequests"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public PublicGetUserPersonalDataRequestsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.PublicGetUserPersonalDataRequests.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);




            PublicGetUserPersonalDataRequests operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Gdpr.Model.ModelsUserPersonalDataResponse? response = wrapper.PublicGetUserPersonalDataRequests(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}