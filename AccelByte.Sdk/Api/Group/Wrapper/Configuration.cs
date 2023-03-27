// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class Configuration
    {
        private readonly AccelByteSDK _sdk;

        public Configuration(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListGroupConfigurationAdminV1.ListGroupConfigurationAdminV1Builder ListGroupConfigurationAdminV1Op
        {
            get { return Operation.ListGroupConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public CreateGroupConfigurationAdminV1.CreateGroupConfigurationAdminV1Builder CreateGroupConfigurationAdminV1Op
        {
            get { return Operation.CreateGroupConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public InitiateGroupConfigurationAdminV1.InitiateGroupConfigurationAdminV1Builder InitiateGroupConfigurationAdminV1Op
        {
            get { return Operation.InitiateGroupConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetGroupConfigurationAdminV1.GetGroupConfigurationAdminV1Builder GetGroupConfigurationAdminV1Op
        {
            get { return Operation.GetGroupConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public DeleteGroupConfigurationV1.DeleteGroupConfigurationV1Builder DeleteGroupConfigurationV1Op
        {
            get { return Operation.DeleteGroupConfigurationV1.Builder.SetWrapperObject(this); }
        }
        public UpdateGroupConfigurationAdminV1.UpdateGroupConfigurationAdminV1Builder UpdateGroupConfigurationAdminV1Op
        {
            get { return Operation.UpdateGroupConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public UpdateGroupConfigurationGlobalRuleAdminV1.UpdateGroupConfigurationGlobalRuleAdminV1Builder UpdateGroupConfigurationGlobalRuleAdminV1Op
        {
            get { return Operation.UpdateGroupConfigurationGlobalRuleAdminV1.Builder.SetWrapperObject(this); }
        }
        public DeleteGroupConfigurationGlobalRuleAdminV1.DeleteGroupConfigurationGlobalRuleAdminV1Builder DeleteGroupConfigurationGlobalRuleAdminV1Op
        {
            get { return Operation.DeleteGroupConfigurationGlobalRuleAdminV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsListConfigurationResponseV1? ListGroupConfigurationAdminV1(ListGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupConfigurationResponseV1? CreateGroupConfigurationAdminV1(CreateGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupConfigurationResponseV1? InitiateGroupConfigurationAdminV1(InitiateGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupConfigurationResponseV1? GetGroupConfigurationAdminV1(GetGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupConfigurationV1(DeleteGroupConfigurationV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateGroupConfigurationResponseV1? UpdateGroupConfigurationAdminV1(UpdateGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateGroupConfigurationResponseV1? UpdateGroupConfigurationGlobalRuleAdminV1(UpdateGroupConfigurationGlobalRuleAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateGroupConfigurationResponseV1? DeleteGroupConfigurationGlobalRuleAdminV1(DeleteGroupConfigurationGlobalRuleAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}