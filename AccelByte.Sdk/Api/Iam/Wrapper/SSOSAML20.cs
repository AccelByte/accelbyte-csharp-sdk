// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class SSOSAML20
    {
        private readonly AccelByteSDK _sdk;

        public SSOSAML20(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PlatformAuthenticateSAMLV3Handler.PlatformAuthenticateSAMLV3HandlerBuilder PlatformAuthenticateSAMLV3HandlerOp
        {
            get { return Operation.PlatformAuthenticateSAMLV3Handler.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public string PlatformAuthenticateSAMLV3Handler(PlatformAuthenticateSAMLV3Handler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class SSOSAML20_OperationExtensions
    {
        public static string Execute(
            this PlatformAuthenticateSAMLV3Handler.PlatformAuthenticateSAMLV3HandlerBuilder builder,
            string platformId,
            string state
        )
        {
            PlatformAuthenticateSAMLV3Handler op = builder.Build(
                platformId,
                state
            );

            return ((SSOSAML20)builder.WrapperObject!).PlatformAuthenticateSAMLV3Handler(op);
        }

    }
}