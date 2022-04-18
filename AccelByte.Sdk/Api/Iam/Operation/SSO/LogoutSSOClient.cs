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
    /// LogoutSSOClient
    ///
    /// Logout user's session on platform that logged in using SSO.
    /// 
    /// Supported platforms:
    /// - discourse
    /// </summary>
    public class LogoutSSOClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LogoutSSOClientBuilder Builder = new LogoutSSOClientBuilder();

        public class LogoutSSOClientBuilder
            : OperationBuilder<LogoutSSOClientBuilder>
        {
            
            internal LogoutSSOClientBuilder() { }





            public LogoutSSOClient Build(
                string platformId
            )
            {
                LogoutSSOClient op = new LogoutSSOClient(this,
                    platformId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private LogoutSSOClient(LogoutSSOClientBuilder builder,
            string platformId
        )
        {
            PathParams["platformId"] = platformId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public LogoutSSOClient(
            string platformId            
        )
        {
            PathParams["platformId"] = platformId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/sso/{platformId}/logout";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}