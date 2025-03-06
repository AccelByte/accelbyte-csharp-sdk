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
    [SdkConsoleCommand("iam", "admincreatetagv3")]
    public class AdminCreateTagV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminCreateTagV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelTagCreateRequestV3 Body { get; set; } = new ModelTagCreateRequestV3();

        public AdminCreateTagV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.AccountIdenfifierTag wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.AccountIdenfifierTag(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminCreateTagV3.Builder;





            AdminCreateTagV3 operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Iam.Model.AccountcommonTagResponse? response = wrapper.AdminCreateTagV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}