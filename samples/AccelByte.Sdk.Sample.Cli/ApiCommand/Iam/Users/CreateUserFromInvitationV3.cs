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
    [SdkConsoleCommand("iam","createuserfrominvitationv3")]
    public class CreateUserFromInvitationV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "CreateUserFromInvitationV3"; } }

        [SdkCommandArgument("invitationId")]
        public string InvitationId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelUserCreateFromInvitationRequestV3 Body { get; set; } = new ModelUserCreateFromInvitationRequestV3();
                
        public CreateUserFromInvitationV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            CreateUserFromInvitationV3 operation = new CreateUserFromInvitationV3(
                InvitationId,                
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelUserCreateResponseV3? response = wrapper.CreateUserFromInvitationV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}