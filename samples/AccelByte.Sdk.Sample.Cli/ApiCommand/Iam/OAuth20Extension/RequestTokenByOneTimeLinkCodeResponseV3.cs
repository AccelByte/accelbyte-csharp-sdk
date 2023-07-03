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
    [SdkConsoleCommand("iam", "requesttokenbyonetimelinkcoderesponsev3")]
    public class RequestTokenByOneTimeLinkCodeResponseV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "RequestTokenByOneTimeLinkCodeResponseV3"; } }

        [SdkCommandArgument("additionalData")]
        public string AdditionalData { get; set; } = String.Empty;

        [SdkCommandArgument("isTransient")]
        public bool IsTransient { get; set; } = false;

        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;

        [SdkCommandArgument("oneTimeLinkCode")]
        public string OneTimeLinkCode { get; set; } = String.Empty;

        public RequestTokenByOneTimeLinkCodeResponseV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.RequestTokenByOneTimeLinkCodeResponseV3.Builder;



            if (AdditionalData != null)
                opBuilder.SetAdditionalData((string)AdditionalData);
            if (IsTransient != null)
                opBuilder.SetIsTransient((bool)IsTransient);


            RequestTokenByOneTimeLinkCodeResponseV3 operation = opBuilder.Build(
                ClientId,
                OneTimeLinkCode
            );


            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponseV3? response = wrapper.RequestTokenByOneTimeLinkCodeResponseV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}