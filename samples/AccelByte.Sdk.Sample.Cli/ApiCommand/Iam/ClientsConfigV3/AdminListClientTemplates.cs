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
    [SdkConsoleCommand("iam", "adminlistclienttemplates")]
    public class AdminListClientTemplatesCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminListClientTemplates"; } }

        public AdminListClientTemplatesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.ClientsConfigV3 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.ClientsConfigV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminListClientTemplates.Builder;





            AdminListClientTemplates operation = opBuilder.Build(
            );


            AccelByte.Sdk.Api.Iam.Model.ClientmodelListTemplatesResponse? response = wrapper.AdminListClientTemplates(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}