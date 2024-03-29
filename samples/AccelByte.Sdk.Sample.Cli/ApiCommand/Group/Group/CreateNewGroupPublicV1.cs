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
    [SdkConsoleCommand("group", "createnewgrouppublicv1")]
    public class CreateNewGroupPublicV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Group"; } }

        public string OperationName { get { return "CreateNewGroupPublicV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsPublicCreateNewGroupRequestV1 Body { get; set; } = new ModelsPublicCreateNewGroupRequestV1();

        public CreateNewGroupPublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Group wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Group(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Group.Operation.CreateNewGroupPublicV1.Builder;





            CreateNewGroupPublicV1 operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Group.Model.ModelsGroupResponseV1? response = wrapper.CreateNewGroupPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}