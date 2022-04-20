// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Policies
    {
        private readonly AccelByteSDK _sdk;

        public Policies(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrievePolicies.RetrievePoliciesBuilder RetrievePoliciesOp
        {
            get { return Operation.RetrievePolicies.Builder.SetWrapperObject(this); }
        }
        public UpdatePolicy.UpdatePolicyBuilder UpdatePolicyOp
        {
            get { return Operation.UpdatePolicy.Builder.SetWrapperObject(this); }
        }
        public SetDefaultPolicy1.SetDefaultPolicy1Builder SetDefaultPolicy1Op
        {
            get { return Operation.SetDefaultPolicy1.Builder.SetWrapperObject(this); }
        }
        public RetrieveLatestPolicies.RetrieveLatestPoliciesBuilder RetrieveLatestPoliciesOp
        {
            get { return Operation.RetrieveLatestPolicies.Builder.SetWrapperObject(this); }
        }
        public RetrieveLatestPoliciesPublic.RetrieveLatestPoliciesPublicBuilder RetrieveLatestPoliciesPublicOp
        {
            get { return Operation.RetrieveLatestPoliciesPublic.Builder.SetWrapperObject(this); }
        }
        public RetrieveLatestPoliciesByNamespaceAndCountryPublic.RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder RetrieveLatestPoliciesByNamespaceAndCountryPublicOp
        {
            get { return Operation.RetrieveLatestPoliciesByNamespaceAndCountryPublic.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.RetrievePolicyResponse>? RetrievePolicies(RetrievePolicies input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdatePolicy(UpdatePolicy input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SetDefaultPolicy1(SetDefaultPolicy1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyPublicResponse>? RetrieveLatestPolicies(RetrieveLatestPolicies input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyPublicResponse>? RetrieveLatestPoliciesPublic(RetrieveLatestPoliciesPublic input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyPublicResponse>? RetrieveLatestPoliciesByNamespaceAndCountryPublic(RetrieveLatestPoliciesByNamespaceAndCountryPublic input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}