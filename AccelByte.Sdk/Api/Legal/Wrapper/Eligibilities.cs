// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Eligibilities
    {
        private readonly AccelByteSDK _sdk;

        public Eligibilities(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveEligibilitiesPublic.RetrieveEligibilitiesPublicBuilder RetrieveEligibilitiesPublicOp
        {
            get { return Operation.RetrieveEligibilitiesPublic.Builder.SetWrapperObject(this); }
        }
        public RetrieveEligibilitiesPublicIndirect.RetrieveEligibilitiesPublicIndirectBuilder RetrieveEligibilitiesPublicIndirectOp
        {
            get { return Operation.RetrieveEligibilitiesPublicIndirect.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.RetrieveUserEligibilitiesResponse>? RetrieveEligibilitiesPublic(RetrieveEligibilitiesPublic input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveUserEligibilitiesIndirectResponse? RetrieveEligibilitiesPublicIndirect(RetrieveEligibilitiesPublicIndirect input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Eligibilities_OperationExtensions
    {
        public static List<Model.RetrieveUserEligibilitiesResponse>? Execute(
            this RetrieveEligibilitiesPublic.RetrieveEligibilitiesPublicBuilder builder,
            string namespace_
        )
        {
            RetrieveEligibilitiesPublic op = builder.Build(
                namespace_
            );

            return ((Eligibilities)builder.WrapperObject!).RetrieveEligibilitiesPublic(op);
        }

        public static Model.RetrieveUserEligibilitiesIndirectResponse? Execute(
            this RetrieveEligibilitiesPublicIndirect.RetrieveEligibilitiesPublicIndirectBuilder builder,
            string clientId,
            string countryCode,
            string namespace_,
            string userId
        )
        {
            RetrieveEligibilitiesPublicIndirect op = builder.Build(
                clientId,
                countryCode,
                namespace_,
                userId
            );

            return ((Eligibilities)builder.WrapperObject!).RetrieveEligibilitiesPublicIndirect(op);
        }

    }
}