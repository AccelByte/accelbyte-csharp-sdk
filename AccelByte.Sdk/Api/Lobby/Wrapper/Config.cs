// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Config
    {
        private readonly AccelByteSDK _sdk;

        public Config(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetAllConfigV1.AdminGetAllConfigV1Builder AdminGetAllConfigV1Op
        {
            get { return Operation.AdminGetAllConfigV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetConfigV1.AdminGetConfigV1Builder AdminGetConfigV1Op
        {
            get { return Operation.AdminGetConfigV1.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateConfigV1.AdminUpdateConfigV1Builder AdminUpdateConfigV1Op
        {
            get { return Operation.AdminUpdateConfigV1.Builder.SetWrapperObject(this); }
        }
        public AdminExportConfigV1.AdminExportConfigV1Builder AdminExportConfigV1Op
        {
            get { return Operation.AdminExportConfigV1.Builder.SetWrapperObject(this); }
        }
        public AdminImportConfigV1.AdminImportConfigV1Builder AdminImportConfigV1Op
        {
            get { return Operation.AdminImportConfigV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsConfigList? AdminGetAllConfigV1(AdminGetAllConfigV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsConfigReq? AdminGetConfigV1(AdminGetConfigV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsConfigReq? AdminUpdateConfigV1(AdminUpdateConfigV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsConfigExport? AdminExportConfigV1(AdminExportConfigV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsImportConfigResponse? AdminImportConfigV1(AdminImportConfigV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Config_OperationExtensions
    {
        public static Model.ModelsConfigList? Execute(
            this AdminGetAllConfigV1.AdminGetAllConfigV1Builder builder
        )
        {
            AdminGetAllConfigV1 op = builder.Build(
            );

            return ((Config)builder.WrapperObject!).AdminGetAllConfigV1(op);
        }

        public static Model.ModelsConfigReq? Execute(
            this AdminGetConfigV1.AdminGetConfigV1Builder builder,
            string namespace_
        )
        {
            AdminGetConfigV1 op = builder.Build(
                namespace_
            );

            return ((Config)builder.WrapperObject!).AdminGetConfigV1(op);
        }

        public static Model.ModelsConfigReq? Execute(
            this AdminUpdateConfigV1.AdminUpdateConfigV1Builder builder,
            ModelsConfigReq body,
            string namespace_
        )
        {
            AdminUpdateConfigV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Config)builder.WrapperObject!).AdminUpdateConfigV1(op);
        }

        public static Model.ModelsConfigExport? Execute(
            this AdminExportConfigV1.AdminExportConfigV1Builder builder,
            string namespace_
        )
        {
            AdminExportConfigV1 op = builder.Build(
                namespace_
            );

            return ((Config)builder.WrapperObject!).AdminExportConfigV1(op);
        }

        public static Model.ModelsImportConfigResponse? Execute(
            this AdminImportConfigV1.AdminImportConfigV1Builder builder,
            string namespace_
        )
        {
            AdminImportConfigV1 op = builder.Build(
                namespace_
            );

            return ((Config)builder.WrapperObject!).AdminImportConfigV1(op);
        }

    }
}