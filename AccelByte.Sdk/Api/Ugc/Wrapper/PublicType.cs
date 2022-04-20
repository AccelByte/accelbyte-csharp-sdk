// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicType
    {
        private readonly AccelByteSDK _sdk;

        public PublicType(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetType.GetTypeBuilder GetTypeOp
        {
            get { return Operation.GetType.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedGetTypeResponse? GetType(GetType input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PublicType_OperationExtensions
    {
        public static Model.ModelsPaginatedGetTypeResponse? Execute(
            this GetType.GetTypeBuilder builder,
            string namespace_
        )
        {
            GetType op = builder.Build(
                namespace_
            );

            return ((PublicType)builder.WrapperObject!).GetType(op);
        }

    }
}