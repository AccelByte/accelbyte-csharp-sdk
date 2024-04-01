// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class DeploymentConfig
    {
        private readonly AccelByteSDK _sdk;

        public DeploymentConfig(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetAllDeployment.GetAllDeploymentBuilder GetAllDeploymentOp
        {
            get { return Operation.GetAllDeployment.Builder.SetWrapperObject(this); }
        }
        public GetDeployment.GetDeploymentBuilder GetDeploymentOp
        {
            get { return Operation.GetDeployment.Builder.SetWrapperObject(this); }
        }
        public CreateDeployment.CreateDeploymentBuilder CreateDeploymentOp
        {
            get { return Operation.CreateDeployment.Builder.SetWrapperObject(this); }
        }
        public DeleteDeployment.DeleteDeploymentBuilder DeleteDeploymentOp
        {
            get { return Operation.DeleteDeployment.Builder.SetWrapperObject(this); }
        }
        public UpdateDeployment.UpdateDeploymentBuilder UpdateDeploymentOp
        {
            get { return Operation.UpdateDeployment.Builder.SetWrapperObject(this); }
        }
        public CreateRootRegionOverride.CreateRootRegionOverrideBuilder CreateRootRegionOverrideOp
        {
            get { return Operation.CreateRootRegionOverride.Builder.SetWrapperObject(this); }
        }
        public DeleteRootRegionOverride.DeleteRootRegionOverrideBuilder DeleteRootRegionOverrideOp
        {
            get { return Operation.DeleteRootRegionOverride.Builder.SetWrapperObject(this); }
        }
        public UpdateRootRegionOverride.UpdateRootRegionOverrideBuilder UpdateRootRegionOverrideOp
        {
            get { return Operation.UpdateRootRegionOverride.Builder.SetWrapperObject(this); }
        }
        public CreateDeploymentOverride.CreateDeploymentOverrideBuilder CreateDeploymentOverrideOp
        {
            get { return Operation.CreateDeploymentOverride.Builder.SetWrapperObject(this); }
        }
        public DeleteDeploymentOverride.DeleteDeploymentOverrideBuilder DeleteDeploymentOverrideOp
        {
            get { return Operation.DeleteDeploymentOverride.Builder.SetWrapperObject(this); }
        }
        public UpdateDeploymentOverride.UpdateDeploymentOverrideBuilder UpdateDeploymentOverrideOp
        {
            get { return Operation.UpdateDeploymentOverride.Builder.SetWrapperObject(this); }
        }
        public CreateOverrideRegionOverride.CreateOverrideRegionOverrideBuilder CreateOverrideRegionOverrideOp
        {
            get { return Operation.CreateOverrideRegionOverride.Builder.SetWrapperObject(this); }
        }
        public DeleteOverrideRegionOverride.DeleteOverrideRegionOverrideBuilder DeleteOverrideRegionOverrideOp
        {
            get { return Operation.DeleteOverrideRegionOverride.Builder.SetWrapperObject(this); }
        }
        public UpdateOverrideRegionOverride.UpdateOverrideRegionOverrideBuilder UpdateOverrideRegionOverrideOp
        {
            get { return Operation.UpdateOverrideRegionOverride.Builder.SetWrapperObject(this); }
        }
        public GetAllDeploymentClient.GetAllDeploymentClientBuilder GetAllDeploymentClientOp
        {
            get { return Operation.GetAllDeploymentClient.Builder.SetWrapperObject(this); }
        }
        public CreateDeploymentClient.CreateDeploymentClientBuilder CreateDeploymentClientOp
        {
            get { return Operation.CreateDeploymentClient.Builder.SetWrapperObject(this); }
        }
        public DeleteDeploymentClient.DeleteDeploymentClientBuilder DeleteDeploymentClientOp
        {
            get { return Operation.DeleteDeploymentClient.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsListDeploymentResponse? GetAllDeployment(GetAllDeployment input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListDeploymentResponse?> GetAllDeploymentAsync(GetAllDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? GetDeployment(GetDeployment input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> GetDeploymentAsync(GetDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? CreateDeployment(CreateDeployment input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> CreateDeploymentAsync(CreateDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteDeployment(DeleteDeployment input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteDeploymentAsync(DeleteDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? UpdateDeployment(UpdateDeployment input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> UpdateDeploymentAsync(UpdateDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? CreateRootRegionOverride(CreateRootRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> CreateRootRegionOverrideAsync(CreateRootRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? DeleteRootRegionOverride(DeleteRootRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> DeleteRootRegionOverrideAsync(DeleteRootRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? UpdateRootRegionOverride(UpdateRootRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> UpdateRootRegionOverrideAsync(UpdateRootRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? CreateDeploymentOverride(CreateDeploymentOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> CreateDeploymentOverrideAsync(CreateDeploymentOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? DeleteDeploymentOverride(DeleteDeploymentOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> DeleteDeploymentOverrideAsync(DeleteDeploymentOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? UpdateDeploymentOverride(UpdateDeploymentOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> UpdateDeploymentOverrideAsync(UpdateDeploymentOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? CreateOverrideRegionOverride(CreateOverrideRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> CreateOverrideRegionOverrideAsync(CreateOverrideRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? DeleteOverrideRegionOverride(DeleteOverrideRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> DeleteOverrideRegionOverrideAsync(DeleteOverrideRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? UpdateOverrideRegionOverride(UpdateOverrideRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> UpdateOverrideRegionOverrideAsync(UpdateOverrideRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListDeploymentResponse? GetAllDeploymentClient(GetAllDeploymentClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListDeploymentResponse?> GetAllDeploymentClientAsync(GetAllDeploymentClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? CreateDeploymentClient(CreateDeploymentClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeploymentWithOverride?> CreateDeploymentClientAsync(CreateDeploymentClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteDeploymentClient(DeleteDeploymentClient input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteDeploymentClientAsync(DeleteDeploymentClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}