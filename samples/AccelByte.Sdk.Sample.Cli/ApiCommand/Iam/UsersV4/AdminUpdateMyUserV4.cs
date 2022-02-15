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
    [SdkConsoleCommand("iam","adminupdatemyuserv4")]
    public class AdminUpdateMyUserV4Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminUpdateMyUserV4"; } }

        [SdkCommandData("body")]
        public ModelUserUpdateRequestV3 Body { get; set; } = new ModelUserUpdateRequestV3();
                
        public AdminUpdateMyUserV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

            AdminUpdateMyUserV4 operation = new AdminUpdateMyUserV4(
                Body                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelUserResponseV3? response = wrapper.AdminUpdateMyUserV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}