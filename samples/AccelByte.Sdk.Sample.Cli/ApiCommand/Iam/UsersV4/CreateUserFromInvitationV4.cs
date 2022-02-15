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
    [SdkConsoleCommand("iam","createuserfrominvitationv4")]
    public class CreateUserFromInvitationV4Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "CreateUserFromInvitationV4"; } }

        [SdkCommandArgument("invitationId")]
        public string InvitationId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelUserCreateFromInvitationRequestV4 Body { get; set; } = new ModelUserCreateFromInvitationRequestV4();
                
        public CreateUserFromInvitationV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

            CreateUserFromInvitationV4 operation = new CreateUserFromInvitationV4(
                InvitationId,                
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.AccountCreateUserResponseV4? response = wrapper.CreateUserFromInvitationV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}