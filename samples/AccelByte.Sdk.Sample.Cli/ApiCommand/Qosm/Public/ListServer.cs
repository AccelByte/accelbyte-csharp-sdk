// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Qosm.Wrapper;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Qosm
{
    [SdkConsoleCommand("qosm","listserver")]
    public class ListServerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Qosm"; } }

        public string OperationName{ get { return "ListServer"; } }

        public ListServerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Qosm.Wrapper.Public wrapper = new AccelByte.Sdk.Api.Qosm.Wrapper.Public(_SDK);

            ListServer operation = new ListServer(
            );            
            
            AccelByte.Sdk.Api.Qosm.Model.ModelsListServerResponse? response = wrapper.ListServer(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}