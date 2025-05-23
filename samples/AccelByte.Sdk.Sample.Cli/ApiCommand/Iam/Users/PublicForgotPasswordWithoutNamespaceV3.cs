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
    [SdkConsoleCommand("iam", "publicforgotpasswordwithoutnamespacev3")]
    public class PublicForgotPasswordWithoutNamespaceV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "PublicForgotPasswordWithoutNamespaceV3"; } }

        [SdkCommandData("body")]
        public ModelForgotPasswordWithoutNamespaceRequestV3 Body { get; set; } = new ModelForgotPasswordWithoutNamespaceRequestV3();

        public PublicForgotPasswordWithoutNamespaceV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PublicForgotPasswordWithoutNamespaceV3.Builder;





            PublicForgotPasswordWithoutNamespaceV3 operation = opBuilder.Build(
                Body
            );


            AccelByte.Sdk.Api.Iam.Model.ModelForgotPasswordResponseV3? response = wrapper.PublicForgotPasswordWithoutNamespaceV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}