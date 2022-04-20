// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class SSO
    {
        private readonly AccelByteSDK _sdk;

        public SSO(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public LoginSSOClient.LoginSSOClientBuilder LoginSSOClientOp
        {
            get { return Operation.LoginSSOClient.Builder.SetWrapperObject(this); }
        }
        public LogoutSSOClient.LogoutSSOClientBuilder LogoutSSOClientOp
        {
            get { return Operation.LogoutSSOClient.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void LoginSSOClient(LoginSSOClient input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void LogoutSSOClient(LogoutSSOClient input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class SSO_OperationExtensions
    {
        public static void Execute(
            this LoginSSOClient.LoginSSOClientBuilder builder,
            string platformId
        )
        {
            LoginSSOClient op = builder.Build(
                platformId
            );

            ((SSO)builder.WrapperObject!).LoginSSOClient(op);
        }

        public static void Execute(
            this LogoutSSOClient.LogoutSSOClientBuilder builder,
            string platformId
        )
        {
            LogoutSSOClient op = builder.Build(
                platformId
            );

            ((SSO)builder.WrapperObject!).LogoutSSOClient(op);
        }

    }
}