// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social","getusernamespaceslots")]
    public class GetUserNamespaceSlotsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "GetUserNamespaceSlots"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public GetUserNamespaceSlotsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.Slot wrapper = new AccelByte.Sdk.Api.Social.Wrapper.Slot(_SDK);

            GetUserNamespaceSlots operation = new GetUserNamespaceSlots(
                Namespace,                
                UserId                
            );            
            
            List<AccelByte.Sdk.Api.Social.Model.SlotInfo>? response = wrapper.GetUserNamespaceSlots(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}