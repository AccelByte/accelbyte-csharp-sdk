// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class AdminUserEligibilities
    {
        private readonly AccelByteSDK _sdk;

        public AdminUserEligibilities(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminRetrieveEligibilities.AdminRetrieveEligibilitiesBuilder AdminRetrieveEligibilitiesOp
        {
            get { return Operation.AdminRetrieveEligibilities.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.RetrieveUserEligibilitiesIndirectResponse? AdminRetrieveEligibilities(AdminRetrieveEligibilities input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class AdminUserEligibilities_OperationExtensions
    {
        public static Model.RetrieveUserEligibilitiesIndirectResponse? Execute(
            this AdminRetrieveEligibilities.AdminRetrieveEligibilitiesBuilder builder,
            string namespace_,
            string userId,
            string clientId,
            string countryCode
        )
        {
            AdminRetrieveEligibilities op = builder.Build(
                namespace_,
                userId,
                clientId,
                countryCode
            );

            return ((AdminUserEligibilities)builder.WrapperObject!).AdminRetrieveEligibilities(op);
        }

    }
}