// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Api.Dsmc.Operation.Deprecated;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class Config
    {
        private readonly AccelByteSDK _sdk;

        public Config(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListConfig.ListConfigBuilder ListConfigOp
        {
            get { return Operation.ListConfig.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SaveConfig.SaveConfigBuilder SaveConfigOp
        {
            get { return Operation.Deprecated.SaveConfig.Builder.SetWrapperObject(this); }
        }
        public GetConfig.GetConfigBuilder GetConfigOp
        {
            get { return Operation.GetConfig.Builder.SetWrapperObject(this); }
        }
        public CreateConfig.CreateConfigBuilder CreateConfigOp
        {
            get { return Operation.CreateConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteConfig.DeleteConfigBuilder DeleteConfigOp
        {
            get { return Operation.DeleteConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateConfig.UpdateConfigBuilder UpdateConfigOp
        {
            get { return Operation.UpdateConfig.Builder.SetWrapperObject(this); }
        }
        public ClearCache.ClearCacheBuilder ClearCacheOp
        {
            get { return Operation.ClearCache.Builder.SetWrapperObject(this); }
        }
        public AddPort.AddPortBuilder AddPortOp
        {
            get { return Operation.AddPort.Builder.SetWrapperObject(this); }
        }
        public DeletePort.DeletePortBuilder DeletePortOp
        {
            get { return Operation.DeletePort.Builder.SetWrapperObject(this); }
        }
        public UpdatePort.UpdatePortBuilder UpdatePortOp
        {
            get { return Operation.UpdatePort.Builder.SetWrapperObject(this); }
        }
        public ExportConfigV1.ExportConfigV1Builder ExportConfigV1Op
        {
            get { return Operation.ExportConfigV1.Builder.SetWrapperObject(this); }
        }
        public ImportConfigV1.ImportConfigV1Builder ImportConfigV1Op
        {
            get { return Operation.ImportConfigV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsListConfigResponse? ListConfig(ListConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void SaveConfig(SaveConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ModelsDSMConfigRecord? GetConfig(GetConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? CreateConfig(CreateConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteConfig(DeleteConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? UpdateConfig(UpdateConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ClearCache(ClearCache input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? AddPort(AddPort input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? DeletePort(DeletePort input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? UpdatePort(UpdatePort input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigExport? ExportConfigV1(ExportConfigV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsImportResponse? ImportConfigV1(ImportConfigV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}