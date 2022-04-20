// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Utility
    {
        private readonly AccelByteSDK _sdk;

        public Utility(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CheckReadiness.CheckReadinessBuilder CheckReadinessOp
        {
            get { return Operation.CheckReadiness.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.LegalReadinessStatusResponse? CheckReadiness(CheckReadiness input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Utility_OperationExtensions
    {
        public static Model.LegalReadinessStatusResponse? Execute(
            this CheckReadiness.CheckReadinessBuilder builder
        )
        {
            CheckReadiness op = builder.Build(
            );

            return ((Utility)builder.WrapperObject!).CheckReadiness(op);
        }

    }
}