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
    [SdkConsoleCommand("csm","getappimagelistv2")]
    public class GetAppImageListV2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Csm"; } }

        public string OperationName{ get { return "GetAppImageListV2"; } }

        [SdkCommandArgument("app")]
        public string App { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("cached")]
        public string? Cached { get; set; }

        public GetAppImageListV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.ImageV2 wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.ImageV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.GetAppImageListV2.Builder;

            if (Cached != null)
                opBuilder.SetCached((string)Cached);




            GetAppImageListV2 operation = opBuilder.Build(
                App,
                Namespace
            );

            
            AccelByte.Sdk.Api.Csm.Model.ApimodelGetAppImageListV2Response? response = wrapper.GetAppImageListV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}