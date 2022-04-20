// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class ThirdParty
    {
        private readonly AccelByteSDK _sdk;

        public ThirdParty(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetThirdPartyConfig.AdminGetThirdPartyConfigBuilder AdminGetThirdPartyConfigOp
        {
            get { return Operation.AdminGetThirdPartyConfig.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateThirdPartyConfig.AdminUpdateThirdPartyConfigBuilder AdminUpdateThirdPartyConfigOp
        {
            get { return Operation.AdminUpdateThirdPartyConfig.Builder.SetWrapperObject(this); }
        }
        public AdminCreateThirdPartyConfig.AdminCreateThirdPartyConfigBuilder AdminCreateThirdPartyConfigOp
        {
            get { return Operation.AdminCreateThirdPartyConfig.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteThirdPartyConfig.AdminDeleteThirdPartyConfigBuilder AdminDeleteThirdPartyConfigOp
        {
            get { return Operation.AdminDeleteThirdPartyConfig.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsGetConfigResponse? AdminGetThirdPartyConfig(AdminGetThirdPartyConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateConfigResponse? AdminUpdateThirdPartyConfig(AdminUpdateThirdPartyConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateConfigResponse? AdminCreateThirdPartyConfig(AdminCreateThirdPartyConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public string? AdminDeleteThirdPartyConfig(AdminDeleteThirdPartyConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class ThirdParty_OperationExtensions
    {
        public static Model.ModelsGetConfigResponse? Execute(
            this AdminGetThirdPartyConfig.AdminGetThirdPartyConfigBuilder builder,
            string namespace_
        )
        {
            AdminGetThirdPartyConfig op = builder.Build(
                namespace_
            );

            return ((ThirdParty)builder.WrapperObject!).AdminGetThirdPartyConfig(op);
        }

        public static Model.ModelsUpdateConfigResponse? Execute(
            this AdminUpdateThirdPartyConfig.AdminUpdateThirdPartyConfigBuilder builder,
            ModelsUpdateConfigRequest body,
            string namespace_
        )
        {
            AdminUpdateThirdPartyConfig op = builder.Build(
                body,
                namespace_
            );

            return ((ThirdParty)builder.WrapperObject!).AdminUpdateThirdPartyConfig(op);
        }

        public static Model.ModelsCreateConfigResponse? Execute(
            this AdminCreateThirdPartyConfig.AdminCreateThirdPartyConfigBuilder builder,
            ModelsCreateConfigRequest body,
            string namespace_
        )
        {
            AdminCreateThirdPartyConfig op = builder.Build(
                body,
                namespace_
            );

            return ((ThirdParty)builder.WrapperObject!).AdminCreateThirdPartyConfig(op);
        }

        public static string? Execute(
            this AdminDeleteThirdPartyConfig.AdminDeleteThirdPartyConfigBuilder builder,
            string namespace_
        )
        {
            AdminDeleteThirdPartyConfig op = builder.Build(
                namespace_
            );

            return ((ThirdParty)builder.WrapperObject!).AdminDeleteThirdPartyConfig(op);
        }

    }
}