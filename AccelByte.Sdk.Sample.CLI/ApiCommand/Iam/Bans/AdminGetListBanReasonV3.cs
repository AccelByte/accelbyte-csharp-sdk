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
    [SdkConsoleCommand("iam","admingetlistbanreasonv3")]
    public class AdminGetListBanReasonV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminGetListBanReasonV3"; } }

        public AdminGetListBanReasonV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Bans wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Bans(_SDK);

            AdminGetListBanReasonV3 operation = new AdminGetListBanReasonV3(
            );            

            AccelByte.Sdk.Api.Iam.Model.AccountcommonBanReasonsV3? response = wrapper.AdminGetListBanReasonV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}