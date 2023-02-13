// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Match2.Wrapper
{
    public class Backfill
    {
        private readonly AccelByteSDK _sdk;

        public Backfill(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreateBackfill.CreateBackfillBuilder CreateBackfillOp
        {
            get { return Operation.CreateBackfill.Builder.SetWrapperObject(this); }
        }
        public GetBackfillProposal.GetBackfillProposalBuilder GetBackfillProposalOp
        {
            get { return Operation.GetBackfillProposal.Builder.SetWrapperObject(this); }
        }
        public GetBackfill.GetBackfillBuilder GetBackfillOp
        {
            get { return Operation.GetBackfill.Builder.SetWrapperObject(this); }
        }
        public DeleteBackfill.DeleteBackfillBuilder DeleteBackfillOp
        {
            get { return Operation.DeleteBackfill.Builder.SetWrapperObject(this); }
        }
        public AcceptBackfill.AcceptBackfillBuilder AcceptBackfillOp
        {
            get { return Operation.AcceptBackfill.Builder.SetWrapperObject(this); }
        }
        public RejectBackfill.RejectBackfillBuilder RejectBackfillOp
        {
            get { return Operation.RejectBackfill.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void CreateBackfill(CreateBackfill input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiBackfillProposalResponse? GetBackfillProposal(GetBackfillProposal input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiBackfillGetResponse? GetBackfill(GetBackfill input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteBackfill(DeleteBackfill input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AcceptBackfill(AcceptBackfill input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void RejectBackfill(RejectBackfill input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}