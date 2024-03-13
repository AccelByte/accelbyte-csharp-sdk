// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Challenge.Wrapper
{
    public class ChallengeConfiguration
    {
        private readonly AccelByteSDK _sdk;

        public ChallengeConfiguration(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetChallenges.AdminGetChallengesBuilder AdminGetChallengesOp
        {
            get { return Operation.AdminGetChallenges.Builder.SetWrapperObject(this); }
        }
        public AdminCreateChallenge.AdminCreateChallengeBuilder AdminCreateChallengeOp
        {
            get { return Operation.AdminCreateChallenge.Builder.SetWrapperObject(this); }
        }
        public AdminGetChallenge.AdminGetChallengeBuilder AdminGetChallengeOp
        {
            get { return Operation.AdminGetChallenge.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateChallenge.AdminUpdateChallengeBuilder AdminUpdateChallengeOp
        {
            get { return Operation.AdminUpdateChallenge.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteChallenge.AdminDeleteChallengeBuilder AdminDeleteChallengeOp
        {
            get { return Operation.AdminDeleteChallenge.Builder.SetWrapperObject(this); }
        }
        public AdminGetPeriods.AdminGetPeriodsBuilder AdminGetPeriodsOp
        {
            get { return Operation.AdminGetPeriods.Builder.SetWrapperObject(this); }
        }
        public AdminRandomizeChallenge.AdminRandomizeChallengeBuilder AdminRandomizeChallengeOp
        {
            get { return Operation.AdminRandomizeChallenge.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteTiedChallenge.AdminDeleteTiedChallengeBuilder AdminDeleteTiedChallengeOp
        {
            get { return Operation.AdminDeleteTiedChallenge.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelListChallengeResponse? AdminGetChallenges(AdminGetChallenges input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelChallengeResponse? AdminCreateChallenge(AdminCreateChallenge input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelChallengeResponse? AdminGetChallenge(AdminGetChallenge input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelChallengeResponse? AdminUpdateChallenge(AdminUpdateChallenge input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteChallenge(AdminDeleteChallenge input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListPeriodsResponse? AdminGetPeriods(AdminGetPeriods input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelSchedule>? AdminRandomizeChallenge(AdminRandomizeChallenge input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteTiedChallenge(AdminDeleteTiedChallenge input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}