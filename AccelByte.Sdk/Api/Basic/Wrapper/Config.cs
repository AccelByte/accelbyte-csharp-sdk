// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class Config
    {
        private readonly AccelByteSDK _sdk;

        public Config(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreateConfig.CreateConfigBuilder CreateConfigOp
        {
            get { return Operation.CreateConfig.Builder.SetWrapperObject(this); }
        }
        public GetConfig1.GetConfig1Builder GetConfig1Op
        {
            get { return Operation.GetConfig1.Builder.SetWrapperObject(this); }
        }
        public DeleteConfig1.DeleteConfig1Builder DeleteConfig1Op
        {
            get { return Operation.DeleteConfig1.Builder.SetWrapperObject(this); }
        }
        public UpdateConfig1.UpdateConfig1Builder UpdateConfig1Op
        {
            get { return Operation.UpdateConfig1.Builder.SetWrapperObject(this); }
        }
        public GetPublisherConfig.GetPublisherConfigBuilder GetPublisherConfigOp
        {
            get { return Operation.GetPublisherConfig.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ConfigInfo? CreateConfig(CreateConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ConfigInfo? GetConfig1(GetConfig1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteConfig1(DeleteConfig1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ConfigInfo? UpdateConfig1(UpdateConfig1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ConfigInfo? GetPublisherConfig(GetPublisherConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}