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

using AccelByte.Sdk.Api.Csm.Wrapper;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Csm
{
    [SdkConsoleCommand("csm","updateappresourcesresourcelimitformv2")]
    public class UpdateAppResourcesResourceLimitFormV2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Csm"; } }

        public string OperationName{ get { return "UpdateAppResourcesResourceLimitFormV2"; } }

        [SdkCommandArgument("app")]
        public string App { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelIncreaseLimitFormRequest Body { get; set; } = new ApimodelIncreaseLimitFormRequest();
                
        public UpdateAppResourcesResourceLimitFormV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.AppV2 wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.AppV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.UpdateAppResourcesResourceLimitFormV2.Builder;





            UpdateAppResourcesResourceLimitFormV2 operation = opBuilder.Build(
                Body,
                App,
                Namespace
            );

            
            wrapper.UpdateAppResourcesResourceLimitFormV2(operation);
            return String.Empty;
        }
    }
}