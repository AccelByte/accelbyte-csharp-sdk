// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Challenge.Wrapper
{
    public class Schedules
    {
        private readonly AccelByteSDK _sdk;

        public Schedules(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListSchedulesByGoal.AdminListSchedulesByGoalBuilder AdminListSchedulesByGoalOp
        {
            get { return Operation.AdminListSchedulesByGoal.Builder.SetWrapperObject(this); }
        }
        public AdminListSchedules.AdminListSchedulesBuilder AdminListSchedulesOp
        {
            get { return Operation.AdminListSchedules.Builder.SetWrapperObject(this); }
        }
        public PublicListSchedulesByGoal.PublicListSchedulesByGoalBuilder PublicListSchedulesByGoalOp
        {
            get { return Operation.PublicListSchedulesByGoal.Builder.SetWrapperObject(this); }
        }
        public PublicListSchedules.PublicListSchedulesBuilder PublicListSchedulesOp
        {
            get { return Operation.PublicListSchedules.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelListScheduleByGoalResponse? AdminListSchedulesByGoal(AdminListSchedulesByGoal input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelListScheduleByGoalResponse?> AdminListSchedulesByGoalAsync(AdminListSchedulesByGoal input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListSchedulesResponse? AdminListSchedules(AdminListSchedules input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelListSchedulesResponse?> AdminListSchedulesAsync(AdminListSchedules input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListScheduleByGoalResponse? PublicListSchedulesByGoal(PublicListSchedulesByGoal input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelListScheduleByGoalResponse?> PublicListSchedulesByGoalAsync(PublicListSchedulesByGoal input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListSchedulesResponse? PublicListSchedules(PublicListSchedules input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelListSchedulesResponse?> PublicListSchedulesAsync(PublicListSchedules input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}