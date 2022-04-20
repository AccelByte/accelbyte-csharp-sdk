// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Seasonpass.Wrapper
{
    public class Tier
    {
        private readonly AccelByteSDK _sdk;

        public Tier(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryTiers.QueryTiersBuilder QueryTiersOp
        {
            get { return Operation.QueryTiers.Builder.SetWrapperObject(this); }
        }
        public CreateTier.CreateTierBuilder CreateTierOp
        {
            get { return Operation.CreateTier.Builder.SetWrapperObject(this); }
        }
        public UpdateTier.UpdateTierBuilder UpdateTierOp
        {
            get { return Operation.UpdateTier.Builder.SetWrapperObject(this); }
        }
        public DeleteTier.DeleteTierBuilder DeleteTierOp
        {
            get { return Operation.DeleteTier.Builder.SetWrapperObject(this); }
        }
        public ReorderTier.ReorderTierBuilder ReorderTierOp
        {
            get { return Operation.ReorderTier.Builder.SetWrapperObject(this); }
        }
        public GrantUserExp.GrantUserExpBuilder GrantUserExpOp
        {
            get { return Operation.GrantUserExp.Builder.SetWrapperObject(this); }
        }
        public GrantUserTier.GrantUserTierBuilder GrantUserTierOp
        {
            get { return Operation.GrantUserTier.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.TierPagingSlicedResult? QueryTiers(QueryTiers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.Tier>? CreateTier(CreateTier input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Tier? UpdateTier(UpdateTier input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTier(DeleteTier input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.Tier? ReorderTier(ReorderTier input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSeasonSummary? GrantUserExp(GrantUserExp input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSeasonSummary? GrantUserTier(GrantUserTier input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}