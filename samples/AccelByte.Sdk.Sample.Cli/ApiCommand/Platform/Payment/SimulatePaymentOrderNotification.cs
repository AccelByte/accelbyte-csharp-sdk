// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","simulatepaymentordernotification")]
    public class SimulatePaymentOrderNotificationCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "SimulatePaymentOrderNotification"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("paymentOrderNo")]
        public string PaymentOrderNo { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public PaymentOrderNotifySimulation Body { get; set; } = new PaymentOrderNotifySimulation();
                
        public SimulatePaymentOrderNotificationCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Payment wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Payment(_SDK);

            SimulatePaymentOrderNotification operation = new SimulatePaymentOrderNotification(
                Namespace,                
                PaymentOrderNo,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.NotificationProcessResult? response = wrapper.SimulatePaymentOrderNotification(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}