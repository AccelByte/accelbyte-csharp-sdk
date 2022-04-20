// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
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
            get { return Operation.SaveConfig.Builder.SetWrapperObject(this); }
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

    public static class Config_OperationExtensions
    {
        public static Model.ModelsListConfigResponse? Execute(
            this ListConfig.ListConfigBuilder builder
        )
        {
            ListConfig op = builder.Build(
            );

            return ((Config)builder.WrapperObject!).ListConfig(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this SaveConfig.SaveConfigBuilder builder,
            ModelsDSMConfigRecord body
        )
        {
            SaveConfig op = builder.Build(
                body
            );

            ((Config)builder.WrapperObject!).SaveConfig(op);
        }

        public static Model.ModelsDSMConfigRecord? Execute(
            this GetConfig.GetConfigBuilder builder,
            string namespace_
        )
        {
            GetConfig op = builder.Build(
                namespace_
            );

            return ((Config)builder.WrapperObject!).GetConfig(op);
        }

        public static Model.ModelsDSMConfigRecord? Execute(
            this CreateConfig.CreateConfigBuilder builder,
            ModelsCreateDSMConfigRequest body,
            string namespace_
        )
        {
            CreateConfig op = builder.Build(
                body,
                namespace_
            );

            return ((Config)builder.WrapperObject!).CreateConfig(op);
        }

        public static void Execute(
            this DeleteConfig.DeleteConfigBuilder builder,
            string namespace_
        )
        {
            DeleteConfig op = builder.Build(
                namespace_
            );

            ((Config)builder.WrapperObject!).DeleteConfig(op);
        }

        public static Model.ModelsDSMConfigRecord? Execute(
            this UpdateConfig.UpdateConfigBuilder builder,
            ModelsUpdateDSMConfigRequest body,
            string namespace_
        )
        {
            UpdateConfig op = builder.Build(
                body,
                namespace_
            );

            return ((Config)builder.WrapperObject!).UpdateConfig(op);
        }

        public static void Execute(
            this ClearCache.ClearCacheBuilder builder,
            string namespace_
        )
        {
            ClearCache op = builder.Build(
                namespace_
            );

            ((Config)builder.WrapperObject!).ClearCache(op);
        }

        public static Model.ModelsDSMConfigRecord? Execute(
            this AddPort.AddPortBuilder builder,
            ModelsCreatePortRequest body,
            string name,
            string namespace_
        )
        {
            AddPort op = builder.Build(
                body,
                name,
                namespace_
            );

            return ((Config)builder.WrapperObject!).AddPort(op);
        }

        public static Model.ModelsDSMConfigRecord? Execute(
            this DeletePort.DeletePortBuilder builder,
            string name,
            string namespace_
        )
        {
            DeletePort op = builder.Build(
                name,
                namespace_
            );

            return ((Config)builder.WrapperObject!).DeletePort(op);
        }

        public static Model.ModelsDSMConfigRecord? Execute(
            this UpdatePort.UpdatePortBuilder builder,
            ModelsUpdatePortRequest body,
            string name,
            string namespace_
        )
        {
            UpdatePort op = builder.Build(
                body,
                name,
                namespace_
            );

            return ((Config)builder.WrapperObject!).UpdatePort(op);
        }

        public static Model.ModelsDSMConfigExport? Execute(
            this ExportConfigV1.ExportConfigV1Builder builder,
            string namespace_
        )
        {
            ExportConfigV1 op = builder.Build(
                namespace_
            );

            return ((Config)builder.WrapperObject!).ExportConfigV1(op);
        }

        public static Model.ModelsImportResponse? Execute(
            this ImportConfigV1.ImportConfigV1Builder builder,
            string namespace_
        )
        {
            ImportConfigV1 op = builder.Build(
                namespace_
            );

            return ((Config)builder.WrapperObject!).ImportConfigV1(op);
        }

    }
}