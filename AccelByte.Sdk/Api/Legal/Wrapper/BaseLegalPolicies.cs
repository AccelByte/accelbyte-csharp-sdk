// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class BaseLegalPolicies
    {
        private readonly AccelByteSDK _sdk;

        public BaseLegalPolicies(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveAllLegalPolicies.RetrieveAllLegalPoliciesBuilder RetrieveAllLegalPoliciesOp
        {
            get { return Operation.RetrieveAllLegalPolicies.Builder.SetWrapperObject(this); }
        }
        public CreatePolicy.CreatePolicyBuilder CreatePolicyOp
        {
            get { return Operation.CreatePolicy.Builder.SetWrapperObject(this); }
        }
        public RetrieveSinglePolicy.RetrieveSinglePolicyBuilder RetrieveSinglePolicyOp
        {
            get { return Operation.RetrieveSinglePolicy.Builder.SetWrapperObject(this); }
        }
        public PartialUpdatePolicy.PartialUpdatePolicyBuilder PartialUpdatePolicyOp
        {
            get { return Operation.PartialUpdatePolicy.Builder.SetWrapperObject(this); }
        }
        public RetrievePolicyCountry.RetrievePolicyCountryBuilder RetrievePolicyCountryOp
        {
            get { return Operation.RetrievePolicyCountry.Builder.SetWrapperObject(this); }
        }
        public RetrieveAllPolicyTypes.RetrieveAllPolicyTypesBuilder RetrieveAllPolicyTypesOp
        {
            get { return Operation.RetrieveAllPolicyTypes.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.RetrieveBasePolicyResponse>? RetrieveAllLegalPolicies(RetrieveAllLegalPolicies input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreateBasePolicyResponse? CreatePolicy(CreatePolicy input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveBasePolicyResponse? RetrieveSinglePolicy(RetrieveSinglePolicy input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UpdateBasePolicyResponse? PartialUpdatePolicy(PartialUpdatePolicy input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrievePolicyResponse? RetrievePolicyCountry(RetrievePolicyCountry input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyTypeResponse>? RetrieveAllPolicyTypes(RetrieveAllPolicyTypes input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}