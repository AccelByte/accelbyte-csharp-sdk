// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// LoginSSOClient
    /// </summary>
    public class LoginSSOClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LoginSSOClientBuilder Builder = new LoginSSOClientBuilder();

        public class LoginSSOClientBuilder
            : OperationBuilder<LoginSSOClientBuilder>
        {
            
            public string? Payload { get; set; }
            
            internal LoginSSOClientBuilder() { }


            public LoginSSOClientBuilder SetPayload(string _payload)
            {
                Payload = _payload;
                return this;
            }





            public LoginSSOClient Build(
                string platformId
            )
            {
                LoginSSOClient op = new LoginSSOClient(this,
                    platformId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private LoginSSOClient(LoginSSOClientBuilder builder,
            string platformId
        )
        {
            PathParams["platformId"] = platformId;
            
            if (builder.Payload != null) QueryParams["payload"] = builder.Payload;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public LoginSSOClient(
            string platformId,            
            string? payload            
        )
        {
            PathParams["platformId"] = platformId;
            
            if (payload != null) QueryParams["payload"] = payload;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/sso/{platformId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}