// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class PodConfig
    {
        private readonly AccelByteSDK _sdk;

        public PodConfig(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetAllPodConfig.GetAllPodConfigBuilder GetAllPodConfigOp
        {
            get { return Operation.GetAllPodConfig.Builder.SetWrapperObject(this); }
        }
        public GetPodConfig.GetPodConfigBuilder GetPodConfigOp
        {
            get { return Operation.GetPodConfig.Builder.SetWrapperObject(this); }
        }
        public CreatePodConfig.CreatePodConfigBuilder CreatePodConfigOp
        {
            get { return Operation.CreatePodConfig.Builder.SetWrapperObject(this); }
        }
        public DeletePodConfig.DeletePodConfigBuilder DeletePodConfigOp
        {
            get { return Operation.DeletePodConfig.Builder.SetWrapperObject(this); }
        }
        public UpdatePodConfig.UpdatePodConfigBuilder UpdatePodConfigOp
        {
            get { return Operation.UpdatePodConfig.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsListPodConfigResponse? GetAllPodConfig(GetAllPodConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPodConfigRecord? GetPodConfig(GetPodConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPodConfigRecord? CreatePodConfig(CreatePodConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePodConfig(DeletePodConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPodConfigRecord? UpdatePodConfig(UpdatePodConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}