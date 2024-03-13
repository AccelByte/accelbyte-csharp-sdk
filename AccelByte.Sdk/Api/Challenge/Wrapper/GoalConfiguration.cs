// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Challenge.Wrapper
{
    public class GoalConfiguration
    {
        private readonly AccelByteSDK _sdk;

        public GoalConfiguration(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetGoals.AdminGetGoalsBuilder AdminGetGoalsOp
        {
            get { return Operation.AdminGetGoals.Builder.SetWrapperObject(this); }
        }
        public AdminCreateGoal.AdminCreateGoalBuilder AdminCreateGoalOp
        {
            get { return Operation.AdminCreateGoal.Builder.SetWrapperObject(this); }
        }
        public AdminGetGoal.AdminGetGoalBuilder AdminGetGoalOp
        {
            get { return Operation.AdminGetGoal.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateGoals.AdminUpdateGoalsBuilder AdminUpdateGoalsOp
        {
            get { return Operation.AdminUpdateGoals.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteGoal.AdminDeleteGoalBuilder AdminDeleteGoalOp
        {
            get { return Operation.AdminDeleteGoal.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelGetGoalsResponse? AdminGetGoals(AdminGetGoals input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGoalResponse? AdminCreateGoal(AdminCreateGoal input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGoalResponse? AdminGetGoal(AdminGetGoal input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGoalResponse? AdminUpdateGoals(AdminUpdateGoals input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteGoal(AdminDeleteGoal input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}