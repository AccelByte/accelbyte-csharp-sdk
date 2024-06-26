// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Reporting.Wrapper
{
    public class AdminModerationRule
    {
        private readonly AccelByteSDK _sdk;

        public AdminModerationRule(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreateModerationRule.CreateModerationRuleBuilder CreateModerationRuleOp
        {
            get { return Operation.CreateModerationRule.Builder.SetWrapperObject(this); }
        }
        public UpdateModerationRule.UpdateModerationRuleBuilder UpdateModerationRuleOp
        {
            get { return Operation.UpdateModerationRule.Builder.SetWrapperObject(this); }
        }
        public DeleteModerationRule.DeleteModerationRuleBuilder DeleteModerationRuleOp
        {
            get { return Operation.DeleteModerationRule.Builder.SetWrapperObject(this); }
        }
        public UpdateModerationRuleStatus.UpdateModerationRuleStatusBuilder UpdateModerationRuleStatusOp
        {
            get { return Operation.UpdateModerationRuleStatus.Builder.SetWrapperObject(this); }
        }
        public GetModerationRules.GetModerationRulesBuilder GetModerationRulesOp
        {
            get { return Operation.GetModerationRules.Builder.SetWrapperObject(this); }
        }
        public GetModerationRuleDetails.GetModerationRuleDetailsBuilder GetModerationRuleDetailsOp
        {
            get { return Operation.GetModerationRuleDetails.Builder.SetWrapperObject(this); }
        }
        #endregion

        public void CreateModerationRule(CreateModerationRule input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CreateModerationRuleAsync(CreateModerationRule input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiModerationRuleResponse? UpdateModerationRule(UpdateModerationRule input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiModerationRuleResponse?> UpdateModerationRuleAsync(UpdateModerationRule input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteModerationRule(DeleteModerationRule input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteModerationRuleAsync(DeleteModerationRule input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateModerationRuleStatus(UpdateModerationRuleStatus input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UpdateModerationRuleStatusAsync(UpdateModerationRuleStatus input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiModerationRulesList? GetModerationRules(GetModerationRules input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiModerationRulesList?> GetModerationRulesAsync(GetModerationRules input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiModerationRuleResponse? GetModerationRuleDetails(GetModerationRuleDetails input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiModerationRuleResponse?> GetModerationRuleDetailsAsync(GetModerationRuleDetails input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}