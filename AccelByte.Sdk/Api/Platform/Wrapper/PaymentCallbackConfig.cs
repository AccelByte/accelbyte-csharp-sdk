// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class PaymentCallbackConfig
    {
        private readonly AccelByteSDK _sdk;

        public PaymentCallbackConfig(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetPaymentCallbackConfig.GetPaymentCallbackConfigBuilder GetPaymentCallbackConfigOp
        {
            get { return Operation.GetPaymentCallbackConfig.Builder.SetWrapperObject(this); }
        }
        public UpdatePaymentCallbackConfig.UpdatePaymentCallbackConfigBuilder UpdatePaymentCallbackConfigOp
        {
            get { return Operation.UpdatePaymentCallbackConfig.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.PaymentCallbackConfigInfo? GetPaymentCallbackConfig(GetPaymentCallbackConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentCallbackConfigInfo? UpdatePaymentCallbackConfig(UpdatePaymentCallbackConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PaymentCallbackConfig_OperationExtensions
    {
        public static Model.PaymentCallbackConfigInfo? Execute(
            this GetPaymentCallbackConfig.GetPaymentCallbackConfigBuilder builder,
            string namespace_
        )
        {
            GetPaymentCallbackConfig op = builder.Build(
                namespace_
            );

            return ((PaymentCallbackConfig)builder.WrapperObject!).GetPaymentCallbackConfig(op);
        }

        public static Model.PaymentCallbackConfigInfo? Execute(
            this UpdatePaymentCallbackConfig.UpdatePaymentCallbackConfigBuilder builder,
            string namespace_
        )
        {
            UpdatePaymentCallbackConfig op = builder.Build(
                namespace_
            );

            return ((PaymentCallbackConfig)builder.WrapperObject!).UpdatePaymentCallbackConfig(op);
        }

    }
}