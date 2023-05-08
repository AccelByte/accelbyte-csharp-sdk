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

using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Reporting
{
    [SdkConsoleCommand("reporting", "updateticketresolutions")]
    public class UpdateTicketResolutionsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Reporting"; } }

        public string OperationName { get { return "UpdateTicketResolutions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("ticketId")]
        public string TicketId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public RestapiUpdateTicketResolutionsRequest Body { get; set; } = new RestapiUpdateTicketResolutionsRequest();

        public UpdateTicketResolutionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.AdminTickets wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.AdminTickets(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.UpdateTicketResolutions.Builder;





            UpdateTicketResolutions operation = opBuilder.Build(
                Body,
                Namespace,
                TicketId
            );


            AccelByte.Sdk.Api.Reporting.Model.RestapiTicketResponse? response = wrapper.UpdateTicketResolutions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}