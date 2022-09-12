// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam", "requestgametokencoderesponsev3")]
    public class RequestGameTokenCodeResponseV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "RequestGameTokenCodeResponseV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;

        public RequestGameTokenCodeResponseV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension(_SDK);

            RequestGameTokenCodeResponseV3 operation = new RequestGameTokenCodeResponseV3(
                Namespace,
                ClientId
            );

            AccelByte.Sdk.Api.Iam.Model.OauthmodelGameTokenCodeResponse? response = wrapper.RequestGameTokenCodeResponseV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}