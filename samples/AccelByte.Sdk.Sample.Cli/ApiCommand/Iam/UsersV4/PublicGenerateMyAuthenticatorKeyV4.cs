// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("iam","publicgeneratemyauthenticatorkeyv4")]
    public class PublicGenerateMyAuthenticatorKeyV4Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicGenerateMyAuthenticatorKeyV4"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public PublicGenerateMyAuthenticatorKeyV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

            PublicGenerateMyAuthenticatorKeyV4 operation = new PublicGenerateMyAuthenticatorKeyV4(
                Namespace                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelAuthenticatorKeyResponseV4? response = wrapper.PublicGenerateMyAuthenticatorKeyV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}