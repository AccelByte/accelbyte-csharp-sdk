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
    /// ForgotPassword
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:PASSWORD:USER [UPDATE]' or valid basic auth header
    /// 
    ///  Special note for publisher-game scenario: Game Client should provide game namespace path parameter and Publisher Client should provide publisher namespace path parameter.
    /// 
    /// The password reset code will be sent to the publisher account's email address.
    /// </summary>
    public class ForgotPassword : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ForgotPasswordBuilder Builder = new ForgotPasswordBuilder();

        public class ForgotPasswordBuilder
        {
            
            
            internal ForgotPasswordBuilder() { }





            public ForgotPassword Build(
                ModelSendVerificationCodeRequest body,
                string namespace_
            )
            {
                return new ForgotPassword(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private ForgotPassword(ForgotPasswordBuilder builder,
            ModelSendVerificationCodeRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public ForgotPassword(
            string namespace_,            
            Model.ModelSendVerificationCodeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/forgotPassword";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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