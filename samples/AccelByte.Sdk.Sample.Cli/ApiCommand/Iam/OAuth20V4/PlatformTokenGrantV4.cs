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
    [SdkConsoleCommand("iam", "platformtokengrantv4")]
    public class PlatformTokenGrantV4Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "PlatformTokenGrantV4"; } }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("codeChallenge")]
        public string? CodeChallenge { get; set; }

        [SdkCommandArgument("codeChallengeMethod")]
        public string? CodeChallengeMethod { get; set; }

        [SdkCommandArgument("additionalData")]
        public string AdditionalData { get; set; } = String.Empty;

        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;

        [SdkCommandArgument("createHeadless")]
        public bool CreateHeadless { get; set; } = false;

        [SdkCommandArgument("device_id")]
        public string DeviceId { get; set; } = String.Empty;

        [SdkCommandArgument("macAddress")]
        public string MacAddress { get; set; } = String.Empty;

        [SdkCommandArgument("platform_token")]
        public string PlatformToken { get; set; } = String.Empty;

        [SdkCommandArgument("skipSetCookie")]
        public bool SkipSetCookie { get; set; } = false;

        public PlatformTokenGrantV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20V4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20V4(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PlatformTokenGrantV4.Builder;

            if (CodeChallenge != null)
                opBuilder.SetCodeChallenge((string)CodeChallenge);
            if (CodeChallengeMethod != null)
                opBuilder.SetCodeChallengeMethod(PlatformTokenGrantV4CodeChallengeMethod.NewValue(CodeChallengeMethod));


            if (AdditionalData != null)
                opBuilder.SetAdditionalData((string)AdditionalData);
            if (ClientId != null)
                opBuilder.SetClientId((string)ClientId);
            if (CreateHeadless != null)
                opBuilder.SetCreateHeadless((bool)CreateHeadless);
            if (DeviceId != null)
                opBuilder.SetDeviceId((string)DeviceId);
            if (MacAddress != null)
                opBuilder.SetMacAddress((string)MacAddress);
            if (PlatformToken != null)
                opBuilder.SetPlatformToken((string)PlatformToken);
            if (SkipSetCookie != null)
                opBuilder.SetSkipSetCookie((bool)SkipSetCookie);


            PlatformTokenGrantV4 operation = opBuilder.Build(
                PlatformId
            );


            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponseV3? response = wrapper.PlatformTokenGrantV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}