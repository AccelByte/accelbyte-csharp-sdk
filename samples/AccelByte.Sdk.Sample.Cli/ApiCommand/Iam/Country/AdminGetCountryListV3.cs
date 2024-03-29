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
    [SdkConsoleCommand("iam", "admingetcountrylistv3")]
    public class AdminGetCountryListV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminGetCountryListV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("filterBlacklist")]
        public bool? FilterBlacklist { get; set; }

        public AdminGetCountryListV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Country wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Country(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetCountryListV3.Builder;

            if (FilterBlacklist != null)
                opBuilder.SetFilterBlacklist((bool)FilterBlacklist);




            AdminGetCountryListV3 operation = opBuilder.Build(
                Namespace
            );


            List<AccelByte.Sdk.Api.Iam.Model.ModelCountryResponse>? response = wrapper.AdminGetCountryListV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}