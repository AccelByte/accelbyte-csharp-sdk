// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth20V4
    {
        private readonly AccelByteSDK _sdk;

        public OAuth20V4(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AuthenticationWithPlatformLinkV4.AuthenticationWithPlatformLinkV4Builder AuthenticationWithPlatformLinkV4Op
        {
            get { return Operation.AuthenticationWithPlatformLinkV4.Builder.SetWrapperObject(this); }
        }
        public GenerateTokenByNewHeadlessAccountV4.GenerateTokenByNewHeadlessAccountV4Builder GenerateTokenByNewHeadlessAccountV4Op
        {
            get { return Operation.GenerateTokenByNewHeadlessAccountV4.Builder.SetWrapperObject(this); }
        }
        public Verify2faCodeV4.Verify2faCodeV4Builder Verify2faCodeV4Op
        {
            get { return Operation.Verify2faCodeV4.Builder.SetWrapperObject(this); }
        }
        public PlatformTokenGrantV4.PlatformTokenGrantV4Builder PlatformTokenGrantV4Op
        {
            get { return Operation.PlatformTokenGrantV4.Builder.SetWrapperObject(this); }
        }
        public SimultaneousLoginV4.SimultaneousLoginV4Builder SimultaneousLoginV4Op
        {
            get { return Operation.SimultaneousLoginV4.Builder.SetWrapperObject(this); }
        }
        public TokenGrantV4.TokenGrantV4Builder TokenGrantV4Op
        {
            get { return Operation.TokenGrantV4.Builder.SetWrapperObject(this); }
        }
        public RequestTargetTokenResponseV4.RequestTargetTokenResponseV4Builder RequestTargetTokenResponseV4Op
        {
            get { return Operation.RequestTargetTokenResponseV4.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.OauthmodelTokenResponseV3? AuthenticationWithPlatformLinkV4(AuthenticationWithPlatformLinkV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> AuthenticationWithPlatformLinkV4Async(AuthenticationWithPlatformLinkV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? GenerateTokenByNewHeadlessAccountV4(GenerateTokenByNewHeadlessAccountV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> GenerateTokenByNewHeadlessAccountV4Async(GenerateTokenByNewHeadlessAccountV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? Verify2faCodeV4(Verify2faCodeV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> Verify2faCodeV4Async(Verify2faCodeV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? PlatformTokenGrantV4(PlatformTokenGrantV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> PlatformTokenGrantV4Async(PlatformTokenGrantV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? SimultaneousLoginV4(SimultaneousLoginV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> SimultaneousLoginV4Async(SimultaneousLoginV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenWithDeviceCookieResponseV3? TokenGrantV4(TokenGrantV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenWithDeviceCookieResponseV3?> TokenGrantV4Async(TokenGrantV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? RequestTargetTokenResponseV4(RequestTargetTokenResponseV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> RequestTargetTokenResponseV4Async(RequestTargetTokenResponseV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}